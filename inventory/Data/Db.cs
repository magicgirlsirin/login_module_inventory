using System;
using System.Data.OleDb;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace inventory
{
    public class AppUser
    {
        public int UserID;
        public string Username;
        public string FullName;
        public string UserRole;
    }

    public static class Db
    {
        static string ConnStr =>
            "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
            System.IO.Path.Combine(Application.StartupPath, "sampledb.accdb") + ";";

        public static OleDbConnection Open()
        {
            var c = new OleDbConnection(ConnStr);
            c.Open();
            return c;
        }

        // Creates an empty sampledb.accdb next to the .exe
        static void EnsureDatabaseFile()
        {
            string path = Path.Combine(Application.StartupPath, "sampledb.accdb");
            if (File.Exists(path)) return;
            Type t = Type.GetTypeFromProgID("ADOX.Catalog");
            object cat = Activator.CreateInstance(t);
            try { t.InvokeMember("Create", BindingFlags.InvokeMethod, null, cat, new object[] { ConnStr }); }
            finally { Marshal.ReleaseComObject(cat); }
        }

        // Creates users table
        public static void EnsureUsersTable()
        {
            try
            {
                EnsureDatabaseFile();
                using (var c = Open())
                {
                    var t = c.GetSchema("Tables", new string[] { null, null, "Users", "TABLE" });
                    if (t.Rows.Count > 0) return;

                    new OleDbCommand(
                        "CREATE TABLE Users (" +
                        "UserID AUTOINCREMENT PRIMARY KEY, " +
                        "Username TEXT(50) NOT NULL, " +
                        "PasswordHash TEXT(255) NOT NULL, " +
                        "FullName TEXT(100) NOT NULL, " +
                        "UserRole TEXT(20) NOT NULL, " +
                        "IsActive YESNO)", c).ExecuteNonQuery();

                    new OleDbCommand("CREATE UNIQUE INDEX idxUsername ON Users (Username)", c)
                        .ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message, "Inventory Management System",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public static class PasswordHasher
    {
        const int Iterations = 10000;

        // Stored as "base64salt:base64hash" in Users.PasswordHash
        public static string Hash(string password)
        {
            byte[] salt = new byte[16];
            using (var rng = new RNGCryptoServiceProvider()) rng.GetBytes(salt);
            using (var kdf = new Rfc2898DeriveBytes(password, salt, Iterations))
                return Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(kdf.GetBytes(32));
        }

        public static bool Verify(string password, string stored)
        {
            var parts = stored.Split(':');
            if (parts.Length != 2) return false;
            byte[] salt = Convert.FromBase64String(parts[0]);
            byte[] expected = Convert.FromBase64String(parts[1]);
            byte[] actual;
            using (var kdf = new Rfc2898DeriveBytes(password, salt, Iterations))
                actual = kdf.GetBytes(32);

            int diff = 0;
            for (int i = 0; i < expected.Length; i++) diff |= expected[i] ^ actual[i];
            return diff == 0;
        }
    }

    public static class UserService
    {
        public static bool Register(string fullName, string username, string password, out string error)
        {
            error = null;
            try
            {
                using (var c = Open())
                {
                    using (var chk = new OleDbCommand("SELECT COUNT(*) FROM Users WHERE Username = ?", c))
                    {
                        chk.Parameters.AddWithValue("?", username);
                        if (Convert.ToInt32(chk.ExecuteScalar()) > 0)
                        {
                            error = "That username is already taken.";
                            return false;
                        }
                    }

                    int count;
                    using (var cnt = new OleDbCommand("SELECT COUNT(*) FROM Users", c))
                        count = Convert.ToInt32(cnt.ExecuteScalar());
                    string role = count == 0 ? "Admin" : "User"; // first account becomes Admin

                    using (var ins = new OleDbCommand(
                        "INSERT INTO Users (Username, PasswordHash, FullName, UserRole, IsActive) VALUES (?, ?, ?, ?, ?)", c))
                    {
                        ins.Parameters.AddWithValue("?", username);
                        ins.Parameters.AddWithValue("?", PasswordHasher.Hash(password));
                        ins.Parameters.AddWithValue("?", fullName);
                        ins.Parameters.AddWithValue("?", role);
                        ins.Parameters.Add("?", OleDbType.Boolean).Value = true;
                        ins.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        public static AppUser SignIn(string username, string password, out string error)
        {
            error = null;
            try
            {
                using (var c = Open())
                using (var cmd = new OleDbCommand(
                    "SELECT UserID, PasswordHash, FullName, UserRole, IsActive FROM Users WHERE Username = ?", c))
                {
                    cmd.Parameters.AddWithValue("?", username);
                    using (var r = cmd.ExecuteReader())
                    {
                        if (!r.Read() || !PasswordHasher.Verify(password, r.GetString(1)))
                        {
                            error = "Invalid username or password.";
                            return null;
                        }
                        if (!r.GetBoolean(4))
                        {
                            error = "This account is disabled.";
                            return null;
                        }
                        return new AppUser
                        {
                            UserID = r.GetInt32(0),
                            Username = username,
                            FullName = r.GetString(2),
                            UserRole = r.GetString(3)
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }

        static System.Data.OleDb.OleDbConnection Open() => Db.Open();
    }
}

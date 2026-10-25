using MySql.Data.MySqlClient;
using System;

namespace CivilManagementProject
{
    public class DBConnection
    {
        private DBConnection()
        {
            // Private constructor to prevent instantiation
        }

        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        private static DBConnection _instance = null;
        private MySqlConnection Connection = null;

        public static DBConnection Instance()
        {
            if (_instance == null)
            {
                _instance = new DBConnection();
            }
            return _instance;
        }

        public MySqlConnection SqlConnection
        {
            get { return Connection; }
        }

        public bool IsConnect()
        {
            // Validate required properties on this instance
            if (String.IsNullOrEmpty(ServerName) || String.IsNullOrEmpty(DatabaseName))
                return false;

            string connstring = string.Format(
                "Server={0}; database={1}; UID={2}; password={3}",
                ServerName, DatabaseName, UserName, Password);
 
            // instantiate and open the MySqlConnection stored in Connection
            Connection = new MySqlConnection(connstring);
            Connection.Open();
            return true;
        }

        public void Close()
        {
            if (Connection != null && Connection.State != System.Data.ConnectionState.Closed)
            {
                Connection.Close();
            }
        }
    }
}

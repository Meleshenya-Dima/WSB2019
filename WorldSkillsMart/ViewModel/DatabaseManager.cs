using System.Data.SqlClient;

namespace WorldSkillsMart.ViewModel
{
    class DatabaseManager
    {
        private static string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\meles\Desktop\WorldSkillsMart\WorldSkillsMart\Resources\WSMarch.mdf;Integrated Security=True";

        private static SqlConnection _sqlConnection;


        private static SqlCommand _sqlCommand;

        public static SqlConnection SqlConnection
        {
            get
            {
                if (_sqlConnection is null)
                {
                    _sqlConnection = new SqlConnection(_connectionString);
                }
                return _sqlConnection;
            }
        }

        public static SqlCommand SqlCommand
        {
            get
            {
                if (_sqlCommand is null)
                {
                    _sqlCommand = new SqlCommand();
                }
                return _sqlCommand;
            }
        }

        public static void OpenSqlConnection()
        {
            SqlConnection.Open();
        }
    }
}

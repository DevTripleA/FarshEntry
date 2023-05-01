using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FarshEntry
{
    internal static class DatabaseManager
    {
        internal static DataTable Fetch(string scriptFileName)
        {
            var connection = OpenConnection();

            var command = new SqlCommand(scriptFileName.RetrieveSqlCommandFromScript(), connection);

            var adapter = new SqlDataAdapter(command);

            var data = new DataTable();

            adapter.Fill(data);

            CloseConnection(connection);

            return data;
        }

        internal static bool Execute(string scriptFileName)
        {
            var connection = OpenConnection();

            var command = new SqlCommand(scriptFileName.RetrieveSqlCommandFromScript(), connection);

            var rowsAffected = command.ExecuteNonQuery();

            CloseConnection(connection);

            return rowsAffected > 0;
        }

        private static string RetrieveSqlCommandFromScript(this string scriptFileName)
        {
            var scriptsPath = ConfigurationManager.AppSettings["scriptsPath"];
            return File.ReadAllText($@"{scriptsPath}\{scriptFileName}.sql");
        }

        private static SqlConnection OpenConnection()
        {
            var connetionString = ConfigurationManager.ConnectionStrings["farshConnectionString"].ConnectionString;
            
            var connection = new SqlConnection(connetionString);
            
            connection.Open();
            
            return connection;
        }

        private static void CloseConnection(SqlConnection connection)
        {
            connection.Close();
        }
    }

    internal static class ScriptsFilesNames
    {
        internal static string FarshQuery => "FarshQuery";
        internal static string ChaptersQuery => "ChaptersQuery";
        internal static string ReadersQuery => "ReadersQuery";
    }
}

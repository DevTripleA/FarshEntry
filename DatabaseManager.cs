using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FarshEntry
{
    internal static class DatabaseManager
    {
        internal static DataTable Fetch(string scriptFileName, params object?[] args)
        {
            var connection = OpenConnection();

            var sql = scriptFileName.RetrieveSqlCommandFromScript().AddArgsToSqlCommand(args);

            var command = new SqlCommand(sql, connection);

            var adapter = new SqlDataAdapter(command);

            var data = new DataTable();

            adapter.Fill(data);

            CloseConnection(connection);

            return data;
        }

        internal static bool Execute(string scriptFileName, params object?[] args)
        {
            var connection = OpenConnection();

            var sql = scriptFileName.RetrieveSqlCommandFromScript().AddArgsToSqlCommand(args);

            var command = new SqlCommand(sql, connection);

            var rowsAffected = command.ExecuteNonQuery();

            CloseConnection(connection);

            return rowsAffected > 0;
        }

        private static string RetrieveSqlCommandFromScript(this string scriptFileName)
        {
            var scriptsPath = ConfigurationManager.AppSettings["scriptsPath"];
            return File.ReadAllText($@"{scriptsPath}\{scriptFileName}.sql");
        }

        private static string AddArgsToSqlCommand(this string sql, params object?[] args)
        {
            if (args == null || args.Length == 0)
                return sql;

            return string.Format(sql, args);
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
        internal static string WordsQuery => "WordsQuery";
        internal static string DifferencesQuery => "DifferencesQuery";
        internal static string MinorFarshQuery => "MinorFarshQuery";
        internal static string DifferenceIdQueryByWord => "DifferenceIdQueryByWord";
        internal static string DifferenceIdQueryByDifference => "DifferenceIdQueryByDifference";
        internal static string WaysQuery => "WaysQuery";
    }
}

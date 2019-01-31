using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ApplicationsAndContracts.DataAccess
{
    class SqlHelper
    {
        public static void Initialize(string alias, string db)
        {
            _alias = alias;
            _db = db;
        }

        private static string _alias;
        private static string _db;

        public static SqlConnection GetConnection()
        {
            return Progress.SQLConnection.ProgressSQL.GetConnection(_alias, _db);
        }


        public static DataTable ExecuteSqlCommand(string commandText, SqlParameter[] parameters)
        {
            return ExecuteSql(commandText, CommandType.Text, parameters);
        }

        public static DataTable ExecuteStoredProcedure(string commandText, SqlParameter[] parameters)
        {
            return ExecuteSql(commandText, CommandType.StoredProcedure, parameters);
        }

        private static DataTable ExecuteSql(string commandText, CommandType commandType, SqlParameter[] parameters)
        {

            var result = new DataTable();
            using (var connection = Progress.SQLConnection.ProgressSQL.GetConnection(_alias, _db))
            {
                using (var command = new SqlCommand(commandText, connection))
                {
                    command.CommandType = commandType;
                    command.CommandTimeout = 360;
                    command.Parameters.AddRange(parameters);

                    connection.Open();

                    var adapter = new SqlDataAdapter(command);
                    adapter.Fill(result);

                    connection.Close();
                }
            }
            return result;

        }

        public static void BulkCopy(string targetTableName, DataTable source)
        {
            using (var connection = Progress.SQLConnection.ProgressSQL.GetConnection(_alias, _db))
            {
                using (var bulkCopy = new SqlBulkCopy(connection.ConnectionString, SqlBulkCopyOptions.KeepIdentity))
                {
                    bulkCopy.DestinationTableName = targetTableName;
                    connection.Open();
                    bulkCopy.WriteToServer(source);
                    connection.Close();
                }
            }
        }
    }
}

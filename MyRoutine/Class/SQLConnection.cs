using Microsoft.Data.SqlClient;
using System.Collections.Specialized;
using System.Data;

namespace MyRoutine.Class
{
    public class SQLConnection
    {
        private SqlConnection _sqlConnection;

        public SQLConnection(string connectionString)
        {
            _sqlConnection = new SqlConnection(connectionString);
        }

        public SQLConnection(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public void OpenConnection()
        {
            if (_sqlConnection.State == ConnectionState.Closed)
            {
                _sqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (_sqlConnection.State == ConnectionState.Open)
            {
                _sqlConnection.Close();
            }
        }

        public DataTable ExecuteStoredProcedure(string storedProcedureName, Dictionary<string, string> parameters)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = _sqlConnection;
                sqlCommand.CommandText = storedProcedureName;
                sqlCommand.CommandType = CommandType.StoredProcedure;

                if(parameters != null) {
                    foreach (var param in parameters)
                    {
                        sqlCommand.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                DataTable? dataTable = new DataTable();


                dataTable.Load(sqlDataReader);
                return dataTable;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public DataTable ExecuteText(string strCommand)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = _sqlConnection;
                sqlCommand.CommandText = strCommand;
                sqlCommand.CommandType = CommandType.Text;

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                DataTable? dataTable = new DataTable();


                dataTable.Load(sqlDataReader);
                return dataTable;
            }
            catch (Exception)
            {
                throw;
            }
        }



    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Systory.Models;
using Systory.Services;

namespace Systory.Repository
{
    internal class DbDataRepo
    {
        Connection _connection = new Connection();
        DataTableManagement _dataTableManagement = new DataTableManagement();
        public List<BatchModel> GetListOfBatch()
        {
            var listOfBatch = new List<BatchModel>();
            var connectionString = _connection.GetConnectionString();
            var commandString = "select * from dbo.Batch";
            using var connection = new SqlConnection(connectionString);
            connection.Open();
            using var command = new SqlCommand(commandString,connection);
            using var reader = command.ExecuteReader();
            while(reader.Read())
            {
                listOfBatch.Add(new BatchModel()
                {
                    Batch = (int)reader["Batch"],
                    Year = (int)reader["Year"]
                });
            }
            connection.Close();
            return listOfBatch;
        }
        public List<MajorModel> GetListOfMajor()
        {
            var listOfMajor = new List<MajorModel>();
            var connectionString = _connection.GetConnectionString();
            var commandString = "select * from dbo.Major";
            using var connection = new SqlConnection(connectionString);
            connection.Open();
            using var command = new SqlCommand(commandString, connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                listOfMajor.Add(new MajorModel()
                {
                    MajorId = (int)reader["MajorId"],
                    MajorName = (string)reader["MajorName"],
                    Batch = (int)reader["Batch"]
                });
            }
            connection.Close();
            return listOfMajor;
        }
        public ErrorStatusModel InsertNewBatch(BatchModel batch)
        {
            try
            {
                var listOfbatch = new List<BatchModel>
                {
                    batch
                };
                var connectionString = _connection.GetConnectionString();
                var spName = StoredProcedureInsertNewBatch.SpName;
                var param = StoredProcedureInsertNewBatch.ParaName;
                var dataTable = _dataTableManagement.ConvertListOfObjectsToDataTable(listOfbatch);

                using var connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand(spName, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue(param, dataTable);
                command.ExecuteNonQuery();
                connection.Close();

                return new ErrorStatusModel()
                {
                    ErrorCode = ErrorCode.Success
                };
            }
            catch
            {
                return new ErrorStatusModel()
                {
                    ErrorCode = ErrorCode.Error
                };
            }
        }

        public int GetNewBatch()
        {
            var listOfBatch = GetListOfBatch();
            var lastBatch = listOfBatch.OrderByDescending(b => b.Batch).First();
            return lastBatch.Batch;
        }
        public int GetNewYear()
        {
            var listOfBatch = GetListOfBatch();
            var lastBatch = listOfBatch.OrderByDescending(b => b.Batch).First();
            return lastBatch.Year;
        }
    }
}

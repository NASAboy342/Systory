using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
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

        public List<FacultyModel> GetListOfFaculty()
        {
            var listOfFaculty = new List<FacultyModel>();
            var connectionString = _connection.GetConnectionString();
            var commandString = "SELECT * from dbo.Faculty";
            
            using var connection = new SqlConnection(connectionString);
            connection.Open();
            using var command = new SqlCommand(commandString, connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var faculty = new FacultyModel()
                {
                    FacultyId = (int)reader["FacultyId"],
                    FacultyName = (string)reader["FacultyName"]
                };
                listOfFaculty.Add(faculty);
            }
            return listOfFaculty;
        }
        public List<string> GetListOfFacultyName()
        {
            var listFaculty = new List<string>();
            var connectionString = _connection.GetConnectionString();
            var commandString = "SELECT [FacultyName] from dbo.Faculty";

            using var connection = new SqlConnection(connectionString);
            connection.Open();
            using var command = new SqlCommand(commandString, connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                listFaculty.Add(reader["FacultyName"].ToString());
            }
            return listFaculty;
        }
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
                    FacultyId = (int)reader["FacultyId"],
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

        public ErrorStatusModel InsertNewMajorToBatch(MajorRequest majorRequest)
        {
            try
            {
                var listOfMajor = new List<MajorRequest>()
                {
                    majorRequest
                };
                var connectionString = _connection.GetConnectionString();
                var spName = StoredProcedureInsertNewMajor.SpName;
                var paraName = StoredProcedureInsertNewMajor.ParaName;
                var dataTable = _dataTableManagement.ConvertListOfObjectsToDataTable(listOfMajor);

                using var connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand(spName, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue(paraName, dataTable);
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
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Systory.Models;


namespace Systory.Services
{
    internal class Connection
    {
        public bool CheckConnection()
        {
            try
            {
                var connectionString = GetConnectionString();
                using var connection = new SqlConnection(connectionString);
                connection.Open();
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string GetConnectionString()
        {
            ServerInfo serverInfo = GetServerInfoObject();

            return AssambleServerInfoToConnectionString(serverInfo);
        }

        private string AssambleServerInfoToConnectionString( ServerInfo serverInfo)
        {
            return $"Data Source={serverInfo.ServerName};Initial Catalog={serverInfo.DataBaseName};User Id={serverInfo.UserId};Password={serverInfo.Password};";
        }

        private List<string> GetServerInfoFromFile( string path)
        {
            return new List<string>(File.ReadAllLines(path));
        }

        public void UpdateServerInfo( ServerInfo serverInfo)
        {
            var path = DbInfoPath.Path;
            var infoList = new List<string>();
            infoList.Add(serverInfo.ServerName);
            infoList.Add(serverInfo.DataBaseName);
            infoList.Add(serverInfo.UserId); 
            infoList.Add(serverInfo.Password);
            File.WriteAllLines(path, infoList);
        }

        public ServerInfo GetServerInfoObject()
        {
            var filePath = DbInfoPath.Path;
            var ServerInfoList = GetServerInfoFromFile(filePath);
            return new ServerInfo()
            {
                ServerName = ServerInfoList[0],
                DataBaseName = ServerInfoList[1],
                UserId = ServerInfoList[2],
                Password = ServerInfoList[3]
            };
        }
    }
}

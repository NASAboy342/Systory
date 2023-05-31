using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systory.Models
{
    class ServerInfo
    {
        public string ServerName { get; set; }
        public string DataBaseName { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
    }

    class DbInfoPath
    {
        public static string Path => "DbInfo.config";
    }

    class StoredProcedureInsertNewBatch
    {
        public static string SpName => "dbo.InsertNewBatch";
        public static string ParaName => "@newBatch";
    }
}

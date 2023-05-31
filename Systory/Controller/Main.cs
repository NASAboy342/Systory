using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Systory.Services;

namespace Systory.Controller
{
    internal class Main
    {
        Connection _connection = new Connection();
        public bool CheckConnection()
        {
            return _connection.CheckConnection();
        }
    }
}

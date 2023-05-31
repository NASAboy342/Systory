using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Systory.Models;
using Systory.Services;

namespace Systory
{
    public partial class Database_Connection : Form
    {
        Connection _connection = new Connection();
        public Database_Connection()
        {
            InitializeComponent();
        }

        private void Bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Database_Connection_Load(object sender, EventArgs e)
        {
            var serverInfo = _connection.GetServerInfoObject();
            Tb_ServerName.Text = serverInfo.ServerName;
            Tb_Username.Text = serverInfo.UserId;
            Tb_Password.Text = serverInfo.Password;
            Tb_databaseName.Text = serverInfo.DataBaseName;
        }

        private void Bt_Connect_Click(object sender, EventArgs e)
        {
            var serverInfo = new ServerInfo()
            {
                ServerName = Tb_ServerName.Text,
                DataBaseName = Tb_databaseName.Text,
                UserId = Tb_Username.Text,
                Password = Tb_Password.Text,
            };
            _connection.UpdateServerInfo(serverInfo);
            this.Close();
        }
    }
}

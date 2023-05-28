using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Systory
{
    public partial class NewBatch : Form
    {
        public NewBatch()
        {
            InitializeComponent();
        }

        private void Bt_create_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

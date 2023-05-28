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
    public partial class Batch : Form
    {
        public Batch()
        {
            InitializeComponent();
        }

        private void Bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bt_NewBatch_Click(object sender, EventArgs e)
        {
            var newBatch = new NewBatch();
            newBatch.TopLevel = false;
            Pn_info.Controls.Add(newBatch);
            newBatch.Show();
            newBatch.BringToFront();
        }
    }
}

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
    public partial class Major : Form
    {
        private readonly string _selectedMajor;
        public Major(string selectedMajor)
        {
            InitializeComponent();
            _selectedMajor = selectedMajor;
        }

        private void Major_Load(object sender, EventArgs e)
        {

        }
    }
}

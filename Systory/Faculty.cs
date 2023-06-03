using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Systory.Controller;

namespace Systory
{
    public partial class Faculty : Form
    {
        FacultyController _facultyController = new FacultyController();
        public Faculty()
        {
            InitializeComponent();
        }

        private void Bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadForm()
        {
            loadFacultyDataGrid();
        }
        private void loadFacultyDataGrid()
        {
            BindingSource _bindingSource = new BindingSource();
            _bindingSource.DataSource = _facultyController.GetFacultyLish();
            FacultyDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FacultyDataGrid.DataSource = _bindingSource;
        }

        private void Faculty_Load(object sender, EventArgs e)
        {
            loadForm();
        }
    }
}

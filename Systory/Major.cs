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
using Systory.Helpers;
using Systory.Managers;
using Systory.Repository;

namespace Systory
{
    public partial class Major : Form
    {
        private readonly string _selectedMajor;
        private string _selectedYear;
        private readonly MajorController _majorController;
        private readonly FormLoadHelper _formLoadHelper;
        private readonly DataSourceHelper _dataSourceHelper;
        public Major(string selectedMajor)
        {
            InitializeComponent();
            _selectedMajor = selectedMajor;
            _majorController = new MajorController();
            _formLoadHelper = new FormLoadHelper();
            _dataSourceHelper = new DataSourceHelper();
        }

        private void Major_Load(object sender, EventArgs e)
        {
            loadform();
        }

        private void loadform()
        {
            Bt_addSubject.Enabled = false;
            Lb_Major.Text = _selectedMajor;
            BindingSource _bindingSource = new BindingSource();
            _bindingSource.DataSource = _majorController.GetYearList();
            YearDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            YearDataGrid.DataSource = _bindingSource;
        }

        private void Bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bt_refresh_Click(object sender, EventArgs e)
        {
            loadform();
        }

        private void YearDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                DataGridViewCell cell = YearDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                loadSubjectDataGrid(cell.Value.ToString(), _selectedMajor);
                _selectedYear = cell.Value.ToString();
                Bt_addSubject.Enabled = true;
            }
        }

        private void loadSubjectDataGrid(string year, string major)
        {
            _dataSourceHelper.SetDataSocurceToDataGrid(SubjectDataGrid,_majorController.GetSubjectList(year, major));
        }

        private void Bt_addMajor_Click(object sender, EventArgs e)
        {
            NewSubject newSubject = new NewSubject(_selectedMajor, Convert.ToInt32(_selectedYear));
            _formLoadHelper.LoadSubformInForm(this, newSubject);
        }
    }
}

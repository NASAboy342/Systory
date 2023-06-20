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
using Systory.Repository;

namespace Systory
{
    public partial class Batch : Form
    {

        BatchController _batchController = new BatchController();
        string _selectedBatch = string.Empty;
        string _selectedMajor = string.Empty;
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

        private void Batch_Load(object sender, EventArgs e)
        {
            loadBatchDataGrid();
            Bt_addMajor.Enabled = false;
        }

        private void loadBatchDataGrid()
        {
            BindingSource _bindingSource = new BindingSource();
            _bindingSource.DataSource = _batchController.GetBatchLish();
            BatchDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BatchDataGrid.DataSource = _bindingSource;
        }

        private void BatchDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                DataGridViewCell cell = BatchDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                loadMajorDataGrid(cell.Value.ToString());
                _selectedBatch = cell.Value.ToString();
                Bt_addMajor.Enabled = true;
            }
        }

        private void loadMajorDataGrid(string cell)
        {
            BindingSource _bindingSource = new BindingSource();
            _bindingSource.DataSource = _batchController.GetMajorList(Convert.ToInt32(cell));
            MajorDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MajorDataGrid.DataSource = _bindingSource;
        }

        private void Bt_refresh_Click(object sender, EventArgs e)
        {
            loadBatchDataGrid();
        }

        private void Bt_addMajor_Click(object sender, EventArgs e)
        {
            if (!_selectedBatch.Equals(string.Empty))
            {
                var newMajor = new NewMajor(_selectedBatch);
                newMajor.TopLevel = false;
                Pn_info.Controls.Add(newMajor);
                newMajor.Show();
                newMajor.BringToFront();
            }
        }

        private void MajorDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                DataGridViewCell cell = MajorDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                loadSubject(cell.Value.ToString());
                _selectedMajor = cell.Value.ToString();
            }
        }

        private void loadSubject(string Major)
        {
            Major major = new Major(Major);
            major.TopLevel = false;
            this.Controls.Add(major);
            major.Show();
            major.BringToFront();
        }
    }
}

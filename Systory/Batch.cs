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
    }
}

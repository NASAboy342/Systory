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
using Systory.Repository;
using Systory.Services;

namespace Systory
{
    public partial class NewBatch : Form
    {
        DbDataRepo _dbDataRepo = new DbDataRepo();
        public NewBatch()
        {
            InitializeComponent();
        }

        private void Bt_create_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(Convert.ToInt32(Tb_year.Text) <= _dbDataRepo.GetNewYear()))
                {
                    var batch = new BatchModel()
                    {
                        Batch = Convert.ToInt32(Lb_batch.Text.Trim()),
                        Year = Convert.ToInt32(Tb_year.Text.Trim())
                    };
                    var status = _dbDataRepo.InsertNewBatch(batch);
                    if (status.Equals(ErrorCode.Error))
                    {
                        MessageBox.Show("Create Error. Try again");
                    }
                    else
                    {
                        MessageBox.Show("Create success");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Create Error. Try again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Create Error. Try again");
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewBatch_Load(object sender, EventArgs e)
        {
            loadForm();
        }
        private void loadForm()
        {
            Lb_batch.Text = Convert.ToString(_dbDataRepo.GetNewBatch() + 1);
            Tb_year.Text = Convert.ToString(_dbDataRepo.GetNewYear() + 1);
        }
    }
}

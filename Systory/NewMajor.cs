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

namespace Systory
{
    public partial class NewMajor : Form
    {
        private readonly string _batch;
        DbDataRepo _dbDataRepo = new DbDataRepo();
        public NewMajor(string batch)
        {
            InitializeComponent();
            _batch = batch;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NewMajor_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        private void loadForm()
        {
            Lb_batch.Text = _batch;
            var listOfFaculty = _dbDataRepo.GetListOfFacultyName();
            Cb_faculty.DataSource = listOfFaculty;
        }

        private void Bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bt_create_Click(object sender, EventArgs e)
        {
            if (!Tb_major.Text.Equals(""))
            {
                var newMajor = new MajorRequest()
                {
                    MajorName = Tb_major.Text,
                    FacultyId = Cb_faculty.SelectedIndex + 1,
                    Batch = Convert.ToInt32(_batch)
                };

                var result = _dbDataRepo.InsertNewMajorToBatch(newMajor);

                if (result.ErrorCode.Equals(ErrorCode.Success))
                {
                    MessageBox.Show("Success");
                    this.Close();
                }
                else
                    MessageBox.Show("Error, Please try again");
            }
        }
    }
}

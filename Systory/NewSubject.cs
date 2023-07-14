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
    public partial class NewSubject : Form
    {
        private readonly string _major;
        private readonly int _year;
        private static DbDataRepo _dbDataRepo = new DbDataRepo();
        public NewSubject(string major, int year)
        {
            InitializeComponent();
            _major = major;
            _year = year;
        }

        private void Bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bt_create_Click(object sender, EventArgs e)
        {
            var major = _major;
            var year = _year.ToString();
            var newSubject = Tb_Subject.Text;
            var TeacherName = Tb_teacherName.Text;
            var result = _dbDataRepo.InsertNewSubject(major, year, newSubject, TeacherName);
            if (result.ErrorCode == ErrorCode.Error)
                MessageBox.Show("Update Error!\nPlease TRY_CAST again");
            else
            {
                MessageBox.Show("Update Success");
                this.Close();
            }
        }

        private void NewSubject_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        private void loadForm()
        {
            Lb_Major.Text = _major;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Systory.Enums;
using Systory.Helpers;
using Systory.Models;
using Systory.Services;

namespace Systory
{
    public partial class Shift : Form
    {
        private readonly SubjectResponse _subject;
        private readonly SubjectService _subjectService = new SubjectService();
        private readonly DataSourceHelper _dataSourceHelper = new DataSourceHelper();
        public Shift(SubjectResponse subjectModel)
        {
            InitializeComponent();
            _subject = subjectModel;
        }

        private void Bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bt_refresh_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void LoadForm()
        {
            Lb_teacherName.Text = _subject.TeacherName;
            lb_subjectName.Text = _subject.SubjectName;
        }

        private void Shift_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadStudentDataGrid(EnumShift.Morning);
        }

        private void LoadStudentDataGrid(EnumShift shift)
        {
            var studentList = _subjectService.GetStudentListBySubject(_subject, shift);
                _dataSourceHelper.SetDataSocurceToDataGrid(StudentListGrid, studentList);
        }

        private void Bt_afternon_Click(object sender, EventArgs e)
        {
            LoadStudentDataGrid(EnumShift.Afternoon);
        }

        private void Bt_evening_Click(object sender, EventArgs e)
        {
            LoadStudentDataGrid(EnumShift.Evening);
        }

        private void Bt_weeken_Click(object sender, EventArgs e)
        {
            LoadStudentDataGrid(EnumShift.Weekend);
        }

        private void StudentListGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

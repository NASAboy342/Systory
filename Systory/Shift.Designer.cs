namespace Systory
{
    partial class Shift
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Bt_refresh=new Button();
            Bt_Close=new Button();
            Bt_morning=new Button();
            Bt_afternon=new Button();
            Bt_evening=new Button();
            Bt_weeken=new Button();
            StudentListGrid=new DataGridView();
            label1=new Label();
            Lb_teacherName=new Label();
            lb_subjectName=new Label();
            label3=new Label();
            ((System.ComponentModel.ISupportInitialize)StudentListGrid).BeginInit();
            SuspendLayout();
            // 
            // Bt_refresh
            // 
            Bt_refresh.Location=new Point(1119, 10);
            Bt_refresh.Name="Bt_refresh";
            Bt_refresh.Size=new Size(75, 23);
            Bt_refresh.TabIndex=11;
            Bt_refresh.Text="Refresh";
            Bt_refresh.UseVisualStyleBackColor=true;
            Bt_refresh.Click+=Bt_refresh_Click;
            // 
            // Bt_Close
            // 
            Bt_Close.Location=new Point(10, 10);
            Bt_Close.Name="Bt_Close";
            Bt_Close.Size=new Size(75, 23);
            Bt_Close.TabIndex=10;
            Bt_Close.Text="Close";
            Bt_Close.UseVisualStyleBackColor=true;
            Bt_Close.Click+=Bt_Close_Click;
            // 
            // Bt_morning
            // 
            Bt_morning.Location=new Point(10, 70);
            Bt_morning.Margin=new Padding(3, 2, 3, 2);
            Bt_morning.Name="Bt_morning";
            Bt_morning.Size=new Size(155, 27);
            Bt_morning.TabIndex=12;
            Bt_morning.Text="Morning";
            Bt_morning.UseVisualStyleBackColor=true;
            Bt_morning.Click+=button1_Click;
            // 
            // Bt_afternon
            // 
            Bt_afternon.Location=new Point(10, 116);
            Bt_afternon.Margin=new Padding(3, 2, 3, 2);
            Bt_afternon.Name="Bt_afternon";
            Bt_afternon.Size=new Size(155, 27);
            Bt_afternon.TabIndex=13;
            Bt_afternon.Text="Afternoon";
            Bt_afternon.UseVisualStyleBackColor=true;
            Bt_afternon.Click+=Bt_afternon_Click;
            // 
            // Bt_evening
            // 
            Bt_evening.Location=new Point(10, 161);
            Bt_evening.Margin=new Padding(3, 2, 3, 2);
            Bt_evening.Name="Bt_evening";
            Bt_evening.Size=new Size(155, 27);
            Bt_evening.TabIndex=14;
            Bt_evening.Text="Evening";
            Bt_evening.UseVisualStyleBackColor=true;
            Bt_evening.Click+=Bt_evening_Click;
            // 
            // Bt_weeken
            // 
            Bt_weeken.Location=new Point(10, 206);
            Bt_weeken.Margin=new Padding(3, 2, 3, 2);
            Bt_weeken.Name="Bt_weeken";
            Bt_weeken.Size=new Size(155, 27);
            Bt_weeken.TabIndex=15;
            Bt_weeken.Text="Weeken";
            Bt_weeken.UseVisualStyleBackColor=true;
            Bt_weeken.Click+=Bt_weeken_Click;
            // 
            // StudentListGrid
            // 
            StudentListGrid.BackgroundColor=Color.Teal;
            StudentListGrid.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentListGrid.Location=new Point(189, 116);
            StudentListGrid.Margin=new Padding(3, 2, 3, 2);
            StudentListGrid.Name="StudentListGrid";
            StudentListGrid.RowHeadersWidth=51;
            StudentListGrid.RowTemplate.Height=29;
            StudentListGrid.Size=new Size(1005, 401);
            StudentListGrid.TabIndex=16;
            StudentListGrid.CellContentClick+=StudentListGrid_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor=Color.White;
            label1.Location=new Point(189, 52);
            label1.Name="label1";
            label1.Size=new Size(64, 19);
            label1.TabIndex=17;
            label1.Text="Teacher:";
            // 
            // Lb_teacherName
            // 
            Lb_teacherName.AutoSize=true;
            Lb_teacherName.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lb_teacherName.ForeColor=Color.White;
            Lb_teacherName.Location=new Point(263, 52);
            Lb_teacherName.Name="Lb_teacherName";
            Lb_teacherName.Size=new Size(98, 19);
            Lb_teacherName.TabIndex=18;
            Lb_teacherName.Text="TeacherName";
            Lb_teacherName.Click+=label2_Click;
            // 
            // lb_subjectName
            // 
            lb_subjectName.AutoSize=true;
            lb_subjectName.Font=new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_subjectName.ForeColor=Color.White;
            lb_subjectName.Location=new Point(263, 70);
            lb_subjectName.Name="lb_subjectName";
            lb_subjectName.Size=new Size(91, 18);
            lb_subjectName.TabIndex=20;
            lb_subjectName.Text="SubjectName";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor=Color.White;
            label3.Location=new Point(189, 70);
            label3.Name="label3";
            label3.Size=new Size(58, 18);
            label3.TabIndex=19;
            label3.Text="Subject:";
            // 
            // Shift
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(0, 192, 192);
            ClientSize=new Size(1205, 526);
            Controls.Add(lb_subjectName);
            Controls.Add(label3);
            Controls.Add(Lb_teacherName);
            Controls.Add(label1);
            Controls.Add(StudentListGrid);
            Controls.Add(Bt_weeken);
            Controls.Add(Bt_evening);
            Controls.Add(Bt_afternon);
            Controls.Add(Bt_morning);
            Controls.Add(Bt_refresh);
            Controls.Add(Bt_Close);
            FormBorderStyle=FormBorderStyle.None;
            Margin=new Padding(3, 2, 3, 2);
            Name="Shift";
            Text="Shift";
            Load+=Shift_Load;
            ((System.ComponentModel.ISupportInitialize)StudentListGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Bt_refresh;
        private Button Bt_Close;
        private Button Bt_morning;
        private Button Bt_afternon;
        private Button Bt_evening;
        private Button Bt_weeken;
        private DataGridView StudentListGrid;
        private Label label1;
        private Label Lb_teacherName;
        private Label lb_subjectName;
        private Label label3;
    }
}
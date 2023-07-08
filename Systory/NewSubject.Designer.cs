namespace Systory
{
    partial class NewSubject
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
            panel2 = new Panel();
            panel1 = new Panel();
            Tb_teacherName = new TextBox();
            label1 = new Label();
            Tb_Subject = new TextBox();
            Bt_cancel = new Button();
            Bt_create = new Button();
            label2 = new Label();
            label3 = new Label();
            Lb_Major = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Location = new Point(393, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(645, 10);
            panel2.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(Tb_teacherName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Tb_Subject);
            panel1.Controls.Add(Bt_cancel);
            panel1.Controls.Add(Bt_create);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(393, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(645, 217);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // Tb_teacherName
            // 
            Tb_teacherName.Location = new Point(163, 115);
            Tb_teacherName.Name = "Tb_teacherName";
            Tb_teacherName.Size = new Size(449, 27);
            Tb_teacherName.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 115);
            label1.Name = "label1";
            label1.Size = new Size(151, 28);
            label1.TabIndex = 7;
            label1.Text = "Teacher name:";
            // 
            // Tb_Subject
            // 
            Tb_Subject.Location = new Point(163, 65);
            Tb_Subject.Name = "Tb_Subject";
            Tb_Subject.Size = new Size(449, 27);
            Tb_Subject.TabIndex = 4;
            // 
            // Bt_cancel
            // 
            Bt_cancel.Location = new Point(418, 174);
            Bt_cancel.Name = "Bt_cancel";
            Bt_cancel.Size = new Size(94, 29);
            Bt_cancel.TabIndex = 6;
            Bt_cancel.Text = "Cancel";
            Bt_cancel.UseVisualStyleBackColor = true;
            Bt_cancel.Click += Bt_cancel_Click;
            // 
            // Bt_create
            // 
            Bt_create.Location = new Point(518, 174);
            Bt_create.Name = "Bt_create";
            Bt_create.Size = new Size(94, 29);
            Bt_create.TabIndex = 0;
            Bt_create.Text = "Create";
            Bt_create.UseVisualStyleBackColor = true;
            Bt_create.Click += Bt_create_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(16, 65);
            label2.Name = "label2";
            label2.Size = new Size(148, 28);
            label2.TabIndex = 3;
            label2.Text = "Subject name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(390, 64);
            label3.Name = "label3";
            label3.Size = new Size(265, 28);
            label3.TabIndex = 12;
            label3.Text = "Add new Subject to Major:";
            // 
            // Lb_Major
            // 
            Lb_Major.AutoSize = true;
            Lb_Major.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Lb_Major.ForeColor = Color.White;
            Lb_Major.Location = new Point(660, 65);
            Lb_Major.Name = "Lb_Major";
            Lb_Major.Size = new Size(36, 28);
            Lb_Major.TabIndex = 11;
            Lb_Major.Text = "00";
            // 
            // NewSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(1377, 701);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(Lb_Major);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewSubject";
            Text = "NewSubject";
            Load += NewSubject_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private TextBox Tb_Subject;
        private Button Bt_cancel;
        private Button Bt_create;
        private Label label2;
        private Label label3;
        private Label Lb_Major;
        private TextBox Tb_teacherName;
        private Label label1;
    }
}
namespace Systory
{
    partial class NewMajor
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
            panel1 = new Panel();
            Tb_major = new TextBox();
            Bt_cancel = new Button();
            Bt_create = new Button();
            label2 = new Label();
            Lb_batch = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            Cb_faculty = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(Cb_faculty);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Tb_major);
            panel1.Controls.Add(Bt_cancel);
            panel1.Controls.Add(Bt_create);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(30, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(615, 217);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // Tb_major
            // 
            Tb_major.Location = new Point(163, 95);
            Tb_major.Name = "Tb_major";
            Tb_major.Size = new Size(414, 27);
            Tb_major.TabIndex = 4;
            // 
            // Bt_cancel
            // 
            Bt_cancel.Location = new Point(383, 174);
            Bt_cancel.Name = "Bt_cancel";
            Bt_cancel.Size = new Size(94, 29);
            Bt_cancel.TabIndex = 6;
            Bt_cancel.Text = "Cancel";
            Bt_cancel.UseVisualStyleBackColor = true;
            Bt_cancel.Click += Bt_cancel_Click;
            // 
            // Bt_create
            // 
            Bt_create.Location = new Point(483, 174);
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
            label2.Location = new Point(18, 95);
            label2.Name = "label2";
            label2.Size = new Size(134, 28);
            label2.TabIndex = 3;
            label2.Text = "Major name:";
            label2.Click += label2_Click;
            // 
            // Lb_batch
            // 
            Lb_batch.AutoSize = true;
            Lb_batch.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            Lb_batch.ForeColor = Color.White;
            Lb_batch.Location = new Point(479, 43);
            Lb_batch.Name = "Lb_batch";
            Lb_batch.Size = new Size(52, 41);
            Lb_batch.TabIndex = 2;
            Lb_batch.Text = "00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(168, 45);
            label3.Name = "label3";
            label3.Size = new Size(305, 35);
            label3.TabIndex = 8;
            label3.Text = "Add new Major to batch:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Location = new Point(30, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(615, 10);
            panel2.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 32);
            label1.Name = "label1";
            label1.Size = new Size(110, 28);
            label1.TabIndex = 7;
            label1.Text = "Faculty of:";
            // 
            // Cb_faculty
            // 
            Cb_faculty.FormattingEnabled = true;
            Cb_faculty.Location = new Point(163, 35);
            Cb_faculty.Name = "Cb_faculty";
            Cb_faculty.Size = new Size(414, 28);
            Cb_faculty.TabIndex = 8;
            // 
            // NewMajor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(679, 602);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(Lb_batch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewMajor";
            Text = "NewMajor";
            Load += NewMajor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox Tb_major;
        private Button Bt_cancel;
        private Button Bt_create;
        private Label Lb_batch;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private ComboBox Cb_faculty;
        private Label label1;
    }
}
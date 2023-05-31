namespace Systory
{
    partial class NewBatch
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
            Bt_create = new Button();
            label1 = new Label();
            Lb_batch = new Label();
            label2 = new Label();
            Tb_year = new TextBox();
            label3 = new Label();
            Bt_cancel = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Bt_create
            // 
            Bt_create.Location = new Point(375, 168);
            Bt_create.Name = "Bt_create";
            Bt_create.Size = new Size(94, 29);
            Bt_create.TabIndex = 0;
            Bt_create.Text = "Create";
            Bt_create.UseVisualStyleBackColor = true;
            Bt_create.Click += Bt_create_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(44, 37);
            label1.Name = "label1";
            label1.Size = new Size(72, 28);
            label1.TabIndex = 1;
            label1.Text = "Batch:";
            label1.Click += label1_Click;
            // 
            // Lb_batch
            // 
            Lb_batch.AutoSize = true;
            Lb_batch.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Lb_batch.ForeColor = Color.White;
            Lb_batch.Location = new Point(146, 37);
            Lb_batch.Name = "Lb_batch";
            Lb_batch.Size = new Size(36, 28);
            Lb_batch.TabIndex = 2;
            Lb_batch.Text = "00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(44, 97);
            label2.Name = "label2";
            label2.Size = new Size(59, 28);
            label2.TabIndex = 3;
            label2.Text = "Year:";
            // 
            // Tb_year
            // 
            Tb_year.Location = new Point(146, 100);
            Tb_year.Name = "Tb_year";
            Tb_year.Size = new Size(203, 27);
            Tb_year.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(220, 36);
            label3.Name = "label3";
            label3.Size = new Size(221, 35);
            label3.TabIndex = 5;
            label3.Text = "Create new Batch";
            // 
            // Bt_cancel
            // 
            Bt_cancel.Location = new Point(275, 168);
            Bt_cancel.Name = "Bt_cancel";
            Bt_cancel.Size = new Size(94, 29);
            Bt_cancel.TabIndex = 6;
            Bt_cancel.Text = "Cancel";
            Bt_cancel.UseVisualStyleBackColor = true;
            Bt_cancel.Click += Bt_cancel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(Tb_year);
            panel1.Controls.Add(Bt_cancel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Bt_create);
            panel1.Controls.Add(Lb_batch);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(84, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 214);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Location = new Point(13, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(654, 10);
            panel2.TabIndex = 8;
            // 
            // NewBatch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(679, 602);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewBatch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewBatch";
            Load += NewBatch_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Bt_create;
        private Label label1;
        private Label Lb_batch;
        private Label label2;
        private TextBox Tb_year;
        private Label label3;
        private Button Bt_cancel;
        private Panel panel1;
        private Panel panel2;
    }
}
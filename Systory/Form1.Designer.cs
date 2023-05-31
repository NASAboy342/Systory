namespace Systory
{
    partial class Systory
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Systory));
            Bt_Batch = new Button();
            Pn_Feature = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            Pn_Info = new Panel();
            Pn_Feature.SuspendLayout();
            SuspendLayout();
            // 
            // Bt_Batch
            // 
            Bt_Batch.BackColor = Color.DarkCyan;
            Bt_Batch.ForeColor = SystemColors.ButtonHighlight;
            Bt_Batch.Location = new Point(3, 4);
            Bt_Batch.Margin = new Padding(3, 4, 3, 4);
            Bt_Batch.Name = "Bt_Batch";
            Bt_Batch.Size = new Size(163, 41);
            Bt_Batch.TabIndex = 0;
            Bt_Batch.Text = "Batch";
            Bt_Batch.UseVisualStyleBackColor = false;
            Bt_Batch.Click += Bt_Batch_Click;
            // 
            // Pn_Feature
            // 
            Pn_Feature.BackColor = Color.Azure;
            Pn_Feature.Controls.Add(button6);
            Pn_Feature.Controls.Add(button5);
            Pn_Feature.Controls.Add(button4);
            Pn_Feature.Controls.Add(button3);
            Pn_Feature.Controls.Add(button2);
            Pn_Feature.Controls.Add(Bt_Batch);
            Pn_Feature.Location = new Point(14, 83);
            Pn_Feature.Margin = new Padding(3, 4, 3, 4);
            Pn_Feature.Name = "Pn_Feature";
            Pn_Feature.Size = new Size(173, 701);
            Pn_Feature.TabIndex = 7;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkCyan;
            button6.Enabled = false;
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(3, 251);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(163, 41);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkCyan;
            button5.Enabled = false;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(3, 201);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(163, 41);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkCyan;
            button4.Enabled = false;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(3, 152);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(163, 41);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkCyan;
            button3.Enabled = false;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(3, 103);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(163, 41);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkCyan;
            button2.Enabled = false;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(3, 53);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(163, 41);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(91, 41);
            label1.TabIndex = 8;
            label1.Text = "Main";
            // 
            // Pn_Info
            // 
            Pn_Info.BackColor = Color.Azure;
            Pn_Info.Location = new Point(193, 83);
            Pn_Info.Margin = new Padding(3, 4, 3, 4);
            Pn_Info.Name = "Pn_Info";
            Pn_Info.Size = new Size(706, 701);
            Pn_Info.TabIndex = 9;
            // 
            // Systory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Teal;
            ClientSize = new Size(914, 800);
            Controls.Add(Pn_Info);
            Controls.Add(label1);
            Controls.Add(Pn_Feature);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Systory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Systory";
            Load += Systory_Load;
            Pn_Feature.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Bt_Batch;
        private Panel Pn_Feature;
        private Button button2;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Label label1;
        private Panel Pn_Info;
    }
}
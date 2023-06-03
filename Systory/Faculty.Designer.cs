namespace Systory
{
    partial class Faculty
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
            Bt_refresh = new Button();
            Bt_Close = new Button();
            panel1 = new Panel();
            FacultyDataGrid = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FacultyDataGrid).BeginInit();
            SuspendLayout();
            // 
            // Bt_refresh
            // 
            Bt_refresh.Location = new Point(602, 13);
            Bt_refresh.Margin = new Padding(3, 4, 3, 4);
            Bt_refresh.Name = "Bt_refresh";
            Bt_refresh.Size = new Size(86, 31);
            Bt_refresh.TabIndex = 9;
            Bt_refresh.Text = "Refresh";
            Bt_refresh.UseVisualStyleBackColor = true;
            // 
            // Bt_Close
            // 
            Bt_Close.Location = new Point(12, 13);
            Bt_Close.Margin = new Padding(3, 4, 3, 4);
            Bt_Close.Name = "Bt_Close";
            Bt_Close.Size = new Size(86, 31);
            Bt_Close.TabIndex = 8;
            Bt_Close.Text = "Close";
            Bt_Close.UseVisualStyleBackColor = true;
            Bt_Close.Click += Bt_Close_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 64);
            panel1.Controls.Add(FacultyDataGrid);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 582);
            panel1.TabIndex = 10;
            // 
            // FacultyDataGrid
            // 
            FacultyDataGrid.BackgroundColor = Color.Teal;
            FacultyDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FacultyDataGrid.Location = new Point(3, 34);
            FacultyDataGrid.Name = "FacultyDataGrid";
            FacultyDataGrid.RowHeadersWidth = 51;
            FacultyDataGrid.RowTemplate.Height = 29;
            FacultyDataGrid.Size = new Size(676, 545);
            FacultyDataGrid.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 64, 64);
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 2);
            label1.Name = "label1";
            label1.Size = new Size(83, 29);
            label1.TabIndex = 11;
            label1.Text = "Faculty";
            // 
            // Faculty
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(706, 701);
            Controls.Add(panel1);
            Controls.Add(Bt_refresh);
            Controls.Add(Bt_Close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Faculty";
            Text = "Faculty";
            Load += Faculty_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FacultyDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Bt_refresh;
        private Button Bt_Close;
        private Panel panel1;
        private DataGridView FacultyDataGrid;
        private Label label1;
    }
}
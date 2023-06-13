namespace Systory
{
    partial class Major
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
            Pn_info = new Panel();
            Bt_addMajor = new Button();
            BatchDataGrid = new DataGridView();
            MajorDataGrid = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            Pn_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BatchDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MajorDataGrid).BeginInit();
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
            // 
            // Pn_info
            // 
            Pn_info.BackColor = Color.FromArgb(0, 64, 64);
            Pn_info.Controls.Add(Bt_addMajor);
            Pn_info.Controls.Add(BatchDataGrid);
            Pn_info.Controls.Add(MajorDataGrid);
            Pn_info.Controls.Add(label2);
            Pn_info.Controls.Add(label1);
            Pn_info.Location = new Point(12, 87);
            Pn_info.Name = "Pn_info";
            Pn_info.Size = new Size(679, 602);
            Pn_info.TabIndex = 10;
            // 
            // Bt_addMajor
            // 
            Bt_addMajor.Location = new Point(552, 8);
            Bt_addMajor.Name = "Bt_addMajor";
            Bt_addMajor.Size = new Size(124, 29);
            Bt_addMajor.TabIndex = 7;
            Bt_addMajor.Text = "Add Subject";
            Bt_addMajor.UseVisualStyleBackColor = true;
            // 
            // BatchDataGrid
            // 
            BatchDataGrid.BackgroundColor = Color.Teal;
            BatchDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BatchDataGrid.Location = new Point(3, 46);
            BatchDataGrid.Margin = new Padding(3, 4, 3, 4);
            BatchDataGrid.Name = "BatchDataGrid";
            BatchDataGrid.RowHeadersWidth = 51;
            BatchDataGrid.RowTemplate.Height = 25;
            BatchDataGrid.Size = new Size(224, 552);
            BatchDataGrid.TabIndex = 1;
            // 
            // MajorDataGrid
            // 
            MajorDataGrid.BackgroundColor = Color.Teal;
            MajorDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MajorDataGrid.Location = new Point(233, 46);
            MajorDataGrid.Margin = new Padding(3, 4, 3, 4);
            MajorDataGrid.Name = "MajorDataGrid";
            MajorDataGrid.RowHeadersWidth = 51;
            MajorDataGrid.RowTemplate.Height = 25;
            MajorDataGrid.Size = new Size(443, 552);
            MajorDataGrid.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 64, 64);
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(241, 8);
            label2.Name = "label2";
            label2.Size = new Size(96, 29);
            label2.TabIndex = 4;
            label2.Text = "Subjects";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 64, 64);
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(56, 29);
            label1.TabIndex = 3;
            label1.Text = "Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 192, 192);
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 55);
            label3.Name = "label3";
            label3.Size = new Size(74, 29);
            label3.TabIndex = 11;
            label3.Text = "Major";
            // 
            // Major
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(706, 701);
            Controls.Add(label3);
            Controls.Add(Pn_info);
            Controls.Add(Bt_refresh);
            Controls.Add(Bt_Close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Major";
            Text = "Major";
            Load += Major_Load;
            Pn_info.ResumeLayout(false);
            Pn_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BatchDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)MajorDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Bt_refresh;
        private Button Bt_Close;
        private Panel Pn_info;
        private Button Bt_addMajor;
        private DataGridView BatchDataGrid;
        private DataGridView MajorDataGrid;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}
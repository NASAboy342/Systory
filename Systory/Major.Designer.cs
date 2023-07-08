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
            Bt_addSubject = new Button();
            YearDataGrid = new DataGridView();
            SubjectDataGrid = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            Lb_Major = new Label();
            Pn_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)YearDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SubjectDataGrid).BeginInit();
            SuspendLayout();
            // 
            // Bt_refresh
            // 
            Bt_refresh.Location = new Point(1279, 13);
            Bt_refresh.Margin = new Padding(3, 4, 3, 4);
            Bt_refresh.Name = "Bt_refresh";
            Bt_refresh.Size = new Size(86, 31);
            Bt_refresh.TabIndex = 9;
            Bt_refresh.Text = "Refresh";
            Bt_refresh.UseVisualStyleBackColor = true;
            Bt_refresh.Click += Bt_refresh_Click;
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
            // Pn_info
            // 
            Pn_info.BackColor = Color.FromArgb(0, 64, 64);
            Pn_info.Controls.Add(Bt_addSubject);
            Pn_info.Controls.Add(YearDataGrid);
            Pn_info.Controls.Add(SubjectDataGrid);
            Pn_info.Controls.Add(label2);
            Pn_info.Controls.Add(label1);
            Pn_info.Location = new Point(12, 87);
            Pn_info.Name = "Pn_info";
            Pn_info.Size = new Size(1353, 602);
            Pn_info.TabIndex = 10;
            // 
            // Bt_addSubject
            // 
            Bt_addSubject.Location = new Point(1216, 8);
            Bt_addSubject.Name = "Bt_addSubject";
            Bt_addSubject.Size = new Size(124, 29);
            Bt_addSubject.TabIndex = 7;
            Bt_addSubject.Text = "Add Subject";
            Bt_addSubject.UseVisualStyleBackColor = true;
            Bt_addSubject.Click += Bt_addMajor_Click;
            // 
            // YearDataGrid
            // 
            YearDataGrid.BackgroundColor = Color.Teal;
            YearDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            YearDataGrid.Location = new Point(3, 46);
            YearDataGrid.Margin = new Padding(3, 4, 3, 4);
            YearDataGrid.Name = "YearDataGrid";
            YearDataGrid.RowHeadersWidth = 51;
            YearDataGrid.RowTemplate.Height = 25;
            YearDataGrid.Size = new Size(224, 552);
            YearDataGrid.TabIndex = 1;
            YearDataGrid.CellContentClick += YearDataGrid_CellContentClick;
            // 
            // SubjectDataGrid
            // 
            SubjectDataGrid.BackgroundColor = Color.Teal;
            SubjectDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SubjectDataGrid.Location = new Point(233, 46);
            SubjectDataGrid.Margin = new Padding(3, 4, 3, 4);
            SubjectDataGrid.Name = "SubjectDataGrid";
            SubjectDataGrid.RowHeadersWidth = 51;
            SubjectDataGrid.RowTemplate.Height = 25;
            SubjectDataGrid.Size = new Size(1117, 552);
            SubjectDataGrid.TabIndex = 2;
            SubjectDataGrid.CellContentClick += SubjectDataGrid_CellContentClick;
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
            // Lb_Major
            // 
            Lb_Major.AutoSize = true;
            Lb_Major.BackColor = Color.FromArgb(0, 192, 192);
            Lb_Major.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Lb_Major.ForeColor = Color.White;
            Lb_Major.Location = new Point(12, 55);
            Lb_Major.Name = "Lb_Major";
            Lb_Major.Size = new Size(74, 29);
            Lb_Major.TabIndex = 11;
            Lb_Major.Text = "Major";
            // 
            // Major
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(1377, 701);
            Controls.Add(Lb_Major);
            Controls.Add(Pn_info);
            Controls.Add(Bt_refresh);
            Controls.Add(Bt_Close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Major";
            Text = "Major";
            Load += Major_Load;
            Pn_info.ResumeLayout(false);
            Pn_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)YearDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)SubjectDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Bt_refresh;
        private Button Bt_Close;
        private Panel Pn_info;
        private Button Bt_addSubject;
        private DataGridView YearDataGrid;
        private DataGridView SubjectDataGrid;
        private Label label2;
        private Label label1;
        private Label Lb_Major;
    }
}
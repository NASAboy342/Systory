namespace Systory
{
    partial class Batch
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
            Bt_Close = new Button();
            BatchDataGrid = new DataGridView();
            MajorDataGrid = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            Bt_NewBatch = new Button();
            Pn_info = new Panel();
            Bt_addMajor = new Button();
            Bt_refresh = new Button();
            ((System.ComponentModel.ISupportInitialize)BatchDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MajorDataGrid).BeginInit();
            Pn_info.SuspendLayout();
            SuspendLayout();
            // 
            // Bt_Close
            // 
            Bt_Close.Location = new Point(14, 16);
            Bt_Close.Margin = new Padding(3, 4, 3, 4);
            Bt_Close.Name = "Bt_Close";
            Bt_Close.Size = new Size(86, 31);
            Bt_Close.TabIndex = 0;
            Bt_Close.Text = "Close";
            Bt_Close.UseVisualStyleBackColor = true;
            Bt_Close.Click += Bt_Close_Click;
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
            BatchDataGrid.CellContentClick += BatchDataGrid_CellContentClick;
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
            MajorDataGrid.Size = new Size(1115, 552);
            MajorDataGrid.TabIndex = 2;
            MajorDataGrid.CellContentClick += MajorDataGrid_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 64, 64);
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(69, 29);
            label1.TabIndex = 3;
            label1.Text = "Batch";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 64, 64);
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(241, 8);
            label2.Name = "label2";
            label2.Size = new Size(74, 29);
            label2.TabIndex = 4;
            label2.Text = "Major";
            // 
            // Bt_NewBatch
            // 
            Bt_NewBatch.Location = new Point(133, 8);
            Bt_NewBatch.Margin = new Padding(3, 4, 3, 4);
            Bt_NewBatch.Name = "Bt_NewBatch";
            Bt_NewBatch.Size = new Size(94, 31);
            Bt_NewBatch.TabIndex = 5;
            Bt_NewBatch.Text = "New Batch";
            Bt_NewBatch.UseVisualStyleBackColor = true;
            Bt_NewBatch.Click += Bt_NewBatch_Click;
            // 
            // Pn_info
            // 
            Pn_info.BackColor = Color.FromArgb(0, 64, 64);
            Pn_info.Controls.Add(Bt_addMajor);
            Pn_info.Controls.Add(Bt_NewBatch);
            Pn_info.Controls.Add(BatchDataGrid);
            Pn_info.Controls.Add(MajorDataGrid);
            Pn_info.Controls.Add(label2);
            Pn_info.Controls.Add(label1);
            Pn_info.Location = new Point(14, 87);
            Pn_info.Name = "Pn_info";
            Pn_info.Size = new Size(1351, 602);
            Pn_info.TabIndex = 6;
            // 
            // Bt_addMajor
            // 
            Bt_addMajor.Location = new Point(1245, 8);
            Bt_addMajor.Name = "Bt_addMajor";
            Bt_addMajor.Size = new Size(94, 29);
            Bt_addMajor.TabIndex = 7;
            Bt_addMajor.Text = "Add Major";
            Bt_addMajor.UseVisualStyleBackColor = true;
            Bt_addMajor.Click += Bt_addMajor_Click;
            // 
            // Bt_refresh
            // 
            Bt_refresh.Location = new Point(106, 16);
            Bt_refresh.Margin = new Padding(3, 4, 3, 4);
            Bt_refresh.Name = "Bt_refresh";
            Bt_refresh.Size = new Size(86, 31);
            Bt_refresh.TabIndex = 7;
            Bt_refresh.Text = "Refresh";
            Bt_refresh.UseVisualStyleBackColor = true;
            Bt_refresh.Click += Bt_refresh_Click;
            // 
            // Batch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(1377, 701);
            Controls.Add(Bt_refresh);
            Controls.Add(Bt_Close);
            Controls.Add(Pn_info);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Batch";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Batch";
            Load += Batch_Load;
            ((System.ComponentModel.ISupportInitialize)BatchDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)MajorDataGrid).EndInit();
            Pn_info.ResumeLayout(false);
            Pn_info.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Bt_Close;
        private DataGridView BatchDataGrid;
        private DataGridView MajorDataGrid;
        private Label label1;
        private Label label2;
        private Button Bt_NewBatch;
        private Panel Pn_info;
        private Button Bt_addMajor;
        private Button Bt_refresh;
    }
}
namespace Systory
{
    partial class Database_Connection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Database_Connection));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Tb_ServerName = new TextBox();
            Tb_Username = new TextBox();
            Tb_Password = new TextBox();
            Bt_Connect = new Button();
            Bt_Cancel = new Button();
            label4 = new Label();
            Tb_databaseName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(56, 113);
            label1.Name = "label1";
            label1.Size = new Size(122, 24);
            label1.TabIndex = 0;
            label1.Text = "Server Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(56, 163);
            label2.Name = "label2";
            label2.Size = new Size(101, 24);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(56, 213);
            label3.Name = "label3";
            label3.Size = new Size(97, 24);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // Tb_ServerName
            // 
            Tb_ServerName.Location = new Point(248, 113);
            Tb_ServerName.Margin = new Padding(3, 4, 3, 4);
            Tb_ServerName.Name = "Tb_ServerName";
            Tb_ServerName.Size = new Size(343, 27);
            Tb_ServerName.TabIndex = 3;
            // 
            // Tb_Username
            // 
            Tb_Username.Location = new Point(248, 163);
            Tb_Username.Margin = new Padding(3, 4, 3, 4);
            Tb_Username.Name = "Tb_Username";
            Tb_Username.Size = new Size(343, 27);
            Tb_Username.TabIndex = 4;
            // 
            // Tb_Password
            // 
            Tb_Password.Location = new Point(248, 213);
            Tb_Password.Margin = new Padding(3, 4, 3, 4);
            Tb_Password.Name = "Tb_Password";
            Tb_Password.Size = new Size(343, 27);
            Tb_Password.TabIndex = 5;
            // 
            // Bt_Connect
            // 
            Bt_Connect.Location = new Point(506, 329);
            Bt_Connect.Margin = new Padding(3, 4, 3, 4);
            Bt_Connect.Name = "Bt_Connect";
            Bt_Connect.Size = new Size(86, 31);
            Bt_Connect.TabIndex = 6;
            Bt_Connect.Text = "Connect";
            Bt_Connect.UseVisualStyleBackColor = true;
            Bt_Connect.Click += Bt_Connect_Click;
            // 
            // Bt_Cancel
            // 
            Bt_Cancel.Location = new Point(414, 329);
            Bt_Cancel.Margin = new Padding(3, 4, 3, 4);
            Bt_Cancel.Name = "Bt_Cancel";
            Bt_Cancel.Size = new Size(86, 31);
            Bt_Cancel.TabIndex = 7;
            Bt_Cancel.Text = "Cancel";
            Bt_Cancel.UseVisualStyleBackColor = true;
            Bt_Cancel.Click += Bt_Cancel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(56, 32);
            label4.Name = "label4";
            label4.Size = new Size(220, 29);
            label4.TabIndex = 8;
            label4.Text = "Connect to Database";
            // 
            // Tb_databaseName
            // 
            Tb_databaseName.Enabled = false;
            Tb_databaseName.Location = new Point(248, 261);
            Tb_databaseName.Margin = new Padding(3, 4, 3, 4);
            Tb_databaseName.Name = "Tb_databaseName";
            Tb_databaseName.Size = new Size(343, 27);
            Tb_databaseName.TabIndex = 9;
            Tb_databaseName.Visible = false;
            // 
            // Database_Connection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(686, 400);
            Controls.Add(Tb_databaseName);
            Controls.Add(label4);
            Controls.Add(Bt_Cancel);
            Controls.Add(Bt_Connect);
            Controls.Add(Tb_Password);
            Controls.Add(Tb_Username);
            Controls.Add(Tb_ServerName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(686, 400);
            MinimumSize = new Size(686, 400);
            Name = "Database_Connection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Database_Connection";
            Load += Database_Connection_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Tb_ServerName;
        private TextBox Tb_Username;
        private TextBox Tb_Password;
        private Button Bt_Connect;
        private Button Bt_Cancel;
        private Label label4;
        private TextBox Tb_databaseName;
    }
}
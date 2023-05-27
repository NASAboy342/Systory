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
            SuspendLayout();
            // 
            // Bt_Close
            // 
            Bt_Close.Location = new Point(12, 12);
            Bt_Close.Name = "Bt_Close";
            Bt_Close.Size = new Size(75, 23);
            Bt_Close.TabIndex = 0;
            Bt_Close.Text = "Close";
            Bt_Close.UseVisualStyleBackColor = true;
            Bt_Close.Click += Bt_Close_Click;
            // 
            // Batch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(602, 487);
            Controls.Add(Bt_Close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Batch";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Batch";
            ResumeLayout(false);
        }

        #endregion

        private Button Bt_Close;
    }
}
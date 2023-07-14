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
            Bt_Batch=new Button();
            Pn_Feature=new Panel();
            button3=new Button();
            Bt_faculty=new Button();
            label1=new Label();
            Pn_Info=new Panel();
            Pn_Feature.SuspendLayout();
            SuspendLayout();
            // 
            // Bt_Batch
            // 
            Bt_Batch.BackColor=Color.DarkCyan;
            Bt_Batch.ForeColor=SystemColors.ButtonHighlight;
            Bt_Batch.Location=new Point(3, 3);
            Bt_Batch.Name="Bt_Batch";
            Bt_Batch.Size=new Size(143, 31);
            Bt_Batch.TabIndex=0;
            Bt_Batch.Text="Batch";
            Bt_Batch.UseVisualStyleBackColor=false;
            Bt_Batch.Click+=Bt_Batch_Click;
            // 
            // Pn_Feature
            // 
            Pn_Feature.BackColor=Color.Azure;
            Pn_Feature.Controls.Add(button3);
            Pn_Feature.Controls.Add(Bt_faculty);
            Pn_Feature.Controls.Add(Bt_Batch);
            Pn_Feature.Location=new Point(12, 62);
            Pn_Feature.Name="Pn_Feature";
            Pn_Feature.Size=new Size(151, 526);
            Pn_Feature.TabIndex=7;
            // 
            // button3
            // 
            button3.BackColor=Color.DarkCyan;
            button3.Enabled=false;
            button3.ForeColor=SystemColors.ButtonHighlight;
            button3.Location=new Point(3, 77);
            button3.Name="button3";
            button3.Size=new Size(143, 31);
            button3.TabIndex=2;
            button3.Text="button3";
            button3.UseVisualStyleBackColor=false;
            // 
            // Bt_faculty
            // 
            Bt_faculty.BackColor=Color.DarkCyan;
            Bt_faculty.ForeColor=SystemColors.ButtonHighlight;
            Bt_faculty.Location=new Point(3, 40);
            Bt_faculty.Name="Bt_faculty";
            Bt_faculty.Size=new Size(143, 31);
            Bt_faculty.TabIndex=1;
            Bt_faculty.Text="Faculty";
            Bt_faculty.UseVisualStyleBackColor=false;
            Bt_faculty.Click+=Bt_faculty_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor=Color.White;
            label1.Location=new Point(12, 9);
            label1.Name="label1";
            label1.Size=new Size(73, 33);
            label1.TabIndex=8;
            label1.Text="Main";
            // 
            // Pn_Info
            // 
            Pn_Info.BackColor=Color.Azure;
            Pn_Info.Location=new Point(169, 62);
            Pn_Info.Name="Pn_Info";
            Pn_Info.Size=new Size(1205, 526);
            Pn_Info.TabIndex=9;
            // 
            // Systory
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            AutoSize=true;
            BackColor=Color.Teal;
            ClientSize=new Size(1199, 562);
            Controls.Add(Pn_Info);
            Controls.Add(label1);
            Controls.Add(Pn_Feature);
            FormBorderStyle=FormBorderStyle.FixedDialog;
            Icon=(Icon)resources.GetObject("$this.Icon");
            Name="Systory";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Systory";
            Load+=Systory_Load;
            Pn_Feature.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Bt_Batch;
        private Panel Pn_Feature;
        private Button Bt_faculty;
        private Button button3;
        private Label label1;
        private Panel Pn_Info;
    }
}
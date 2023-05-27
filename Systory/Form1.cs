namespace Systory
{
    public partial class Systory : Form
    {
        public Systory()
        {
            InitializeComponent();
        }

        private void Bt_Batch_Click(object sender, EventArgs e)
        {
            Batch batch = new Batch();
            batch.TopLevel = false;
            Pn_Info.Controls.Add(batch);
            batch.Show();
        }
    }
}
using Systory.Controller;

namespace Systory
{
    public partial class Systory : Form
    {
        Main _main = new Main();
        public Systory()
        {
            InitializeComponent();

        }

        private void Bt_Batch_Click(object sender, EventArgs e)
        {
            Pn_Info.Controls.Clear();
            Batch batch = new Batch();
            batch.TopLevel = false;
            Pn_Info.Controls.Add(batch);
            batch.Show();
        }

        private void Systory_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Enabled = false;
            loadForm();
        }

        private void loadForm()
        {
            var connectionToDataBase = new ConnectingToDataBase();
            connectionToDataBase.Show();
            connectionToDataBase.BringToFront();
            var isConnectedToDataBase = _main.CheckConnection();
            if (!isConnectedToDataBase)
            {

                var databaseConnection = new Database_Connection();
                databaseConnection.ShowDialog();
                var isConnectedToDataBase2 = _main.CheckConnection();
                if (!isConnectedToDataBase2)
                {
                    connectionToDataBase.Close();
                    loadForm();
                }
            }
            connectionToDataBase.Close();
            this.Enabled = true;
        }

        private void Bt_faculty_Click(object sender, EventArgs e)
        {
            Pn_Info.Controls.Clear();
            Faculty faculty = new Faculty();
            faculty.TopLevel = false;
            Pn_Info.Controls.Add(faculty);
            faculty.Show();
        }
    }
}
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Hotel_Keoma
{
    public partial class Hotel_Loader : Form
    {
        public Hotel_Loader()
        {
            InitializeComponent();
        }
        readonly MySqlConnection conn = new MySqlConnection("SERVER=127.0.0.1;DATABASE=hotelkeoma;UID=root;PASSWORD=");
        private void Hotel_Loader_Load(object sender, EventArgs e)
        {
            LoaderTimer.Start();
        }

        int TimerStart = 0;
        private void LoaderTimer_Tick(object sender, EventArgs e)
        {
            TimerStart += 3;
            LoaderProgressBar.Value = TimerStart;
            if (LoaderProgressBar.Value == 100)
            {
                LoaderProgressBar.Value = 0;
                LoaderTimer.Stop();
                try
                {
                    conn.Open();
                    conn.Close();
                    Login login = new Login();
                    login.Show();
                    this.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Verifique sua conexão à internet.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }
    }
}

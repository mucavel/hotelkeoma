using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel_Keoma
{
    public partial class BookingUserControl : UserControl
    {
        public BookingUserControl()
        {
            InitializeComponent();
            FillTable();
        }

        readonly MySqlConnection conn = new MySqlConnection("SERVER=127.0.0.1;DATABASE=hotelkeoma;UID=root;PASSWORD=");
        private void BookingUserControl_Load(object sender, EventArgs e)
        {
            FillTable();
        }

        public void FillTable()
        {
            try
            {
                conn.Open();
                ReservesDataGridView.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `hotelbooking`", conn);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                ReservesDataGridView.DataSource = datatable;
                conn.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Verifique sua conexão à internet.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FillTable();
        }
    }
}

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
        private string clientID = "";
        private void BookingUserControl_Load(object sender, EventArgs e)
        {
            FillTable();
        }

        public void FillTable()
        {
            try
            {
                ReservesDataGridView.DataSource = null;
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `hotelbooking`", conn);
                conn.Close();
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                ReservesDataGridView.DataSource = datatable;
                ReservesDataGridView.Columns["ID"].Visible = false;

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
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (clientID == "" || clientID == null)
            {
                MessageBox.Show("Selecione um Cliente.", "Apagar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (MessageBox.Show("Deseja mesmo apagar os Dados?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM `hotelbooking` WHERE `ID`=@id", conn);
                        cmd.Parameters.AddWithValue("@id", clientID);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Dados Apagados.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clientID = "";
                        FillTable();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocorreu um erro ao apagar.", "Apagar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
        }

        private void GetClientID(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                clientID = ReservesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

    }
}

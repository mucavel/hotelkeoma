using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Hotel_Keoma
{
    public partial class AddReservationUserControl : UserControl
    {
        public AddReservationUserControl()
        {
            InitializeComponent();
        }
        readonly MySqlConnection conn = new MySqlConnection("SERVER=127.0.0.1;DATABASE=hotelkeoma;UID=root;PASSWORD=");

        private void ClearFields()
        {
            ClientNameTextBox.ResetText();
            PhoneNumberTexBox.ResetText();
            RoomTypeComboBox.SelectedIndex = -1;
            RoomNumberComboBox.SelectedIndex = -1;
        }
        private void BookBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `hotelbooking`(`Nome`, `Telefone`, `Tipo`, `Numero`, `Entrada`, `Saida`) VALUES (@nome, @telefone, @tipoquarto, @numeroquarto, @diaentrada, @diasaida)", conn);
                cmd.Parameters.AddWithValue("@nome", ClientNameTextBox.Text);
                cmd.Parameters.AddWithValue("@telefone", PhoneNumberTexBox.Text);
                cmd.Parameters.AddWithValue("@tipoquarto", RoomTypeComboBox.SelectedItem);
                cmd.Parameters.AddWithValue("@numeroquarto", RoomNumberComboBox.SelectedItem);
                cmd.Parameters.AddWithValue("@diaentrada", DateInPicker.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@diasaida", DateOutPicker.Value.ToString("yyyy-MM-dd"));

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Reserva Efectuda com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ResetFieldsBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void AddReservationUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Text.RegularExpressions;
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
            string clientName = ClientNameTextBox.Text.Trim();
            string phoneNumber = PhoneNumberTexBox.Text.Trim();

            if (!Regex.IsMatch(clientName, "^[\\p{L}\\s]+$|u"))
            {
                MessageBox.Show("Nome inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!Regex.IsMatch(phoneNumber, @"^\d+$"))
            {
                MessageBox.Show("Número inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (phoneNumber.Length != 9)
            {
                MessageBox.Show("Número incompleto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (
                phoneNumber.Substring(0, 2) == "82" ||
                phoneNumber.Substring(0, 2) == "83" ||
                phoneNumber.Substring(0, 2) == "84" ||
                phoneNumber.Substring(0, 2) == "85" ||
                phoneNumber.Substring(0, 2) == "86" ||
                phoneNumber.Substring(0, 2) == "87")
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
                    MessageBox.Show("Verifique sua conexão à internet.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Número inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void ResetFieldsBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}

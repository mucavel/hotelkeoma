using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel_Keoma
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        readonly MySqlConnection conn = new MySqlConnection("SERVER=127.0.0.1;DATABASE=hotelkeoma;UID=root;PASSWORD=");
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string username = UserTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();
            if (username == null || username == "" || username.Length == 0 || password == null || password == "" || password.Length == 0)
            {
                MessageBox.Show("Preencha todos campos!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT `adminName`, `adminPass` FROM `users` WHERE `adminName`=@adminName AND `adminPass`=md5(@adminPass)", conn);
                    cmd.Parameters.AddWithValue("@adminName", username);
                    cmd.Parameters.AddWithValue("@adminPass", password);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    conn.Close();
                    DataTable datatable = new DataTable();
                    adapter.Fill(datatable);

                    if (datatable.Rows.Count > 0)
                    {
                        DashBoard dashBoard = new DashBoard();
                        this.Close();
                        dashBoard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Credencias inválidas!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Verifique sua conexão à internet.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            UserTextBox.Focus();
        }
    }
}

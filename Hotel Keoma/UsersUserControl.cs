using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel_Keoma
{
    public partial class UsersUserControl : UserControl
    {
        public UsersUserControl()
        {
            InitializeComponent();
        }
        readonly MySqlConnection conn = new MySqlConnection("SERVER=127.0.0.1;DATABASE=hotelkeoma;UID=root;PASSWORD=");
        private void UsersUserControl_Load(object sender, EventArgs e)
        {
            FillUsersTable();
        }

        private string UserID = "";
        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            string admName = AddUserTextBox.Text.Trim();
            string admPassword = AddUserPassTextBox.Text.Trim();

            if (admName == "" || admName == null || admName.Length == 0 || admPassword == "" || admPassword == null || admPassword.Length == 0)
            {
                MessageBox.Show("Preencha todos campos!", "Adicionar Administrador", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO `users`(`Usuario`, `adminPass`) VALUES (@adminName, md5(@adminPass))", conn);
                    cmd.Parameters.AddWithValue("@adminName", admName);
                    cmd.Parameters.AddWithValue("@adminPass", admPassword);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Administrador Adicionado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillUsersTable();

                }
                catch (Exception)
                {
                    MessageBox.Show("Verifique sua conexão à internet.", "Adicionar Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void DeleteUserBtn_Click(object sender, EventArgs e)
        {
            if (UserID == null || UserID == "")
            {
                MessageBox.Show("Selecione um Usuário.", "Usuários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Deseja mesmo remover o Usuário?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM `users` WHERE `adminID`=@adminID", conn);
                        cmd.Parameters.AddWithValue("@adminID", UserID);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Usuário Removido.", "Usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillUsersTable();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Verifique sua conexão à internet.", "Usuários", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FillUsersTable()
        {
            try
            {
                UsersDataGridView.DataSource = null;
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `users`", conn);
                conn.Close();
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                UsersDataGridView.DataSource = datatable;
                UsersDataGridView.Columns[0].Visible = false;
                UsersDataGridView.Columns[2].Visible = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Verifique sua conexão à internet.", "Usuários", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetUserID(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                UserID = UsersDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

    }
}

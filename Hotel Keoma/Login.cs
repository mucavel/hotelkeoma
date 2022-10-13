using System;
using System.Windows.Forms;

namespace Hotel_Keoma
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            this.Close();
            dashBoard.Show();
        }
    }
}

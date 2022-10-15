using System.Windows.Forms;

namespace Hotel_Keoma
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void BookingsBtn_Click(object sender, System.EventArgs e)
        {
            AddReservationUserControl.Hide();
            BookingUserControl.Show();
            BookingUserControl.BringToFront();
        }

        private void AddReservationBtn_Click(object sender, System.EventArgs e)
        {
            BookingUserControl.Hide();
            AddReservationUserControl.Show();
            AddReservationUserControl.BringToFront();
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void LogOutLabel_Click(object sender, System.EventArgs e)
        {
            LogOut();
        }

        private void LogoutIconLabel_Click(object sender, System.EventArgs e)
        {
            LogOut();
        }
        private void LogOut()
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void UsersBtn_Click(object sender, System.EventArgs e)
        {
            ConfirmID confirmID = new ConfirmID();
            confirmID.Show();
        }
    }
}

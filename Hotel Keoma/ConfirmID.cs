using System;
using System.Windows.Forms;

namespace Hotel_Keoma
{
    public partial class ConfirmID : Form
    {
        public ConfirmID()
        {
            InitializeComponent();
        }

        private void ConfirmIDBtn_Click(object sender, EventArgs e)
        {
            AddAdmin addAdmin = new AddAdmin();
            addAdmin.Show();
            this.Close();
        }
    }
}

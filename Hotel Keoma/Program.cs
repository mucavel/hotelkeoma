using System;
using System.Windows.Forms;

namespace Hotel_Keoma
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var hotelLoader = new Hotel_Loader();
            hotelLoader.FormClosed += new FormClosedEventHandler(FormClosed);
            hotelLoader.Show();
            Application.Run();
        }
        static void FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= FormClosed;
            if (Application.OpenForms.Count == 0) Application.ExitThread();
            else Application.OpenForms[0].FormClosed += FormClosed;
        }
    }
}

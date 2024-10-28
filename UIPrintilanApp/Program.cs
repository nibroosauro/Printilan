using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIPrintilanApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            try
            {
                AppSettings.LoadEnvironment("D:/Cool-Yeah/Lima Sekawan IPK Tiga Delapan/Junior Project/Printilan/UIPrintilanApp/.env"); // Load .env file once on startup
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading environment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit if loading fails
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LandingPage());
        }
    }
}

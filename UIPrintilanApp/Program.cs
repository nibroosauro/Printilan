using System;
using System.Collections.Generic;
using System.IO;
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
            //sorry lin, but your relative path is not working for me 😭😭😭
            //try
            //{
            //    string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //    string envFilePath = Path.Combine(baseDirectory, ".env");
            //    AppSettings.LoadEnvironment(envFilePath); // Load .env file once on startup
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error loading environment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return; // Exit if loading fails
            //}

            try
            {
                // Get the application's root directory (up two levels from BaseDirectory)
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string projectRoot = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\"));

                // Build the full path to the .env file relative to the root
                string envFilePath = Path.Combine(projectRoot, ".env");

                // Load the .env file
                AppSettings.LoadEnvironment(envFilePath);
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

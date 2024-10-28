using System;

namespace UIPrintilanApp
{
    public static class AppSettings
    {
        // Static property to hold the connection string
        public static string ConnectionString { get; private set; }

        // Static method to load the .env file and set ConnectionString
        public static void LoadEnvironment(string filePath)
        {
            EnvReader.Load(filePath); // Load environment variables
            ConnectionString = Environment.GetEnvironmentVariable("connstring");

            if (string.IsNullOrEmpty(ConnectionString))
            {
                throw new InvalidOperationException("Connection string could not be initialized. Check your .env file.");
            }
        }
    }
}

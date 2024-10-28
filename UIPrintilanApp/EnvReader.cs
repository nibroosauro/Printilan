using System;
using System.IO;

namespace UIPrintilanApp
{
    class EnvReader
    {
        public static void Load(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"The file '{filePath}' does not exist.");

            var lines = File.ReadAllLines(filePath);

            // Ensure there are enough lines in the file
            if (lines.Length < 6)
                throw new InvalidDataException("The .env file must contain at least 6 lines for host, port, username, password, database, and include error detail.");

            // Retrieve each line by index as the specified value
            string host = lines[0].Trim();
            string port = lines[1].Trim();
            string username = lines[2].Trim();
            string password = lines[3].Trim();
            string database = lines[4].Trim();
            string includeErrorDetail = lines[5].Trim();

            // Assemble and set the PostgreSQL connection string in environment variables
            string connectionString = $"Host={host};Port={port};Username={username};Password={password};Database={database};Include Error Detail={includeErrorDetail}";
            Environment.SetEnvironmentVariable("connstring", connectionString);
        }
    }
}

using System;

namespace ClassPrintilanApp
{
    class User
    {
        // Instance variables
        private int _userID;
        private string _username;
        private string _email;
        private string _phoneNumber;
        private string _name;
        private string _password;

        // Properties per attribute
        public int UserID
        {
            get { return _userID; }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        // Constructor
        public User(int userId, string username, string email, string phoneNumber, string name, string password)
        {
            _userID = userId;
            _username = username;
            _email = email;
            _phoneNumber = phoneNumber;
            _name = name;
            _password = password;
        }

        // Methods
        public bool Login(string username, string password)
        {
            // ((ini cyma dummy data buat login))
            if (username == "Barbara" && password == "cakep")
            {
                _userID = 1;
                _username = username;
                _email = "barbara@example.com";
                _phoneNumber = "08123456789";
                _name = "Barbara";
                return true;
            }
            else if (username == "Powerpuff" && password == "sukses")
            {
                _userID = 2;
                _username = username;
                _email = "powerpuff@example.com";
                _phoneNumber = "08129876543";
                _name = "Powerpuff";
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SignUp(string username, string email, string phoneNumber, string name, string password)
        {
            _userID = new Random().Next(1, 1000);
            _username = username;
            _email = email;
            _phoneNumber = phoneNumber;
            _name = name;
            _password = password;
            Console.WriteLine("SignUp berhasil! Akun baru telah dibuat dengan nama: " + _name);
        }

        public void Logout()
        {
            Console.WriteLine(_username + " telah logout.");
            _userID = 0;
            _username = null;
            _email = null;
            _phoneNumber = null;
            _name = null;
            _password = null;
        }

        public void DeleteAccount()
        {
            Console.WriteLine(_username + " telah menghapus akunnya.");
            _userID = 0;
            _username = null;
            _email = null;
            _phoneNumber = null;
            _name = null;
            _password = null;
        }
    }
}

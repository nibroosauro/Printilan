using ClassPrintilanApp;
using System;
using System.Collections.Generic;

namespace ClassPrintilanApp
{
    class Customer : User
    {
        private int _customerID;
        private List<int> _wishlist; // Asumsiku wishlist udh contains product IDs

        // Property untuk CustomerID dan Wishlist
        public int CustomerID
        {
            get { return _customerID; }
        }

        public List<int> Wishlist
        {
            get { return _wishlist; }
        }

        // Constructor
        public Customer(int userId, string username, string email, string phoneNumber, string name, string password)
            : base(userId, username, email, phoneNumber, name, password)
        {
            _customerID = userId; //  Asumsiku customer_id = user_id
            _wishlist = new List<int>();
        }

        // Method AddToWishlist
        public void AddToWishlist(int productId)
        {
            if (!_wishlist.Contains(productId))
            {
                _wishlist.Add(productId);
                Console.WriteLine("Produk dengan ID " + productId + " telah ditambahkan ke wishlist.");
            }
            else
            {
                Console.WriteLine("Produk ini sudah ada di wishlist.");
            }
        }

        // Method RemoveFromWishlist
        public void RemoveFromWishlist(int productId)
        {
            if (_wishlist.Contains(productId))
            {
                _wishlist.Remove(productId);
                Console.WriteLine("Produk dengan ID " + productId + " telah dihapus dari wishlist.");
            }
            else
            {
                Console.WriteLine("Produk ini tidak ada di wishlist.");
            }
        }

        // Method ViewWishlist
        public void ViewWishlist()
        {
            if (_wishlist.Count > 0)
            {
                Console.WriteLine("Wishlist Anda berisi produk berikut:");
                foreach (int productId in _wishlist)
                {
                    Console.WriteLine("Produk ID: " + productId);
                }
            }
            else
            {
                Console.WriteLine("Wishlist Anda kosong.");
            }
        }

        // Method SearchProduct
        public void SearchProduct(string productName)
        {
            // Logic pencarian produk (dummy)
            Console.WriteLine("Mencari produk: " + productName);
            // Search result
            Console.WriteLine("Produk ditemukan: " + productName);
        }

        // Method CreateReview
        public void CreateReview(int productId, int rating, string comments)
        {
            // Simulate review creation
            Console.WriteLine("Review untuk produk dengan ID " + productId + " telah dibuat.");
            Console.WriteLine("Rating: " + rating);
            Console.WriteLine("Komentar: " + comments);
        }
    }
}

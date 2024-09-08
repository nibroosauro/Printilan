using ClassPrintilanApp;
using System;
using System.Collections.Generic;

namespace ClassPrintilanApp
{
    class Customer : User
    {
        private int _customerID;
        private Wishlist _wishlist; // Asumsiku wishlist udh contains product IDs
        private List<Review> _reviews;

        // Property untuk CustomerID dan Wishlist
        public int CustomerID
        {
            get { return _customerID; }
        }

        public Wishlist Wishlist
        {
            get { return _wishlist; }
        }

        public List<Review> Reviews
        {
            get { return _reviews; }
        }

        // Constructor
        public Customer(int wishlistID,int userId, string username, string email, string phoneNumber, string name, string password)
            : base(userId, username, email, phoneNumber, name, password)
        {
            _customerID = userId; //  Asumsiku customer_id = user_id
            _wishlist = new Wishlist(wishlistID);
            _reviews = new List<Review>();
        }

        // Method AddToWishlist
        public void AddToWishlist(int productId)
        {
            _wishlist.AddProduct(productId);
            //if (!_wishlist.Contains(productId))
            //{
            //    _wishlist.Add(productId);
            //    Console.WriteLine("Produk dengan ID " + productId + " telah ditambahkan ke wishlist.");
            //}
            //else
            //{
            //    Console.WriteLine("Produk ini sudah ada di wishlist.");
            //}
        }

        // Method RemoveFromWishlist
        public void RemoveFromWishlist(int productId)
        {
            _wishlist.RemoveProduct(productId);
            //if (_wishlist.Contains(productId))
            //{
            //    _wishlist.Remove(productId);
            //    Console.WriteLine("Produk dengan ID " + productId + " telah dihapus dari wishlist.");
            //}
            //else
            //{
            //    Console.WriteLine("Produk ini tidak ada di wishlist.");
            //}
        }

        // Method ViewWishlist
        public void ViewWishlist()
        {
            _wishlist.ViewProducts();
            //if (_wishlist.Count > 0)
            //{
            //    Console.WriteLine("Wishlist Anda berisi produk berikut:");
            //    foreach (int productId in _wishlist)
            //    {
            //        Console.WriteLine("Produk ID: " + productId);
            //    }
            //}
            //else
            //{
            //Console.WriteLine("Wishlist Anda kosong.");
            //}
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
        public void CreateReview(int reviewId, int productId, int rating, string comments)
        {
            Review review = new Review(reviewId, _customerID, productId, rating, comments);
            _reviews.Add(review);
            //Dummy
            Console.WriteLine("Review untuk produk dengan ID " + productId + " telah dibuat.");
            Console.WriteLine("Rating: " + rating);
            Console.WriteLine("Komentar: " + comments);
        }
    }

    class Wishlist
    {
        private int _wishlistID;
        private List<int> _productIds;

        public int WishlistID
        {
            get { return _wishlistID; }
        }

        //Constructor
        public Wishlist(int wishlistID)
        {
            _wishlistID = wishlistID;
            _productIds = new List<int>();
        }

        // Method untuk menambahkan produk ke wishlist
        public void AddProduct(int productId)
        {
            if (!_productIds.Contains(productId))
            {
                _productIds.Add(productId);
                Console.WriteLine("Produk dengan ID " + productId + " telah ditambahkan ke wishlist.");
            }
            else
            {
                Console.WriteLine("Produk ini sudah ada di wishlist.");
            }
        }

        // Method untuk menghapus produk dari wishlist
        public void RemoveProduct(int productId)
        {
            if (_productIds.Contains(productId))
            {
                _productIds.Remove(productId);
                Console.WriteLine("Produk dengan ID " + productId + " telah dihapus dari wishlist.");
            }
            else
            {
                Console.WriteLine("Produk ini tidak ada di wishlist.");
            }
        }

        // Method untuk menampilkan produk di wishlist
        public void ViewProducts()
        {
            if (_productIds.Count > 0)
            {
                Console.WriteLine("Wishlist Anda berisi produk berikut:");
                foreach (var productId in _productIds)
                {
                    Console.WriteLine("Produk ID: " + productId);
                }
            }
            else
            {
                Console.WriteLine("Wishlist Anda kosong.");
            }
        }

        // Method IsWishlisted untuk mengecek apakah produk ada di wishlist
        public bool IsWishlisted(int productId)
        {
            return _productIds.Contains(productId);
        }
    }

    class Review
    {
        private int _reviewID;
        private int _customerID;
        private int _productID;
        private int _rating;
        private string _comments;

        public int ReviewID
        {
            get { return _reviewID; }
        }

        public int Rating
        {
            get { return _rating; }
        }

        public string Comments
        {
            get { return _comments; }
        }

        // Constructor
        public Review(int reviewID,int customerID, int productID, int rating, string comments)
        {
            _reviewID = reviewID;
            _customerID = customerID;
            _productID = productID;
            _rating = rating;
            _comments = comments;
        }

        // Method untuk menampilkan review
        public void DisplayReview()
        {
            Console.WriteLine("Review ID: " + _reviewID);
            Console.WriteLine("Produk ID: " + _productID);
            Console.WriteLine("Rating: " + _rating);
            Console.WriteLine("Komentar: " + _comments);
        }
    }

}
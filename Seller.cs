using ClassPrintilanApp;
using System;

namespace ClassPrintilanApp
{
    class Seller : User
    {
        private int _sellerID;
        private Store _store;

        // Property SellerID n Store
        public int SellerID
        {
            get { return _sellerID; }
        }

        public Store Store
        {
            get { return _store; }
        }

        // Constructor
        public Seller(int userId, string username, string email, string phoneNumber, string name, string password, Store store)
            : base(userId, username, email, phoneNumber, name, password)
        {
            _sellerID = userId; //  Asumsiku seller_id = user_id
            _store = store;
        }

        // Method ManageStore
        public void ManageStore()
        {
            if (_store != null)
            {
                Console.WriteLine("Mengelola toko: " + _store.StoreName);
                _store.DisplayProducts(); // Display products in the store
                // Logic mengelola toko (tambah, hapus produk, etc)
            }
            else
            {
                Console.WriteLine("Seller ini belum memiliki toko.");
            }
        }
    }

    // Ngebuat Class sebagai compositionnya Seller
    // Store Class as a composition relation to Seller
    class Store
    {
        // Instance variables untuk Store (private fields)
        private int _storeID;
        private string _storeName;
        private string _location;

        // Properties untuk Store (correct use of public modifier)
        public int StoreID
        {
            get { return _storeID; }
        }

        public string StoreName
        {
            get { return _storeName; }
        }

        public string Location
        {
            get { return _location; }
        }

        // Constructor untuk Store (correct place for public)
        public Store(int storeID, string storeName, string location)
        {
            _storeID = storeID;
            _storeName = storeName;
            _location = location;
        }

        // Method untuk DisplayProducts (correct place for public)
        public void DisplayProducts()
        {
            Console.WriteLine("Produk di toko: " + _storeName);
            // Logic untuk menampilkan produk (saat ini dummy)
            Console.WriteLine("Produk 1: Laptop\nProduk 2: Smartphone");
        }

        // Methods lainnya yang bisa ditambahkan untuk mengelola produk
        public void AddProduct(string product)
        {
            // Logic untuk menambahkan produk ke toko
            Console.WriteLine(product + " telah ditambahkan ke toko.");
        }

        public void RemoveProduct(string product)
        {
            // Logic untuk menghapus produk dari toko
            Console.WriteLine(product + " telah dihapus dari toko.");
        }
    }
}
using System;

namespace ClassPrintilanApp
{
    class Product
    {    
        public enum productCategory
        {
            Electronic,
            Bathroom,
            Study,
            Cooking,
            Hygiene,
            Personal
        }

        public struct Dimensions
        {
            public double Length { get; }
            public double Width { get; }
            public double Height { get; }

            public Dimensions(double length, double width, double height)
            {
                Length = length;
                Width = width;
                Height = height;
            }

            public override string ToString()
            {
                return $"Length: {Length}, Width: {Width}, Height: {Height}";
            }
        }
        
        // attributes
        private int _productID;
        private string _productName;
        private float _price;
        private string _material;
        private productCategory _category;
        private Dimensions _dimensions;
        private bool _availability;
        private string _description; 


        // properties
        public int ProductID
        {
            get { return _productID; }
        }

        public string ProductName
        {
            get { return _productName; }
        }

        public float Price
        {
            get { return _price; }
        }

        public string Material
        {
            get { return _material; }
        }

        public productCategory Category
        {
            get { return _category; }
        }

        public Dimensions _Dimensions 
        {
            get { return _dimensions; }
        }

        public bool Availability
        {
            get { return _availability; }
        }

        public string Description 
        {
            get { return _description; }
        }

        // constructror
        public Product(int productID, string productName, float price, string material, productCategory category, Dimensions dimensions, bool availability, string description)
        {
            _productID = productID;
            _productName = productName;
            _price = price;
            _material = material;
            _category = category;
            _dimensions = dimensions;
            _availability = availability;
            _description = description;
        }

        // methods
        public void DisplayInfo()
        {
            Console.WriteLine($"Product ID: {_productID}");
            Console.WriteLine($"Product Name: {_productName}");
            Console.WriteLine($"Price: {_price:C}"); 
            Console.WriteLine($"Material: {_material}");
            Console.WriteLine($"Category: {_category}"); 
            Console.WriteLine($"Dimensions: {_dimensions.Length} x {_dimensions.Width} x {_dimensions.Height}");
            Console.WriteLine($"Availability: {(_availability ? "In Stock" : "Out of Stock")}");
            Console.WriteLine($"Description: {_description}");
        }

        public bool IsAvailable(int productID){
            // Logic dengan database (SELECT _availability FROM product WHERE _productID = productID)
            return _availability;
        }
    }
}
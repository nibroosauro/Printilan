-- -- User

CREATE TABLE "User" (
    UserID SERIAL PRIMARY KEY, 
    Username VARCHAR(50) NOT NULL UNIQUE, 
    Email VARCHAR(100) NOT NULL UNIQUE, 
    Phone_Number VARCHAR(15), -- optional
    Full_Name VARCHAR(100), 
    Password VARCHAR(255) NOT NULL -- Hashed password 
);

-- -- Seller

CREATE TABLE Seller (
    SellerID SERIAL PRIMARY KEY, 
    UserID INT NOT NULL, 
    FOREIGN KEY (UserID) REFERENCES "User"(UserID) ON DELETE CASCADE ON UPDATE CASCADE
);

-- -- Store

CREATE TABLE Store (
    StoreID SERIAL PRIMARY KEY, 
    SellerID INT NOT NULL, 
    Store_Name VARCHAR(50) NOT NULL, 
    Location VARCHAR(100) NOT NULL,
    FOREIGN KEY (SellerID) REFERENCES Seller(SellerID) ON DELETE CASCADE ON UPDATE CASCADE -- Enforce referential integrity
);

-- Customer

CREATE TABLE Customer ( 
	CustomerID SERIAL PRIMARY KEY, 
	UserID INT NOT NULL, 
	FOREIGN KEY (UserID) REFERENCES "User"(UserID) ON DELETE CASCADE ON UPDATE CASCADE
 );

-- Product

CREATE TABLE Product (
    productID SERIAL PRIMARY KEY,
	storeID INT NOT NULL,
    productName VARCHAR(100) NOT NULL,
    price DECIMAL(10, 2) NOT NULL,
    category VARCHAR(50) NOT NULL,
    material VARCHAR(50),
    Dimensions VARCHAR(50),
    availability BOOLEAN DEFAULT TRUE,
    description VARCHAR(500),
	FOREIGN KEY (storeID) REFERENCES store(storeID) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT check_category CHECK (category IN ('Electronic', 'Bathroom', 'Study', 'Cooking', 'Hygiene', 'Personal'))
);

-- Wishlist

CREATE TABLE Wishlist (
    wishlistID SERIAL PRIMARY KEY, 
    productID INT NOT NULL, 
    UserID INT NOT NULL, 
    IsWishlisted BOOLEAN NOT NULL DEFAULT TRUE,     	
	FOREIGN KEY (productID) REFERENCES Product(ProductID) ON DELETE CASCADE ON UPDATE CASCADE, 
    FOREIGN KEY (UserID) REFERENCES "User"(UserID) ON DELETE CASCADE ON UPDATE CASCADE -- User reference
);

-- Review

CREATE TABLE Review ( 
	ReviewID SERIAL PRIMARY KEY, 	
	CustomerID INT NOT NULL, 
	ProductID INT NOT NULL, 
	Rating INT CHECK (Rating IN (1, 2, 3, 4, 5)) NOT NULL,
	"Comments" VARCHAR(500), 
	FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (ProductID) REFERENCES Product(ProductID) ON DELETE CASCADE ON UPDATE CASCADE 
);

-- Transaction

CREATE TABLE "Transaction" (
	transactionID SERIAL PRIMARY KEY,
	customerID INT NOT NULL,
	productID INT NOT NULL,
	transaction_date TIMESTAMPTZ NOT NULL,
	payment_status VARCHAR(50),
	delivery_status VARCHAR(50),
	FOREIGN KEY (customerID) REFERENCES customer(customerID) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (productID) REFERENCES product(productID) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT check_payment CHECK (payment_status IN ('Pending', 'Completed', 'Failed')),
	CONSTRAINT check_delivery CHECK (delivery_status IN ('Pending', 'Shipped', 'Delivery', 'Failed'))
);

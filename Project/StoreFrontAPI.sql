CREATE DATABASE StoreFront;
USE StoreFront;

CREATE TABLE Customers(
	CustomerId INT NOT NULL auto_increment,
    FirstName VARCHAR(1000) NOT NULL,
    LastName VARCHAR(1000) NOT NULL,
    EmailAddress VARCHAR(1000) NOT NULL,
    POAddress VARCHAR(1000) NOT NULL,
    PRIMARY KEY( CustomerId )
);

CREATE TABLE Orders(
	OrderId INT NOT NULL auto_increment,
    CustomerId INT REFERENCES Customers(CustomerId),
    OrderStatus VARCHAR(1000) NOT NULL,
    OrderDate DATE,
    PRIMARY KEY ( OrderId )
);

CREATE TABLE Products(
	ProductId INT NOT NULL auto_increment,
    ProductName VARCHAR(1000) NOT NULL,
    Price DECIMAL NOT NULL,
    PRIMARY KEY ( ProductId )
);

CREATE TABLE ShoppingCart(
	ItemId INT NOT NULL auto_increment,
    OrderId INT REFERENCES Orders(OrderId),
    ProductId INT REFERENCES Product(ProductId),
    Quantity INT NOT NULL,
    Price DECIMAL NOT NULL,
    PRIMARY KEY ( ItemId, OrderId )
);

ALTER TABLE orders ADD CONSTRAINT UniqueDate UNIQUE (OrderDate);

INSERT INTO Customers Values(1, "Darren", "Liang", "abc@email.com", "123 4th Street Brooklyn NY");
INSERT INTO Orders Values (1, 1, "Delivered", "2022-01-01");
INSERT INTO Orders Values (2, 1, "Pending", "2022-02-04");

INSERT INTO Products Values(1, "Toy", 5.99);
INSERT INTO Products Values(2, "Monitor", 99.99);
INSERT INTO Products Values(3, "Chair", 29.99);

INSERT INTO ShoppingCart Values (1, 1, 3, 2, 29.99);
INSERT INTO ShoppingCart Values (2, 2, 1, 1, 99.99);
INSERT INTO ShoppingCart Values (2, 2, 1, 1, 5.99);
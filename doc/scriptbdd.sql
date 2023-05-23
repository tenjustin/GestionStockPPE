-- création de la table suppliers
CREATE TABLE [dbo].[suppliers] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
    [name]         VARCHAR (255) NOT NULL,
    [address]      VARCHAR (255) NULL,
    [phone_number] VARCHAR (20)  NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);
INSERT INTO suppliers (name, address, phone_number) VALUES ('Carrefour', 'Rue Foch, Montpellier', '0606060606');

-- création de la table categories
CREATE TABLE [dbo].[categories] (
    [id]   INT           IDENTITY (1, 1) NOT NULL,
    [name] VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);
INSERT INTO categories (name) VALUES ('PC Portable'), ('PC GAMER');

-- création de la table products
CREATE TABLE [dbo].[products] (
    [id]          INT           IDENTITY (1, 1) NOT NULL,
    [name]        VARCHAR (255) NOT NULL,
    [description] VARCHAR (255) NULL,
    [category_id] INT           NOT NULL,
    [supplier_id] INT           NOT NULL,
    [price]       DECIMAL (18)  NOT NULL,
    [quantity]    INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [product_category] FOREIGN KEY ([category_id]) REFERENCES [dbo].[categories] ([id]),
    CONSTRAINT [product_supplier] FOREIGN KEY ([supplier_id]) REFERENCES [dbo].[suppliers] ([id])
);
INSERT INTO products (name, category_id, supplier_id, price, quantity) VALUES ('Laptop MSI', '1', '1', '640', 17);

-- création de la table orders
CREATE TABLE [dbo].[orders] (
    [id]         INT          IDENTITY (1, 1) NOT NULL,
    [order_date] DATE         NOT NULL,
    [product_id] INT          NOT NULL,
    [quantity]   INT          NOT NULL,
    [unit_price] DECIMAL (18) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [order_product] FOREIGN KEY ([product_id]) REFERENCES [dbo].[products] ([id])
);
INSERT INTO orders (order_date, product_id, quantity, unit_price) VALUES ('15/03/2023', '1', '1', '640');

-- création de la table roles
CREATE TABLE [dbo].[roles] (
    [id]   INT           IDENTITY (1, 1) NOT NULL,
    [name] VARCHAR (255) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);
INSERT INTO roles (name) VALUES ('Directrice'), ('Employé');

-- création de la table users
CREATE TABLE [dbo].[users] (
    [id]       INT           IDENTITY (1, 1) NOT NULL,
    [username] VARCHAR (255) NOT NULL,
    [password] VARCHAR (255) NOT NULL,
    [role_id]  INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [user_role] FOREIGN KEY ([role_id]) REFERENCES [dbo].[roles] ([id])
);
INSERT INTO orders (username, password, role_id) VALUES ('directrice', 'directrice', '1'), ('employe', 'employe', '2');

--Declencheur pour maj des commandes (maj du stock auto)
CREATE TRIGGER majStockUpdateOrder ON orders AFTER UPDATE AS
BEGIN
	Declare @deltaQty INT
	declare @oldQty INT
	declare @newQty INT
	declare @qtyUpdt INT
	set @qtyUpdt = (Select quantity from products where id=(Select product_id from inserted))
	set @oldQty = (Select quantity from deleted)
	set @newQty = (Select quantity from inserted)
	IF (@oldQty >= @newQty)
	BEGIN
		SET @deltaQty = @oldQty - @newQty
		Update products SET quantity = @qtyUpdt + @deltaQty Where id = (Select product_id from inserted)	
	END
	ELSE 
	BEGIN
		SET @deltaQty = @newQty - @oldQty;
		Update products SET quantity = @qtyUpdt - @deltaQty Where id = (Select product_id from inserted)
	END
END
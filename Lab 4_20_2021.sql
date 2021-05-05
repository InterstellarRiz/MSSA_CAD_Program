USE TSQLV4;

DROP TABLE IF EXISTS dbo.Customers;

CREATE TABLE dbo.Customers
(
	custid		INT				NOT NULL PRIMARY KEY,
	companyname NVARCHAR(40)	NOT NULL,
	country		NVARCHAR(15)	NOT NULL,
	region		NVARCHAR(15)	NULL,
	city		NVARCHAR(15)	NOT NULL
);
/*
INSERT INTO dbo.Customers(custid, companyname, country, region, city)
	--OUTPUT inserted.custid, inserted.companyname
	VALUES(100, 'Coho Winery', 'USA', 'WA', 'Redmond')

SELECT * FROM dbo.Customers;

-- Exercise 1-2 : Compy from Sales.Customers into dbo.Customers
INSERT INTO dbo.Customers (custid, companyname, country, region, city)
SELECT custid, companyname, country, region, city
	FROM Sales.Customers AS C
	WHERE EXISTS (SELECT * FROM Sales.Orders AS O
		WHERE O.custid = C.custid);

--INSERT
	--INTO  dbo.Customers
	--OUTPUT inserted.custid, inserted.companyname
	--SELECT DISTINCT C.custid, companyname, country, region, city
		--FROM Sales.Customers AS C
		--INNER JOIN Sales.Orders AS O
			--ON C.custid = O.custid;
*/
DROP TABLE IF EXISTS dbo.Orders;

CREATE TABLE dbo.Orders
(
	orderid	INT NOT NULL,
		CONSTRAINT PK_Orders
			PRIMARY KEY(orderid),

	custid			INT			NULL,
	empid			INT			NOT NULL,
	orderdate		DATE		NOT NULL,
	requireddate	DATE		NOT NULL,
	shippeddate		DATE		NULL,
	shipperid		INT			NOT NULL,

	freight			MONEY		NOT NULL
		CONSTRAINT DFLT_Orders_freight
			DEFAULT(0),

	shipname		NVARCHAR(40)	NOT NULL,
	shipaddress		NVARCHAR(60)	NOT NULL,
	shipcity		NVARCHAR(15)	NOT NULL,
	shipregion		NVARCHAR(15)	NULL,
	shippostalcode	NVARCHAR(15)	NULL,
	shipcountry		NVARCHAR(15)	NOT NULL
);

INSERT INTO dbo.Orders SELECT * FROM Sales.Orders;

SELECT * FROM dbo.Orders;

DELETE FROM dbo.Orders
	OUTPUT deleted.orderid, deleted.orderdate
	WHERE orderdate < '2014-08-01';

--EX :3

DELETE FROM O	
	OUTPUT deleted.orderid, deleted.shipcountry
	FROM dbo.Orders AS O
	INNER JOIN dbo.Customers AS C
		ON O.custid = C.custid
	WHERE C.country = N'Brazil';


-- Ex 4

SELECT * FROM dbo.Customers;

UPDATE dbo.Customers
	SET region = '<None>'
	OUTPUT deleted.custid, deleted.region AS oldRegion, inserted.region AS newRegion
	WHERE region IS null;

-- Ex 5: Update Orders to have the same country, region, city as the Customer that placed the order

UPDATE O
	SET shipcountry = C.country,
		shipregion = C.region,
		shipcity	= C.city
	OUTPUT deleted.shipcountry AS oldCountry, inserted.shipcountry AS newCountry,
			deleted.shipregion AS oldRegion, inserted.shipregion AS newRegion,
			deleted.shipcity AS oldCity, inserted.shipcity AS newCity
	FROM dbo.Orders AS O
		INNER JOIN dbo.Customers AS C
			ON O.custid = C.custid
	WHERE C.country = 'UK';

-- Ex 6 
TRUNCATE TABLE dbo.Customer;
TRUNCATE TABLE dbo.Orders;



USE TSQLV4;

DROP TABLE IF EXISTS dbo.OrderDetails, dbo.Orders;

CREATE TABLE dbo.Orders
(
  orderid        INT          NOT NULL,
    CONSTRAINT PK_Orders
      PRIMARY KEY(orderid),
 
  custid         INT          NULL,
  empid          INT          NOT NULL,
  orderdate      DATE         NOT NULL,
  requireddate   DATE         NOT NULL,
  shippeddate    DATE         NULL,
  shipperid      INT          NOT NULL,
 
  freight        MONEY        NOT NULL -- No Comma
    CONSTRAINT DFLT_Orders_freight
      DEFAULT(0),
 
  shipname       NVARCHAR(40) NOT NULL,
  shipaddress    NVARCHAR(60) NOT NULL,
  shipcity       NVARCHAR(15) NOT NULL,
  shipregion     NVARCHAR(15) NULL,
  shippostalcode NVARCHAR(10) NULL,
  shipcountry    NVARCHAR(15) NOT NULL
);
 
INSERT INTO dbo.Orders SELECT * FROM Sales.Orders;
 
SELECT * FROM dbo.Orders;

CREATE TABLE dbo.OrderDetails
(
  orderid   INT           NOT NULL,
    CONSTRAINT FK_OrderDetails_Orders
      FOREIGN KEY(orderid)
        REFERENCES dbo.Orders(orderid),
 
  productid INT           NOT NULL,
    CONSTRAINT PK_OrderDetails
      PRIMARY KEY(orderid, productid),
 
  unitprice MONEY         NOT NULL
    CONSTRAINT DFLT_OrderDetails_unitprice
      DEFAULT(0),
    CONSTRAINT CHK_unitprice
      CHECK (unitprice >= 0),
 
  qty       SMALLINT      NOT NULL
    CONSTRAINT DFLT_OrderDetails_qty
      DEFAULT(1),
    CONSTRAINT CHK_qty
      CHECK (qty > 0),
 
  discount  NUMERIC(4, 3) NOT NULL
    CONSTRAINT DFLT_OrderDetails_discount
      DEFAULT(0),
    CONSTRAINT CHK_discount
      CHECK (discount BETWEEN 0 AND 1),
);
 
INSERT INTO dbo.OrderDetails SELECT * FROM Sales.OrderDetails;
 
SELECT * FROM dbo.OrderDetails;


UPDATE dbo.OrderDetails
	SET discount = discount + 0.05

UPDATE dbo.OrderDetails
	SET discount = discount + 0.001
	WHERE productid = 51;

UPDATE OD
  SET discount += 0.05
  FROM dbo.OrderDetails AS OD
    INNER JOIN dbo.Orders AS O
      ON OD.orderid = O.orderid
  WHERE O.custid = 1;

SELECT OD.*, O.*
  FROM dbo.OrderDetails AS OD
    INNER JOIN dbo.Orders AS O
      ON OD.orderid = O.orderid
  WHERE O.custid = 1;

DELETE FROM dbo.Customers
	WHERE custid = 1;

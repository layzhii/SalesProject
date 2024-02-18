CREATE DATABASE SalesDB;
GO

CREATE TABLE SalesDB.dbo.Store
(
	StoreCode int not null,
	StoreName nvarchar(7) not null,
	CONSTRAINT PK_Store PRIMARY KEY CLUSTERED (StoreCode ASC));
GO

BULK INSERT SalesDB.dbo.Store FROM 'C:\Users\Buda\Desktop\ЗАДАНИЕ соискателю\1\Список магазинов.txt'
WITH
(
	FIRSTROW = 2,
	FIELDTERMINATOR = ';',
	ROWTERMINATOR  = '\n',
	DATAFILETYPE = 'widechar');
GO

CREATE TABLE SalesDB.dbo.Products
(
	ProductCode nvarchar(11) not null,
	ProductName nvarchar(100) not null,
	IsWeight nvarchar(10) not null,
	CountPackage decimal(8,3) not null,
	CONSTRAINT PK_Products PRIMARY KEY CLUSTERED (ProductCode ASC));
GO

BULK INSERT SalesDB.dbo.Products FROM 'C:\Users\Buda\Desktop\ЗАДАНИЕ соискателю\1\Список товаров.txt'
WITH
(
	FIRSTROW = 2,
	FIELDTERMINATOR = ';',
	ROWTERMINATOR  = '\n',
	DATAFILETYPE = 'widechar');
GO

CREATE TABLE SalesDB.dbo.Sales
(
	DateOfSale date not null,
	DivisionCode int not null,
	Waremark nvarchar(11) not null,
	TotalCount decimal(8,3) not null
	);
GO

ALTER TABLE SalesDB.dbo.Sales    
ADD CONSTRAINT FK_Sales_DivisionCode FOREIGN KEY (DivisionCode)     
    REFERENCES SalesDB.dbo.Store (StoreCode);
GO

ALTER TABLE SalesDB.dbo.Sales    
ADD CONSTRAINT FK_Sales_Waremark FOREIGN KEY (Waremark)     
    REFERENCES SalesDB.dbo.Products (ProductCode);
GO

BULK INSERT SalesDB.dbo.Sales FROM 'C:\Users\Buda\Desktop\ЗАДАНИЕ соискателю\1\Продажи товара в магазине.txt'
WITH
(
	FIRSTROW = 2,
	FIELDTERMINATOR = ';',
	ROWTERMINATOR  = '\n',
	DATAFILETYPE = 'widechar');
GO

USE SalesDB;
GO
CREATE OR ALTER PROCEDURE ProductSummary 
AS
SELECT ProductCode, ProductName, IsWeight, CountPackage from SalesDB.dbo.Products;
GO

EXEC ProductSummary
GO

USE SalesDB;
GO
CREATE OR ALTER PROCEDURE StoreSummary 
AS
SELECT StoreCode, StoreName from SalesDB.dbo.Store;
GO

EXEC StoreSummary
GO

USE SalesDB;
GO

CREATE TYPE t_varchar20_list AS TABLE
(
	Code varchar(20) NOT NULL, PRIMARY KEY CLUSTERED (code ASC)
)
GO

USE SalesDB;
GO
CREATE TYPE t_int_list AS TABLE
(
	Code int NOT NULL, PRIMARY KEY CLUSTERED (code ASC)
)
GO

USE SalesDB;
GO

CREATE OR ALTER PROCEDURE Proc_InfoSales
(
	@storeCodeList t_int_list READONLY,
	@productCodeList t_varchar20_list READONLY,
	@date1 date,
	@date2 date
)
AS
BEGIN
	SELECT  StoreName,
			Waremark,
			ProductName,
			sum(TotalCount) as TotalCountSum

	FROM SalesDb.dbo.Sales join SalesDb.dbo.Store    on SalesDb.dbo.Sales.DivisionCode = SalesDb.dbo.Store.StoreCode
						   join SalesDb.dbo.Products on SalesDb.dbo.Sales.Waremark = SalesDb.dbo.Products.ProductCode
	WHERE StoreCode in (select Code from @storeCodeList) and 
		  (DateOfSale between @date1 and @date2) and
		  Waremark in (select Code from @productCodeList)
	GROUP BY StoreName, Waremark, ProductName
END
GO


USE SalesDB;
GO
CREATE OR ALTER PROCEDURE Proc_InfoSalesAVG
(
	@storeCodeList t_int_list READONLY,
	@productCodeList t_varchar20_list READONLY,
	@date1 date,
	@date2 date
)
AS
BEGIN
select StoreName,
		Waremark,
		ProductName,
		SumTotalCount,
		case
			when CountI<7 then 0
			else avg(TotalCount)
		end as AvgDaily
from 
	(SELECT  DateOfSale,
			StoreName,
			Waremark,
			ProductName,
			TotalCount,
			sum(TotalCount) over (partition by StoreName, ProductName) as SumTotalCount,
			row_number() over (partition by StoreName, ProductName order by DateOfSale desc) as i,
			count(TotalCount) over (partition by StoreName, ProductName) as CountI

	FROM SalesDb.dbo.Sales join SalesDb.dbo.Store    on SalesDb.dbo.Sales.DivisionCode = SalesDb.dbo.Store.StoreCode
						   join SalesDb.dbo.Products on SalesDb.dbo.Sales.Waremark = SalesDb.dbo.Products.ProductCode
	WHERE StoreCode in (select Code from @storeCodeList) and 
		  (DateOfSale between @date1 and @date2) and
		  Waremark in (select Code from @productCodeList)
	GROUP BY 
			StoreName,
			Waremark,
			ProductName,
			DateOfSale,
			TotalCount
) t
where i <= 7
group by StoreName,
		Waremark,
		ProductName,
		SumTotalCount,
		CountI
END
GO

USE SalesDB;
GO
CREATE OR ALTER PROCEDURE Proc_InfoProductSalesAVG
(
	@storeCodeList t_int_list READONLY,
	@productCodeList t_varchar20_list READONLY,
	@date1 date,
	@date2 date
)
AS
BEGIN
SELECT Waremark,
	   ProductName, 
	   SumTotalCount,
	   case
			when CountI<7 then 0
			else avg(TotalCount)
	   end as AvgDaily
FROM
(SELECT DateOfSale,
		Waremark,
		ProductName,
		TotalCount,
		sum(TotalCount) over (partition by ProductName) as SumTotalCount,
		row_number() over (partition by ProductName order by DateOfSale desc) as i,
		count(TotalCount) over (partition by ProductName) as CountI

	FROM SalesDb.dbo.Sales join SalesDb.dbo.Store    on SalesDb.dbo.Sales.DivisionCode = SalesDb.dbo.Store.StoreCode
						   join SalesDb.dbo.Products on SalesDb.dbo.Sales.Waremark = SalesDb.dbo.Products.ProductCode
	WHERE StoreCode in (select Code from @storeCodeList) and 
		  (DateOfSale between @date1 and @date2) and
		  Waremark in (select Code from @productCodeList)
	GROUP BY 
			StoreName,
			Waremark,
			ProductName,
			DateOfSale,
			TotalCount
) t
where i <= 7
group by
		Waremark,
		ProductName,
		SumTotalCount,
		CountI
END
GO

USE SalesDB;
GO
declare @storeList as t_int_list
insert into @storeList (Code)
values (1), (3)

declare @productList as t_varchar20_list
insert into @productList (Code)
values ('ZZ000000005'), ('ZZ000000072')

exec Proc_InfoProductSalesAVG @storeList, @productList, '2024-01-16', '2024-02-04'
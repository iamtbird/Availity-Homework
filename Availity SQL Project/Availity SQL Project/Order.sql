CREATE TABLE [dbo].[Order]
(
	[OrderID] INT NOT NULL PRIMARY KEY, 
    [CustomerID] INT NULL, 
    [OrderDate] DATE NULL, 
    CONSTRAINT [FK_Order_ToTable] FOREIGN KEY ([CustomerID]) REFERENCES [Customer]([CustID])
)

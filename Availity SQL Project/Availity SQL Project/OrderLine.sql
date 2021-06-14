CREATE TABLE [dbo].[OrderLine]
(
	[OrderLineID] INT NOT NULL PRIMARY KEY, 
    [OrdID] INT NULL, 
    [ItemName] NCHAR(10) NULL, 
    [Cost] INT NULL, 
    [Quantity] INT NULL, 
    CONSTRAINT [FK_OrderLine_ToTable] FOREIGN KEY ([OrdID]) REFERENCES [Order]([OrderID])
)

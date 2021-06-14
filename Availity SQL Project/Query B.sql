SELECT c.FirstName, c.LastName, Sum(ol.Cost*ol.Quantity)
FROM Customer c
Left Outer Join "Order" o ON o.CustomerID = c.CustID
Left Outer Join OrderLine ol ON ol.OrdID = o.OrderID
WHERE o.OrderDate >'Today'-182
GROUP BY c.FirstName, C.LastName;
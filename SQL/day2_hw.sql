--1.
SELECT Count(ProductID) AS [Number Of Products]
FROM Production.Product

Select top 1 *
FROM Production.Product
--2
Select COUNT(ProductSubcategoryID) AS [Number of Products]
FROM Production.Product

--3
Select ProductSubcategoryID, COUNT(ProductID) AS CountedProduct
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL
GROUP BY ProductSubcategoryID

--4
SELECT COUNT(ProductID) AS CuntedProducts
FROM Production.Product
WHERe ProductSubcategoryID IS NULL

SELECT TOP 1 * FROM Production.ProductInventory
--5
SELECT SUM(Quantity) As TotalQuantity
FROM Production.ProductInventory

--6
SELECT ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY ProductID
HAVING SUM(Quantity) < 100

SELECT TOP 1 *
FROM Production.ProductInventory
--7
SELECT Shelf, ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY Shelf, ProductID
HAVING SUM(Quantity) < 100

--8
SELECT ProductID, AVG(Quantity) AS AVG
FROM Production.ProductInventory
WHERE LocationID = 10
GROUP BY ProductID

--9
SELECT ProductID, Shelf,  AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
GROUP BY Shelf, ProductID

--10
SELECT ProductID, Shelf,  AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
WHERE  Shelf != 'N/A'
GROUP BY Shelf, ProductID

--11
SELECT Color, Class, Count(*) AS TheCount, AVG(ListPrice) AS AvgPrice
FROM Production.Product
Where Color is NOT NULL And Class IS NOT NULL
GROUP BY Color, Class

--12
SELECT r.Name, v.Name
FROM Person.CountryRegion r INNER JOIN Person.StateProvince v ON r.CountryRegionCode = v.CountryRegionCode

--13
SELECT r.Name, v.Name
FROM Person.CountryRegion r INNER JOIN Person.StateProvince v ON r.CountryRegionCode = v.CountryRegionCode
WHERE r.Name = 'Germany' OR r.Name = 'Canada'

--14
SELECT TOP 1 * From Products
SELECT Top 1 * From [Order Details]
SELECT TOP 1 * From Orders
SELECT TOP 1 * From Region

SELECT DISTINCT d.ProductID, p.ProductName
FROM Orders o INNER JOIN [Order Details] d ON o.OrderID = d.OrderID INNER JOIN Products p ON p.ProductID = d.ProductID
WHERE o.OrderDate >= DATEADD(YEAR, -27, GETDATE())

--15
SELECT TOP 5 o.ShipPostalCode
FROM Orders o INNER JOIN [Order Details] d ON o.OrderID = d.OrderID
WHERE o.ShipPostalCode IS NOT NULL
GROUP BY o.ShipPostalCode
ORDER BY COUNT(d.ProductID) DESC

--16
SELECT TOP 5 o.ShipPostalCode
FROM Orders o INNER JOIN [Order Details] d ON o.OrderID = d.OrderID
WHERE o.ShipPostalCode IS NOT NULL AND o.OrderDate >= DATEADD(YEAR, -27, GETDATE())
GROUP BY o.ShipPostalCode
ORDER BY COUNT(d.ProductID) DESC

--17
SELECT City, COUNT(CustomerID) AS [Number Of Customer]
FROM Customers
GROUP BY City

--18
SELECT City, COUNT(CustomerID) AS [Number Of Customer]
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) >= 2

--19
SELECT TOP 1 *
FROm Orders

SELECT c.ContactName, o.OrderDate
FROM Orders o INNER JOIN Customers c ON o.CustomerID = c.CustomerID
WHERE o.OrderDate >= '1998-01-01'

--20
SELECT c.ContactName, MAX(o.OrderDate) AS [Most Recent Order]
FROM Orders o INNER JOIN Customers c ON o.CustomerID = c.CustomerID
GROUP BY c.ContactName

--21
SELECT c.ContactName, SUM(d.Quantity) AS [Total Prodcuts]
FROM Customers c INNER JOIN Orders o ON c.CustomerID = o.CustomerID INNER JOIN [Order Details] d ON d.OrderID = o.OrderID
GROUP BY c.ContactName

--22
SELECT o.CustomerID, SUM(d.Quantity) AS [Count Products]
FROM Orders o INNER JOIN [Order Details] d ON o.OrderID = d.OrderID
GROUP BY o.CustomerID
HAVING SUM(d.Quantity) >= 100

--23
SELECT  su.CompanyName AS [Supplier Company Name ], sh.CompanyName AS [Shipping Company Name]
FROM Suppliers su CROSS JOIN Shippers sh

--24
SELECT o.OrderDate, p.ProductName
FROM Orders o INNER JOIN [Order Details] d ON o.OrderID = d.OrderID INNER JOIN Products p ON d.ProductID = p.ProductID

--25
SELECT e1.FirstName + ' ' + e1.LastName as e1Name, e2.FirstName + ' ' + e2.LastName as e2Name
FROM Employees e1 INNER JOIN Employees e2 ON e1.Title = e2.Title

--26
SELECT EmployeeID,  FirstName + ' ' + LastName As ManagerName
FROM Employees
WHERE EmployeeID IN
(SELECT ReportsTo
FROM Employees
GROUP BY ReportsTo
HAVING COUNT(ReportsTo) >= 2)

--27
SELECT City, CompanyName AS NAME, ContactName, 'Supplier' AS Type
FROM Suppliers
UNION ALL
SELECT City, CompanyName AS NAME, ContactName, 'Customer' AS Type
FROM Customers



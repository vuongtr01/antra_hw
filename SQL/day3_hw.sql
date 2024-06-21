--1
SELECT DISTINCT e.City
FROM (
    SELECT City
    FROM Employees
) e
WHERE e.City IN (
    SELECT City
    FROM Customers
)

--2
    --a
SELECT DISTINCT e.City
FROM (
    SELECT City
    FROM Customers
) e
WHERE e.City NOT IN (
    SELECT City
    FROM Employees
)

    --b
SELECT DISTINCT c.city
FROM Customers c
LEFT JOIN Employees e ON c.city = e.city
WHERE e.city IS NULL;

--3.
SELECT p.ProductName, s.TotalQuantity
FROM Products p INNER JOIN
(Select ProductID, Sum(Quantity) AS TotalQuantity
FROM [Order Details]
GROUP BY ProductID) s ON p.ProductID = s.ProductID

--4.
SELECT c.City, SUM(d.Quantity) AS TotalQuantity
FROM [Order Details] d INNER JOIN Orders o ON o.OrderID = d.OrderID INNER JOIN Customers c ON o.CustomerID = c.CustomerID
GROUP BY c.City

--5
SELECT City, Count(CustomerID) AS NumberOfCustomers
FROM Customers
GROUP BY City
HAVING Count(CustomerID) >= 2

--6
SELECT c.City
FROM [Order Details] d INNER JOIN Orders o ON o.OrderID = d.OrderID INNER JOIN Customers c ON o.CustomerID = c.CustomerID
GROUP BY c.City
HAVING Count(DISTINCT d.ProductID) >= 2

--7
SELECT DISTINCT c.CustomerID
FROM Orders o INNER JOIN Customers c ON o.CustomerID = c.CustomerID
WHERE o.ShipCity != c.City

--8
With PopularProducts AS(
    SELECT TOP 5 ProductID, AVG(UnitPrice) AS AveragePrice
    FROM [Order Details]
    GROUP BY ProductID
    ORDER BY SUM(Quantity) DESC
),

ProductCityQuantity AS (
    SELECT pp.ProductId, c.City, SUM(od.Quantity) AS TotalCityQuantity
    FROM PopularProducts pp INNER JOIN [Order Details] od ON pp.ProductId = od.ProductId INNER JOIN Orders o ON od.OrderID = o.OrderID INNER JOIN Customers c ON o.CustomerID = c.CustomerID
    GROUP BY pp.ProductId, c.City
),

MaxCityPerProduct AS (
    SELECT pcq.ProductId, pcq.City, pcq.TotalCityQuantity, RANK() OVER (PARTITION BY pcq.ProductId ORDER BY pcq.TotalCityQuantity DESC) AS rn
    FROM ProductCityQuantity pcq
)
SELECT
    pp.ProductId,
    pp.AveragePrice,
    mc.City AS MostPopularCity
FROM PopularProducts pp
JOIN MaxCityPerProduct mc ON pp.ProductId = mc.ProductId
WHERE mc.rn = 1

--9
--a
SELECT DISTINCT e.City
FROM Employees e
WHERE e.City NOT IN (
    SELECT DISTINCT ShipCity
    FROM Orders
);

--b
SELECT DISTINCT e.City
FROM Employees e
LEFT JOIN Orders o ON e.City = o.ShipCity
WHERE o.OrderID IS NULL;

--10
WITH CityOrderCount AS (
    SELECT ShipCity, COUNT(OrderID) AS OrderCount
    FROM Orders
    GROUP BY ShipCity
),
CityProductQuantity AS (
    SELECT o.ShipCity, SUM(d.Quantity) AS TotalQuantity
    FROM Orders o JOIN [Order Details] d ON o.OrderID = d.OrderID
    GROUP BY o.ShipCity
),
MaxOrderCity AS (
    SELECT ShipCity
    FROM CityOrderCount
    WHERE OrderCount = (SELECT MAX(OrderCount) FROM CityOrderCount)
),
MaxQuantityCity AS (
    SELECT ShipCity
    FROM CityProductQuantity
    WHERE TotalQuantity = (SELECT MAX(TotalQuantity) FROM CityProductQuantity)
)
SELECT MOC.ShipCity
FROM MaxOrderCity MOC INNER JOIN MaxQuantityCity MQC ON MOC.ShipCity = MQC.ShipCity

--11: Using normalization to avoid duplicate data
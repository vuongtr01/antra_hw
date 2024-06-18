--1.
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product

--2.
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE NOT ListPrice = 0

--3.
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color IS NULL

--4.
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color IS NOT NULL

--5.
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color IS NOT NULL AND ListPrice > 0

--6.
SELECT Name + ' ' + Color AS "Name&Color"
FROM Production.Product
WHERE Color IS NOT NULL

--7.
SELECT Name, Color
FROM Production.Product
WHERE Name LIKE '%Crankarm' OR Name LIKE 'Chainring%'

--8.
SELECT ProductID, Name
FROM Production.Product
WHERE ProductID BETWEEN 400 AND 500

--9.
SELECT ProductID, Name, Color
FROM Production.Product
WHERE Color IN ('Black', 'Blue')

--10.
SELECT ProductID, Name
FROM Production.Product
WHERE Name LIKE 'S%'

--11.
SELECT Name, ListPrice
FROM Production.Product
WHERE Name LIKE 'Seat%' OR Name LIKE 'Short-Sleeve Classic Jersey, [L, M]'
ORDER BY Name

--12.
SELECT Name, ListPrice
FROM Production.Product
WHERE Name LIKE 'A%' OR Name LIKE 'S%'
ORDER BY Name

--13.
SELECT *
FROM Production.Product
WHERE Name LIKE '[A, P, O][^K]%'
ORDER BY Name

--14. 
SELECT DISTINCT Color
FROM Production.Product
ORDER BY Color DESC

--15. 
Select DISTINCT ProductSubcategoryID, Color
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL AND Color Is Not Null
ORDER BY ProductSubcategoryID, Color
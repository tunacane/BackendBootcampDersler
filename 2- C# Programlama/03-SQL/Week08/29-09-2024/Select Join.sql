-- Join: SQL'de tabloları ilişkili alanlar üzerinden birlşetirme işlemine denir.

-- Product ve categories tablolarının birleştirilmesini sağlayalım


-- SELECT 
--     p.ProductID AS [ÜrIdün],
--     p.ProductName AS [Ürün],
--     p.UnitPrice AS [Fiyat],
--     c.CategoryName AS [ Kategori]

-- FROM Products p JOIN Categories c ON p.CategoryID = c.CategoryID
-- --WHERE c.CategoryName = 'Beverages' 

-- t-yeni bir kategori ekleyelim

-- INSERT INTO Categories(CategoryName, Description)
-- VALUE ('Televizyon' , 'Televixyon ürünleri burda')

-- SELECT FROM Categories c RIGHT JOIN Products p ON p.CategoryID = c.CategoryID

-- Ürünleri (ProductID, ProductName, UnitPrice) supplier Company Name'leri ile birlikte listeyelim

-- SELECT p.ProductID, p.ProductName, p.UnitPrice , s.CompanyName
-- FROM Products p 
-- JOIN Suppliers s ON p.SupplierID = s.SupplierID 
-- ORDER BY CompanyName 

-- Ürünleri (ProductID, ProductName, UnitPrice) CategoryName ve supplier Company Name'leri ile birlikte listeyelim

-- SELECT p.ProductID AS [Id], 
-- p.ProductName AS [Ürün], 
-- p.UnitPrice AS [Fiyat] , 
-- s.CompanyName AS [Tedarikçi], 
-- c.CategoryName AS [Kategori]
-- FROM Products p 
-- JOIN Suppliers s ON p.SupplierID = s.SupplierID JOIN Categories c ON p.CategoryID= c.CategoryID
-- ORDER BY [CompanyName] , [CategoryName] 

-- Hangi sipraiş, hangi çalışan tarafından, hangi müşteriye gerçekleştirilmiştir?
-- OrderID, OrderDate, Employee Name, Customer Name

-- SELECT 
--     o.OrderID AS [Sipariş No],
--     o.OrderDate AS [Sipariş Tarihi],
--     e.FirstName + ' ' + e.LastName AS [Çalışan],
--     c.CompanyName AS [Müşteri]
   
-- FROM Orders o
--  JOIN Employees e ON o.EmployeeID = e.EmployeeID
--  JOIN Customers c ON o.CustomerID = c.CustomerID

-- ???? KAtegoriye göre ürün stok adedini gösterelim

-- SELECT -- HATA VAR BAK
--     c.CategoryName AS [Kategori],
--     SUM(p.UnitsInStock) AS [Stok Miktarı]
-- FROM Products p JOIN Categories c ON p.CategoryID = c.CategoryID
-- GROUP BY c.CategoryName

--??? Hangi ülkede kaö müşteri var?

-- SELECT TOP(1)
--     c.Country AS [Ülke],
--     COUNT(*) AS [Müşteri Sayısı]


-- FROM Customers c 
-- GROUP BY c.Country
-- ORDER BY [Müşteri Sayısı] DESC

-- ??????? Hangi kategoride kaç adet ürünümüz var?

-- SELECT c.CategoryName AS [Kategori],
--         COUNT(p.ProductID) AS [Adet]

-- FROM Categories c LEFT JOIN Products p ON c.CategoryID= p.CategoryID
-- GROUP BY c.CategoryName

-- SELECT c.CategoryName AS [Kategori],  hatalı oldu televizyon gelmedi ekrana bak
--         COUNT(p.ProductID) AS [Adet]

-- FROM Products p RIGHT JOIN  Categories c ON c.CategoryID= p.CategoryID
-- GROUP BY c.CategoryName

--?? Hangi ülkeye ne kadarlık kargo harcaması yapılmış??

-- SELECT 
--     o.ShipCountry AS [Ülke],
--     SUM(o.Freight) AS [Kargo harcaması]


-- FROM Orders o
-- GROUP BY o.ShipCountry

--??

-- SELECT 
--     o.ShipCountry AS [Ülke],
--     SUM(o.Freight) AS [Kargo harcaması],
--     SUM( od.UnitPrice * od.Quantity*(1 - od.Discount)) AS [Tutar]


-- FROM Orders o JOIN OrderDetails od ON o.OrderID = od.OrderID
-- GROUP BY o.ShipCountry

-- ????  Tutar kolonunda görüntülenen sayının 18.810,05 şeklinde görünmesi için ne yapılır?

-- ???? Germany'den tedarik ettiğimiz ürünlerin toplam satış tutarı

-- SELECT 

-- SUM(od.UnitPrice*od.Quantity*(1-od.Discount)) AS [Tutar]

-- FROM OrderDetails od 

-- JOIN Products p ON od.ProductID = p.ProductID
-- JOIN Suppliers s ON p.SupplierID = s.SupplierID

-- WHERE s.Country = 'Germany'

--???? Germany'den tedarik  ettiğimiz ürünlerin toplam satış tutarını kategorilere göre listeleyelim

-- SELECT 

-- c.CategoryName AS [Kategori],
-- SUM(od.UnitPrice*od.Quantity*(1-od.Discount)) AS [Tutar]

-- FROM OrderDetails od 

-- JOIN Products p ON od.ProductID = p.ProductID
-- JOIN Suppliers s ON p.SupplierID = s.SupplierID
-- JOIN Categories c ON p.CategoryID = c.CategoryID

-- WHERE s.Country = 'Germany'
-- GROUP BY c.CategoryName
-- HAVING SUM(od.UnitPrice*od.Quantity*(1-od.Discount))  > 20000
-- ORDER BY [Tutar] DESC



--??? BÖLGELERE GÖRE SATIŞ TUTARI

-- SELECT 

-- r.RegionDescription AS [Bölge],
-- FORMAT(SUM(od.UnitPrice*od.Quantity*(1-od.Discount)), 'N2', 'tr-TR') AS [TUTAR]

-- FROM OrderDetails od 
--     JOIN Orders o ON od.OrderID = o.OrderID
--         JOIN Employees e ON o.EmployeeID = e.EmployeeID
--             JOIN EmployeeTerritories et ON e.EmployeeID = et.EmployeeID
--                 JOIN Territories t ON et.TerritoryID = t.TerritoryID
--                     JOIN Region r ON t.RegionID = r.RegionID

-- GROUP BY r.RegionDescription



---??? HANGİ ÇALIŞANIN HANGİKATEGORİDEN NE KADARLIK SİPARİŞ YAPTIĞINI BULUNUZ

-- SELECT 

-- e.FirstName,
-- c.CategoryName AS [Kategori],
-- SUM(od.UnitPrice*od.Quantity*(1-od.Discount)) [Tutar]

-- FROM OrderDetails od 

-- JOIN Orders o ON od.OrderID = o.OrderID
-- JOIN Employees e ON o.EmployeeID = e.EmployeeID
-- JOIN Products p ON od.ProductID = p.ProductID
-- JOIN Categories c ON p.CategoryID = c.CategoryID

-- GROUP BY c.CategoryName, e.FirstName
-- ORDER BY e.FirstName, c.CategoryName


-- SELECT 

-- co.CompanyName,
-- c.CategoryName AS [Kategori],
-- SUM(od.UnitPrice*od.Quantity*(1-od.Discount)) [Tutar]

-- FROM OrderDetails od 

-- JOIN Orders o ON od.OrderID = o.OrderID
-- JOIN Customers co ON o.CustomerID = co.CustomerID
-- JOIN Products p ON od.ProductID = p.ProductID
-- JOIN Categories c ON p.CategoryID = c.CategoryID

-- GROUP BY c.CategoryName, co.CompanyName
-- ORDER BY co.CompanyName, c.CategoryName

--??? **1997 yılının mart ayıjnda yapılan satışları listeleyelim 
-- SELECT * FROM Orders o 
-- WHERE o.OrderDate BETWEEN '1997-3-1' AND '1997-3-31'

--?? CHAİ ÜRÜNÜNE AİT 1997 YILININ MART AYINDA YAPILAN SATIŞLARI LİSTELEYELİM

SELECT *
FROM Orders o JOIN OrderDetails od ON o.OrderID = od.OrderID
    JOIN Products p ON od.ProductID = p.ProductID
    JOIN 
















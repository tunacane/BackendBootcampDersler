--SELECT * FROM Categories
-- SELECT ProductID,ProductName,  UnitPrice, UnitsInStock FROM Products p

--SELECT 
  --  p.ProductID AS 'Ürün Id', 
 --   ProductName AS 'Ürün Adı', 
 --   UnitsInStock  [Stok Adedi], 
--UnitPrice AS 'Birim Fiyat'
--FROM Products P


-- SELECT 
--     MAX (p.UnitPrice)  AS [Maksimum Fiyat],
--     MIN (p.UnitPrice)  AS [Minimum Fiyat],
--     AVG (p.UnitPrice)  AS [Ortalama Fiyat],
--     COUNT(*) AS [Ürün SAyısı],
--     SUM(p.UnitPrice * p.UnitsInStock) AS [Toplam Değer]
-- FROM Products p

--Temel Fonksiyon

-- SELECT 
--     p.ProductName AS [Default],
--     UPPER(p.ProductName) AS [Büyük harfle başlama],
--     LOWER(p.ProductName) AS [küçük harfle başlama],
--     LOWER(REPLACE(p.ProductName, ' ', '_')) AS [Url],
--     LOWER(REPLACE(REPLACE(p.ProductName, ' ', '_'), '?', '')) AS [Url]
    
-- FROM Products p

-- SELECT * FROM Products p
-- WHERE p.UnitPrice > 40

 SELECT * FROM Products p
--  --WHERE p.UnitPrice >= 40 AND p.UnitPrice <=10
 WHERE p.UnitPrice BETWEEN 40 AND 100

--ORDER BY p.ProductName ASC-- ASC default 
--ORDER BY p.ProductName DESC
ORDER BY p.CategoryID, p.UnitPrice


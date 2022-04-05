SELECT p.ProductName, c.CategoryName
FROM ProductCategories pc 
INNER JOIN Categories c ON pc.CategoryId = c.CategoryId 
RIGHT JOIN Products p ON pc.ProductId = p.ProductId
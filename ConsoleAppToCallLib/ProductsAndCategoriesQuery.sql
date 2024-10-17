--������ ��� ������:

--������� Products:
--ProductID	ProductName
--1	Product A
--2	Product B
--3	Product C

--������� Categories:
--CategoryID	CategoryName
--1	Category X
--2	Category Y

--������� ProductCategories:
--ProductID	CategoryID
--1	1
--1	2
--2	1


SELECT p.ProductName, COALESCE(c.CategoryName, '��� ���������') AS CategoryName
FROM Products p
LEFT JOIN ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN Categories c ON pc.CategoryID = c.CategoryID;
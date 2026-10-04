--1 viết câu lệnh SQL lấy ra tên của tất cả các sản phẩm 
select [ProductName]
from [dbo].[Products];

--2 lấy ra tên sản phẩm , giá bán trên mỗi đơn vị, 
-- số lượng sản phẩm trên đơn vị 
select [ProductName], [UnitPrice], [QuantityPerUnit]
from [dbo].[Products];

--3 lấy ra tên của khách hàng và tên của khách hàng đó
select [ContactName], [Country]
from [dbo].[Customers];

-- lấy ra tên quốc gia khác nhau từ bảng Customers
select distinct Country --DISTINCT : Lấy dữ liệu k trùng lặp
from dbo.Customers;

-- lấy ra mã bưu điện khác nhau của Supplies
select distinct PostalCode
from Suppliers;

-- Lấy ra họ và cách gọi danh hiệu KHÁC NHAU của bảng Employees
select distinct [ShipVia]
from [dbo].[Orders];

-- lấy ra các đơn hàng có mã khách hàng không trùng lặp, chỉ lấy 5 dữ liệu đầu tiên 
select  distinct top 5 [CustomerID]
from Orders;

--CÁCH ĐẶT TÊN CHO THAY THẾ CHO BẢNG VÀ CỘT 


--Lấy CompanyName = Công ty, PotalCode = Mã bưu điện
select top 5 CompanyName as [Công ty], PostalCode as N'Mã bưu điện'
from Customers;

-- Lấy ra 15 dòng của tất cả các cột của bảng Order, đặt tên thay thế là O
select top 15 *
from Orders as O;

-- Tìm Min, Max
select min(UnitPrice) as GiaMin, max(UnitPrice) as GiaMax
from Products;

-- Lấy ra ngày đặt hàng gần đây nhất ( tức là ngày lớn nhất)
select max(orderdate) as N'Ngày mua hàng gần nhất'
from Orders;

-- Đếm số lượng khách hàng có trong bảng
select count(*) as SoKhachHang
from Customers;

-- Tính tổng tiền của các đơn đặt hàng, ORDER BY : Sắp xếp ASC tăng dần, DESC giảm dần 
select top 10 Freight as TongTien
from Orders
order by [Freight] desc;

select OrderID
from Orders
order by OrderDate desc;


-- CÁC PHÉP TOÁN TRONG SQL 

-- Tính số lượng sản phẩm còn lại trong kho (UnitslnStock) sau khi bán hết 
-- sản phẩm đã được đặt hàng (UnitsOnOrder)
-- Stockremaining = UnitslnStock - UnitsOnOrder

select [ProductID],
	   [ProductName],
	   UnitsInStock - UnitsOnOrder as  Stockremaining
from [dbo].[Products];

select top 10
		[UnitPrice] * [Quantity] AS TongTien
from [dbo].[Order Details];

Đã xem xong video 11






















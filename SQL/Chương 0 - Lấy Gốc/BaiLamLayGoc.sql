-- 1. In ra danh sách các sách chỉ lấy (MaSach,TenSach) do Nhà xuất bản Giáo Dục xuất bản.
-- join 2 bảng tSách và tNhaXuatBan ( Chung MaNXB)

select s.MaSach, s.TenSach
from tSach s
join tNhaXuatBan nxb on s.MaNXB = nxb.MaNXB
where nxb.MaNXB = N'Nhà sản xuất Giáo Dục';

-- 2. In ra danh sách các sách có tên bắt đầu là “Ngày”.
-- Tên dùng bảng tSach, bắt đầu chuỗi thì ta dùng LIKE, kí tự % dùng để kí hiệu các kí tự khác
select *
from tSach s
where TenSach like N'Ngày%';

-- 3. In ra danh sách các sách (MaSach,TenSach) do Nhà xuất bản Giáo Dục có giá bán từ 100.000 đến 150.000
select s.MaSach, s.TenSach
from tSach s
join tNhaXuatBan nxb on s.MaNXB = nxb.MaNXB
where nxb.MaNXB = N'Nhà xuất bản Giáo Dục'
and s.DonGiaBan between 100000 and 150000;


-- 4. In ra danh sách các các sách (MaSach,TenSach) do Nhà xuất bản Giáo Dục 
-- hoặc Nhà Xuất Bản Trẻ sản xuất có giá từ 90.000 đến 140.000.
select s.MaSach, s.TenSach
from tSach s
join tNhaXuatBan nxb on s.MaNXB = nxb.MaNXB
where (nxb.MaNXB = N'Nhà xuất bản Giáo Dục' or nxb.MaNXB = N'Nhà Xuất Bản Trẻ')
and s.DonGiaBan between 90000 and 10000;


-- 5. In ra các số hóa đơn, trị giá hóa đơn(tổng tiền) bán ra trong ngày 1/1/2014 và ngày 31/12/2014.

-- tHoaDonBan: Chứa số hóa đơn (SoHDB) và ngày bán (NgayBan) để thực hiện điều kiện lọc ngày.  
-- tChiTietHDB: Chứa SoHDB, MaSach, và số lượng bán (SLBan).
-- tSach: Chứa MaSach và đơn giá bán (DonGiaBan).

select hdb.SoHDB, sum(ct.SLBan * s.DonGiaBan) as TriGia
from tHoaDonBan hdb
join tChiTietHDB ct on hdb.SoHDB = ct.SoHDB
join tSach s on ct.MaSach = s.MaSach
where hdb.NgayBan in ('2014-01-01', '2014-12-31')
group by hdb.SoHDB;











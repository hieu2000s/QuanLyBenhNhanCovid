CREATE DATABASE QuanLyCovid
GO

USE QuanLyCovid
GO

CREATE SCHEMA Covid
GO

CREATE TABLE Covid.KhuVucDieuTri
(
	IDKhuVucDieuTri INT PRIMARY KEY IDENTITY(1,1)
	,TenKhuVucDieuTri NVARCHAR(50) NOT NULL UNIQUE
	,Mota NVARCHAR(100)
)
GO
select TenKhuVucDieuTri from Covid.KhuVucDieuTri
CREATE TABLE Covid.NguoiDieuTri
(
	IDNguoiDieuTri INT PRIMARY KEY 
	,TenNguoiDieuTri NVARCHAR(50) NOT NULL
	,GioiTinh BIT DEFAULT 0
	,NgaySinh DATETIME NOT NULL
	,CMND INT NOT NULL UNIQUE
	,SDT INT UNIQUE
	,DiaChi NVARCHAR(100)

)
GO

CREATE TABLE Covid.PhongDieuTri
(
	 IDPhongDieuTri INT PRIMARY KEY IDENTITY(1,1)
	,TenPhongDieuTri NVARCHAR(50) NOT NULL UNIQUE
	,IDKhuVucDieuTri INT
	,SoLuongGiuong INT

	,FOREIGN KEY (IDKhuVucDieuTri)  REFERENCES Covid.KhuVucDieuTri(IDKhuVucDieuTri)
)
GO

CREATE TABLE Covid.BenhNhan
(
	IDBenhNhan INT PRIMARY KEY 
	,TenBenhNhan NVARCHAR(50) NOT NULL
	,GioiTinh BIT DEFAULT 0
	,NgaySinh DATE NOT NULL
	,CMND INT UNIQUE
	,DiaChi NVARCHAR(100)
	,TinhTrangSucKhoe NVARCHAR NOT NULL DEFAULT 0
	,Email NVARCHAR(20) UNIQUE
	,SDT INT
	,TenNguoiGiamHo NVARCHAR(50) DEFAULT N'Không có'
	,IDPhongDieuTri INT
	,FOREIGN KEY (IDPhongDieuTri) REFERENCES Covid.PhongDieuTri(IDPhongDieuTri)
)
GO



CREATE TABLE Covid.Account
(
	MaTaiKhoan INT NOT NULL	PRIMARY KEY IDENTITY(1,1)
	,TenDangNhap NVARCHAR(50) NOT NULL 
	,MatKhau NVARCHAR(50) NOT NULL
	,Quyen BIT DEFAULT 0
	,TenNguoiNhap NVARCHAR(50) NOT NULL
	,CMND INT NOT NULL UNIQUE
	,Sdt INT
)
GO
INSERT Covid.Account(TenDangNhap,MatKhau, Quyen,TenNguoiNhap,CMND,Sdt) VALUES
( 'hungdeptrai', 123456, 1,'Lê Nguyên Hưng', 123456, 096)

Select * from Covid.Account
delete from Covid.Account

CREATE TABLE Covid.LichSuDieuTri
(
	 IDLichSuDieuTri INT PRIMARY KEY IDENTITY(1,1)
	,IDBenhNhan INT
	,IDNguoiDieuTri INT
	,ThoiGian DATETIME
	,LichSuDieuTri NVARCHAR(500) NOT NULL
	,FOREIGN KEY (IDBenhNhan) REFERENCES Covid.BenhNhan(IDBenhNhan)
	,FOREIGN KEY (IDNguoiDieuTri) REFERENCES Covid.NguoiDieuTri(IDNguoiDieuTri)

)
GO
select * from Covid.KhuVucDieuTri
INSERT Covid.KhuVucDieuTri(TenKhuVucDieuTri, Mota) VALUES
(N'Khu vực có bệnh nền nặng',N'Dành cho người có bệnh nền nặng') --id la 1
,(N'Khu vực có bệnh nền nhẹ',N'Dành cho người có bệnh nền nhẹ') --id la 2
,(N'Khu vực không có bệnh nền',N'Dành cho người không có bệnh nền') --id la 3
,(N'Khu vực dành cho người có bệnh nhẹ',N'Dành cho những người có bệnh nhẹ') --id la 4

INSERT Covid.NguoiDieuTri(IDNguoiDieuTri, TenNguoiDieuTri, GioiTinh,NgaySinh ,CMND,SDT,DiaChi) VALUES
(1,N'Ngô Minh Hiếu', 1, CONVERT(DATETIME,'22/09/2000',103), 125911714,0376020239,N'Bắc Ninh') --id là 1
,(2,N'Lê Nguyên Hưng', 1, CONVERT(DATETIME,'26/09/2000',103), 123456789,09126,N'Bắc Ninh') --id là 2
select * from Covid.NguoiDieuTri

INSERT Covid.PhongDieuTri(TenPhongDieuTri, IDKhuVucDieuTri,SoLuongGiuong) VALUES
('Phong 101', 1, 10) --id la 1
,('Phong 202', 2, 10) --id la 2
,('Phong 303', 3, 10) --id la 3
,('Phong 401', 4, 10) --id la 4

DELETE FROM Covid.BenhNhan
DELETE FROM Covid.LichSuDieuTri
INSERT Covid.BenhNhan(IDBenhNhan,TenBenhNhan ,GioiTinh, NgaySinh,CMND, DiaChi, TinhTrangSucKhoe, Email,SDT,TenNguoiGiamHo,IDPhongDieuTri) VALUES
(1,N'Nguyễn Hữu Tú',1, CONVERT(DATETIME,12/03/1999,103),1,N'Hà Nội',1,'75222@gmail.com',09832602,N'Hưng',1) --id là 1

INSERT Covid.BenhNhan(IDBenhNhan,TenBenhNhan ,GioiTinh, NgaySinh,CMND, DiaChi, TinhTrangSucKhoe, Email,SDT,TenNguoiGiamHo,IDPhongDieuTri) VALUES
(2,N'Lê Nhật Tân',1, CONVERT(DATETIME,12/03/2001,103) ,22223418,N'Hà Nội',1,'7322@gmail.com',09834602,N'Hăng',1)

INSERT Covid.BenhNhan(IDBenhNhan,TenBenhNhan ,GioiTinh, NgaySinh,CMND, DiaChi, TinhTrangSucKhoe, Email,SDT,TenNguoiGiamHo,IDPhongDieuTri) VALUES
(6,N'Lê Nhật thần',1, CONVERT(DATETIME,12/03/2001,103) ,222223418,N'Hà Nội',1,'73222@gmail.com',098342602,N'Hăng',4)


USE QuanLyCovid
GO

select * from Covid.BenhNhan
select * from Covid.NguoiDieuTri
select * from Covid.PhongDieuTri




INSERT Covid.LichSuDieuTri(IDBenhNhan,IDNguoiDieuTri,ThoiGian,LichSuDieuTri) VALUES
(1,1,CONVERT(DATETIME,15/03/2021,103),N'Tiêm 1 mũi vaxin, Bình thường')
,(2,2,CONVERT(DATETIME,12/11/2022,103),N'Tiêm 1 mũi vaxin, Sốc phản vệ')

select count(IDBenhNhan) from Covid.BenhNhan where IDBenhNhan =15

delete  from Covid.LichSuDieuTri
delete  from Covid.NguoiDieuTri
delete  from Covid.PhongDieuTri
delete  from Covid.KhuVucDieuTri


DROP TABLE Covid.KhuVucDieuTri
DROP TABLE Covid.Account
DROP TABLE Covid.NguoiDieuTri
DROP TABLE Covid.PhongDieuTri
DROP TABLE Covid.BenhNhan
DROP TABLE Covid.LichSuDieuTri

DROP DATABASE QuanLyCovid
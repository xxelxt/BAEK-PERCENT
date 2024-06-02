CREATE DATABASE BAEK_PERCENT;

USE BAEK_PERCENT;

------------------
-- Bảng LinhVuc --
------------------

CREATE TABLE LinhVuc (
    MaLV varchar(10) PRIMARY KEY NOT NULL,
    TenLV nvarchar(30) NOT NULL
);

CREATE TRIGGER trg_LinhVuc_Insert
ON LinhVuc
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @nextId int;

    -- Tìm giá trị lớn nhất hiện có trong MaLV
    SELECT @nextId = ISNULL(MAX(CAST(SUBSTRING(MaLV, 3, LEN(MaLV) - 2) AS int)), 0) + 1
    FROM LinhVuc;

    -- Chèn dữ liệu vào bảng LinhVuc
    INSERT INTO LinhVuc (MaLV, TenLV)
    SELECT 'LV' + RIGHT('000' + CAST(@nextId + ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) - 1 AS varchar(3)), 3), TenLV
    FROM inserted;

    -- Hiển thị kết quả
    SELECT *
    FROM LinhVuc;
END;

-----------------
-- Bảng TacGia --
-----------------

CREATE TABLE TacGia (
    MaTG varchar(10) PRIMARY KEY NOT NULL,
    TenTG nvarchar(50) NOT NULL
);

CREATE TRIGGER trg_TacGia_Insert
ON TacGia
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @nextId int;

    -- Tìm giá trị lớn nhất hiện có trong MaTG
    SELECT @nextId = ISNULL(MAX(CAST(SUBSTRING(MaTG, 3, LEN(MaTG) - 2) AS int)), 0) + 1
    FROM TacGia;

    -- Chèn dữ liệu vào bảng TacGia với MaTG được tự động tạo
    INSERT INTO TacGia (MaTG, TenTG)
    SELECT 'TG' + RIGHT('000' + CAST(@nextId + ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) - 1 AS varchar(3)), 3), TenTG
    FROM inserted;

    -- Hiển thị kết quả
    SELECT *
    FROM TacGia;
END;

------------------
-- Bảng NgonNgu --
------------------

CREATE TABLE NgonNgu (
    MaNN varchar(10) PRIMARY KEY NOT NULL,
    TenNN nvarchar(20) NOT NULL
);

CREATE TRIGGER trg_NgonNgu_Insert
ON NgonNgu
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @nextId int;

    -- Tìm giá trị lớn nhất hiện có trong MaNN
    SELECT @nextId = ISNULL(MAX(CAST(SUBSTRING(MaNN, 3, LEN(MaNN) - 2) AS int)), 0) + 1
    FROM NgonNgu;

    -- Chèn dữ liệu vào bảng NgonNgu với MaNN được tự động tạo
    INSERT INTO NgonNgu (MaNN, TenNN)
    SELECT 'NN' + RIGHT('000' + CAST(@nextId + ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) - 1 AS varchar(3)), 3), TenNN
    FROM inserted;

    -- Hiển thị kết quả
    SELECT *
    FROM NgonNgu;
END;

-------------------
-- Bảng LoaiSach --
-------------------

CREATE TABLE LoaiSach (
    MaLoai varchar(10) PRIMARY KEY NOT NULL,
    TenLoai nvarchar(20) NOT NULL
);

CREATE TRIGGER trg_LoaiSach_Insert
ON LoaiSach
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @nextId int;

    -- Tìm giá trị lớn nhất hiện có trong MaLoai
    SELECT @nextId = ISNULL(MAX(CAST(SUBSTRING(MaLoai, 3, LEN(MaLoai) - 2) AS int)), 0) + 1
    FROM LoaiSach;

    -- Chèn dữ liệu vào bảng LoaiSach với MaLoai được tự động tạo
    INSERT INTO LoaiSach (MaLoai, TenLoai)
    SELECT 'LS' + RIGHT('000' + CAST(@nextId + ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) - 1 AS varchar(3)), 3), TenLoai
    FROM inserted;

    -- Hiển thị kết quả
    SELECT *
    FROM LoaiSach;
END;

-----------------
-- Bảng ViPham --
-----------------

CREATE TABLE ViPham (
    MaVP varchar(10) PRIMARY KEY NOT NULL,
    TenVP nvarchar(20) NOT NULL
);

CREATE TRIGGER trg_ViPham_Insert
ON ViPham
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @nextId int;

    -- Tìm giá trị lớn nhất hiện có trong MaVP
    SELECT @nextId = ISNULL(MAX(CAST(SUBSTRING(MaVP, 3, LEN(MaVP) - 2) AS int)), 0) + 1
    FROM ViPham;

    -- Chèn dữ liệu vào bảng ViPham với MaVP được tự động tạo
    INSERT INTO ViPham (MaVP, TenVP)
    SELECT 'VP' + RIGHT('000' + CAST(@nextId + ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) - 1 AS varchar(3)), 3), TenVP
    FROM inserted;

    -- Hiển thị kết quả
    SELECT *
    FROM ViPham;
END;

--------------------
-- Bảng KhachHang --
--------------------

CREATE TABLE KhachHang (
    MaKH varchar(10) PRIMARY KEY NOT NULL,
    TenKH nvarchar(50) NOT NULL,
    NgaySinh date NOT NULL,
    GioiTinh bit NOT NULL,
    DiaChi nvarchar(100) NOT NULL,
    SDT varchar(11) NOT NULL
);

CREATE TRIGGER trg_KhachHang_Insert
ON KhachHang
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @nextId int;

    -- Tìm giá trị lớn nhất hiện có trong MaKH
    SELECT @nextId = ISNULL(MAX(CAST(SUBSTRING(MaKH, 3, LEN(MaKH) - 2) AS int)), 0) + 1
    FROM KhachHang;

    -- Chèn dữ liệu vào bảng KhachHang với MaKH được tự động tạo
    INSERT INTO KhachHang (MaKH, TenKH, NgaySinh, GioiTinh, DiaChi, SDT)
    SELECT 'KH' + RIGHT('0000000' + CAST(@nextId + ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) - 1 AS varchar(7)), 7), TenKH, NgaySinh, GioiTinh, DiaChi, SDT
    FROM inserted;

    -- Hiển thị kết quả
    SELECT *
    FROM KhachHang;
END;

-------------------
-- Bảng TaiKhoan --
-------------------

CREATE TABLE TaiKhoan (
	TenDangNhap varchar(30) PRIMARY KEY NOT NULL,
	MatKhau varchar(30) NOT NULL,
	Quyen int NOT NULL
);

-------------------
-- Bảng NhanVien --
-------------------

CREATE TABLE NhanVien (
    MaNV varchar(10) PRIMARY KEY NOT NULL,
    TenNV nvarchar(50) NOT NULL,
	TenDangNhap varchar(30),
    NgaySinh date NOT NULL,
    GioiTinh bit NOT NULL,
    DiaChi nvarchar(100) NOT NULL,
    SDT varchar(11) NOT NULL,
    Luong int NOT NULL,
	FOREIGN KEY (TenDangNhap) REFERENCES TaiKhoan(TenDangNhap)
);

CREATE TRIGGER trg_NhanVien_Insert
ON NhanVien
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @nextId int;

    -- Tìm giá trị lớn nhất hiện có trong MaNV
    SELECT @nextId = ISNULL(MAX(CAST(SUBSTRING(MaNV, 3, LEN(MaNV) - 2) AS int)), 0) + 1
    FROM NhanVien;

    -- Chèn dữ liệu vào bảng NhanVien với MaNV được tự động tạo
    INSERT INTO NhanVien (MaNV, TenNV, TenDangNhap, NgaySinh, GioiTinh, DiaChi, SDT, Luong)
    SELECT 'NV' + RIGHT('0000000' + CAST(@nextId + ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) - 1 AS varchar(7)), 7), 
           TenNV, TenDangNhap, NgaySinh, GioiTinh, DiaChi, SDT, Luong
    FROM inserted;

    -- Hiển thị kết quả
    SELECT *
    FROM NhanVien;
END;

---------------
-- Bảng Sach --
---------------

CREATE TABLE Sach (
    MaSach varchar(10) PRIMARY KEY NOT NULL,
    TenSach nvarchar(100) NOT NULL,
    MaLoai varchar(10),
    MaLV varchar(10),
    MaTG varchar(10),
    MaNN varchar(10),
    SoTrang int NOT NULL,
    GiaSach int NOT NULL,
    DonGiaThue int NOT NULL,
    SoLuong int NOT NULL,
    Anh text,
    GhiChu nvarchar(100),
    FOREIGN KEY (MaLoai) REFERENCES LoaiSach(MaLoai),
    FOREIGN KEY (MaLV) REFERENCES LinhVuc(MaLV),
    FOREIGN KEY (MaTG) REFERENCES TacGia(MaTG),
    FOREIGN KEY (MaNN) REFERENCES NgonNgu(MaNN)
);

CREATE TRIGGER trg_Sach_Insert
ON Sach
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @nextId int;

    -- Tìm giá trị lớn nhất hiện có trong MaSach
    SELECT @nextId = ISNULL(MAX(CAST(SUBSTRING(MaSach, 3, LEN(MaSach) - 2) AS int)), 0) + 1
    FROM Sach;

    -- Chèn dữ liệu vào bảng Sach với MaSach được tự động tạo
    INSERT INTO Sach (MaSach, TenSach, MaLoai, MaLV, MaTG, MaNN, SoTrang, GiaSach, DonGiaThue, SoLuong, Anh, GhiChu)
    SELECT 'ST' + RIGHT('0000000' + CAST(@nextId + ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) - 1 AS varchar(7)), 7), 
           TenSach, MaLoai, MaLV, MaTG, MaNN, SoTrang, GiaSach, DonGiaThue, SoLuong, Anh, GhiChu
    FROM inserted;

    -- Hiển thị kết quả
    SELECT *
    FROM Sach;
END;

----------------------
-- Bảng thuê và trả --
----------------------

CREATE TABLE ThueSach (
    MaThue varchar(50) PRIMARY KEY NOT NULL,
    MaKH varchar(10),
    MaNV varchar(10),
    NgayThue date NOT NULL,
	NgayTra date NOT NULL,
    TienDatCoc int NOT NULL,
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);

CREATE TABLE CTThueSach (
    MaThue varchar(50) NOT NULL,
    MaSach varchar(10) NOT NULL,
	GiaThue int NOT NULL,
    DaTra bit NOT NULL,
    FOREIGN KEY (MaThue) REFERENCES ThueSach(MaThue),
    FOREIGN KEY (MaSach) REFERENCES Sach(MaSach),
    PRIMARY KEY (MaThue, MaSach)
);

CREATE TABLE TraSach (
    MaTra varchar(50) PRIMARY KEY NOT NULL,
    MaThue varchar(50),
    MaNV varchar(10),
    NgayTra date NOT NULL,
    TongTien float NOT NULL,
    FOREIGN KEY (MaThue) REFERENCES ThueSach(MaThue),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);

CREATE TABLE CTTraSach (
    MaTra varchar(50) NOT NULL,
    MaSach varchar(10) NOT NULL,
    MaVP varchar(10) NOT NULL,
    ThanhTien int NOT NULL,
    FOREIGN KEY (MaTra) REFERENCES TraSach(MaTra),
    FOREIGN KEY (MaSach) REFERENCES Sach(MaSach),
	FOREIGN KEY (MaVP) REFERENCES ViPham(MaVP),
    PRIMARY KEY (MaTra, MaSach)
);
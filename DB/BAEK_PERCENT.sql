CREATE DATABASE BAEK_PERCENT;

USE BAEK_PERCENT;

DROP TABLE CTTraSach;
DROP TABLE CTThueSach;
DROP TABLE TraSach;
DROP TABLE ThueSach;

DROP TABLE KhachHang;
DROP TABLE Sach;
DROP TABLE NhanVien;
DROP TABLE TaiKhoan;
DROP TABLE NgonNgu;

DROP TABLE ViPham;
DROP TABLE LoaiSach;
DROP TABLE LinhVuc;
DROP TABLE TacGia;

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

INSERT INTO LinhVuc (TenLV)
VALUES (N'Văn học hiện đại'),
       (N'Trinh thám - Kinh dị');

-- INSERT INTO LinhVuc (MaLV, TenLV)
-- VALUES ('LV001', N'Văn học hiện đại'),
--        ('LV002', N'Trinh thám - Kinh dị');

-- SELECT * FROM LinhVuc;

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

INSERT INTO TacGia (TenTG)
VALUES (N'Haruki Murakami'),
       (N'Stephen King'),
       (N'Vũ Trọng Phụng'),
       (N'Trương Hàn Tự'),
       (N'Sohn Won Pyung');

-- INSERT INTO TacGia (MaTG, TenTG)
-- VALUES ('TG001', N'Haruki Murakami'),
--        ('TG002', N'Stephen King'),
--        ('TG003', N'Vũ Trọng Phụng'),
--        ('TG004', N'Trương Hàn Tự'),
--        ('TG005', N'Sohn Won Pyung');

-- SELECT * FROM TacGia;

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

INSERT INTO NgonNgu (TenNN)
VALUES (N'Tiếng Việt'),
       (N'Tiếng Anh'),
       (N'Tiếng Nhật'),
       (N'Tiếng Hàn'),
       (N'Tiếng Trung');

-- INSERT INTO NgonNgu (MaNN, TenNN)
-- VALUES ('NN001', N'Tiếng Việt'),
--        ('NN002', N'Tiếng Anh'),
--        ('NN003', N'Tiếng Nhật'),
--        ('NN004', N'Tiếng Hàn'),
--        ('NN005', N'Tiếng Trung');

-- SELECT * FROM NgonNgu;

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

INSERT INTO LoaiSach (TenLoai)
VALUES (N'Sách mới'),
       (N'Sách cũ'),
       (N'Sách bán chạy'),
       (N'Sách ngưng tái bản');

-- INSERT INTO LoaiSach (MaLoai, TenLoai)
-- VALUES ('LS001', N'Sách mới'),
--        ('LS002', N'Sách cũ'),
--        ('LS003', N'Sách bán chạy'),
--        ('LS004', N'Sách ngưng tái bản');

-- SELECT * FROM LoaiSach;

-- CREATE TABLE CaLam (
--     MaCa varchar(10) PRIMARY KEY NOT NULL,
--     TenCa nvarchar(20) NOT NULL
-- );

-- CREATE TRIGGER trg_CaLam_Insert
-- ON CaLam
-- INSTEAD OF INSERT
-- AS
-- BEGIN
--     DECLARE @nextId int;

--     -- Tìm giá trị lớn nhất hiện có trong MaCa
--     SELECT @nextId = ISNULL(MAX(CAST(SUBSTRING(MaCa, 2, LEN(MaCa) - 1) AS int)), 0) + 1
--     FROM CaLam;

--     -- Chèn dữ liệu vào bảng CaLam với MaCa được tự động tạo
--     INSERT INTO CaLam (MaCa, TenCa)
--     SELECT 'C' + RIGHT('000' + CAST(@nextId + ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS varchar(3)), 3), TenCa
--     FROM inserted;

--     -- Hiển thị kết quả
--     SELECT *
--     FROM CaLam;
-- END;

-- INSERT INTO CaLam (TenCa)
-- VALUES (N'Ca sáng'),
--        (N'Ca chiều'),
--        (N'Ca tối');

-- INSERT INTO CaLam (MaCa, TenCa)
-- VALUES ('C001', N'Ca sáng'),
--        ('C002', N'Ca chiều'),
--        ('C003', N'Ca tối');

-- SELECT * FROM CaLam;

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

INSERT INTO ViPham (TenVP)
VALUES (N'Không vi phạm'),
       (N'Quá hạn trả'),
       (N'Mất sách'),
       (N'Hỏng sách');

-- INSERT INTO ViPham (MaVP, TenVP)
-- VALUES ('VP000', N'Không vi phạm'),
--        ('VP001', N'Quá hạn trả'),
--        ('VP002', N'Mất sách'),
--        ('VP003', N'Hỏng sách');

-- SELECT * FROM ViPham;

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

INSERT INTO KhachHang (TenKH, NgaySinh, GioiTinh, DiaChi, SDT)
VALUES (N'Khách hàng số 1', '1999-01-01', 1, N'Chùa Bộc', 0987654321),
       (N'Khách hàng số 2', '1998-02-02', 0, N'Tây Sơn', 0987623451),
       (N'Khách hàng số 3', '1997-03-03', 1, N'Thái Hà', 0987634521),
       (N'Khách hàng số 4', '1996-04-04', 0, N'Phạm Ngọc Thạch', 0987651234),
       (N'Khách hàng số 5', '1995-05-05', 1, N'Nguyễn Lương Bằng', 0987612345);

-- INSERT INTO KhachHang (MaKH, TenKH, NgaySinh, GioiTinh, DiaChi)
-- VALUES ('KH0000001', N'Khách hàng số 1', '1999-01-01', 1, N'Chùa Bộc'),
--        ('KH0000002', N'Khách hàng số 2', '1998-02-02', 0, N'Tây Sơn'),
--        ('KH0000003', N'Khách hàng số 3', '1997-03-03', 1, N'Thái Hà'),
--        ('KH0000004', N'Khách hàng số 4', '1996-04-04', 0, N'Phạm Ngọc Thạch'),
--        ('KH0000005', N'Khách hàng số 5', '1995-05-05', 1, N'Nguyễn Lương Bằng');

-- SELECT * FROM KhachHang;

CREATE TABLE TaiKhoan (
	TenDangNhap varchar(30) PRIMARY KEY NOT NULL,
	MatKhau varchar(30) NOT NULL,
	Quyen int NOT NULL
)

INSERT INTO TaiKhoan (TenDangNhap, MatKhau, Quyen)
VALUES ('admin', 'admin', 1),
       ('user', 'user', 0);

SELECT * FROM TaiKhoan;

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

INSERT INTO NhanVien (TenNV, TenDangNhap, NgaySinh, GioiTinh, DiaChi, SDT, Luong)
VALUES (N'Nhân viên số 1', 'admin', '1999-01-01', 1, N'Chùa Bộc', '0987654321', 7000000),
       (N'Nhân viên số 2', 'user', '1998-02-02', 0, N'Tây Sơn', '0987654322', 7000000),
       (N'Nhân viên số 3', 'user', '1997-03-03', 1, N'Thái Hà', '0987654323', 8000000),
       (N'Nhân viên số 4', 'user', '1996-04-04', 0, N'Phạm Ngọc Thạch', '0987654324', 8000000),
       (N'Nhân viên số 5', 'user', '1995-05-05', 1, N'Nguyễn Lương Bằng', '0987654325', 6000000);

-- INSERT INTO NhanVien (MaNV, TenNV, TenDangNhap, MaCa, NgaySinh, GioiTinh, DiaChi, SDT, Luong)
-- VALUES ('NV0000001', N'Nhân viên số 1', 'admin', 'C001', '1999-01-01', 1, N'Chùa Bộc', '0987654321', 7000000),
--        ('NV0000002', N'Nhân viên số 2', 'user', 'C002', '1998-02-02', 0, N'Tây Sơn', '0987654322', 7000000),
--        ('NV0000003', N'Nhân viên số 3', 'user', 'C003', '1997-03-03', 1, N'Thái Hà', '0987654323', 8000000),
--        ('NV0000004', N'Nhân viên số 4', 'user', 'C001', '1996-04-04', 0, N'Phạm Ngọc Thạch', '0987654324', 8000000),
--        ('NV0000005', N'Nhân viên số 5', 'user', 'C002', '1995-05-05', 1, N'Nguyễn Lương Bằng', '0987654325', 6000000);

-- SELECT * FROM NhanVien;

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

INSERT INTO Sach (TenSach, MaLoai, MaLV, MaTG, MaNN, SoTrang, GiaSach, DonGiaThue, SoLuong, GhiChu)
VALUES (N'Ngôi thứ nhất số ít', 'LS001', 'LV001', 'TG001', 'NN003', 203, 108000, 5000, 5, N'Ghi chú 1'),
       (N'Thị kiến (The Shining)', 'LS002', 'LV001', 'TG002', 'NN002', 592, 269000, 10000, 5, N'Ghi chú 2'),
       (N'Số đỏ', 'LS002', 'LV001', 'TG003', 'NN001', 624, 86000, 5000, 5, N'Ghi chú 3'),
       (N'Một hoạ sĩ chết rồi thành danh trở lại', 'LS002', 'LV002', 'TG004', 'NN005', 388, 165000, 8000, 3, N'Ghi chú 4'),
       (N'Hạnh nhân', 'LS004', 'LV001', 'TG005', 'NN004', 243, 95000, 10000, 1, N'Ghi chú 5');

-- INSERT INTO Sach (MaSach, TenSach, MaLoai, MaLV, MaTG, MaNN, SoTrang, GiaSach, DonGiaThue, SoLuong, GhiChu)
-- VALUES ('ST0000001', N'Ngôi thứ nhất số ít', 'LS001', 'LV001', 'TG001', 'NN003', 203, 108000, 10000, 5, N'Ghi chú 1'),
--        ('ST0000002', N'Thị kiến (The Shining)', 'LS002', 'LV001', 'TG002', 'NN002', 592, 269000, 20000, 5, N'Ghi chú 2'),
--        ('ST0000003', N'Số đỏ', 'LS002', 'LV001', 'TG003', 'NN001', 624, 86000, 10000, 5, N'Ghi chú 3'),
--        ('ST0000004', N'Một hoạ sĩ chết rồi thành danh trở lại', 'LS002', 'LV002', 'TG004', 'NN005', 388, 165000, 15000, 3, N'Ghi chú 4'),
--        ('ST0000005', N'Hạnh nhân', 'LS004', 'LV001', 'TG005', 'NN004', 243, 95000, 20000, 1, N'Ghi chú 5');

-- SELECT * FROM Sach;

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

INSERT INTO ThueSach (MaThue, MaKH, MaNV, NgayThue, NgayTra, TienDatCoc)
VALUES ('TH240515154556', 'KH0000001', 'NV0000001', '2024-04-01', '2024-04-08', 20000),
       ('TH240515160212', 'KH0000002', 'NV0000002', '2024-04-02', '2024-04-09', 20000),
       ('TH240515172332', 'KH0000003', 'NV0000001', '2024-04-03', '2024-04-10', 20000),
       ('TH240515185132', 'KH0000004', 'NV0000002', '2024-04-04', '2024-04-11', 20000);

SELECT * FROM ThueSach;

INSERT INTO CTThueSach (MaThue, MaSach, GiaThue, DaTra)
VALUES ('TH240515154556', 'ST0000001', 35000, 1),
       ('TH240515160212', 'ST0000002', 70000, 1),
       ('TH240515160212', 'ST0000003', 56000, 1),
       ('TH240515172332', 'ST0000002', 70000, 1),
       ('TH240515185132', 'ST0000001', 35000, 0);

SELECT * FROM CTThueSach;

INSERT INTO TraSach (MaTra, MaThue, MaNV, NgayTra, TongTien)
VALUES ('TR240515194556', 'TH240515154556', 'NV0000001', '2024-04-08', 35000),
       ('TR240515195631', 'TH240515160212', 'NV0000002', '2024-04-09', 126000),
       ('TR240515200433', 'TH240515172332', 'NV0000001', '2024-04-10', 70000),
       ('TR240515200708', 'TH240515185132', 'NV0000002', '2024-04-14', 65000);

SELECT * FROM TraSach;

INSERT INTO CTTraSach (MaTra, MaSach, MaVP, ThanhTien)
VALUES ('TR240515200708', 'ST0000001', 'VP001', 30000);

SELECT * FROM CTTraSach;
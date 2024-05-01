## BAEK PERCENT [.NET PROJECT]

<details>
<summary>Thông tin chung</summary>

## Nhóm 3

- 📋 **Đề tài**: Quản lý cửa hàng cho thuê sách truyện

- 💻 **Lớp học phần**: 232IS25A01

### ✊ Danh sách thành viên

| Họ và tên           | Mã sinh viên | 🔗 Link to GitHub profile                   |
| ------------------- | ------------ | -----------------------------------------   |
| Phạm Ngọc Nghiệp 🌟 | 24A4042603   | [xxelxt](https://github.com/xxelxt)         |
| Nguyễn Hoàng Anh    | 24A4040572   | [hna-gnaoh](https://github.com/hna-gnaoh)   |
| Phạm Bảo Anh        | 24A4042424   | [PhamBaoAnh](https://github.com/PhamBaoAnh) |
| Hà Gia Bảo          | 24A4042425   | [tuilaBao03](https://github.com/tuilaBao03) |
| Ngô Văn Minh        | 24A4042598   | [NMinh19](https://github.com/NMinh19)       |

</details>

### 📘 Giới thiệu tên gọi

> ***백 (baek): one hundred (100)***

> ***baek percent: 100%***

**BAEK PERCENT** là nơi bạn có thể tìm thấy mọi cuốn sách mà bạn có thể nghĩ ra trên đời này và thuê chúng với mức giá phải chăng.

### 🚀 Tiện ích sử dụng

- MaterialSkin2: Giao diện Material Design của Google cho .NET WinForm

## Tạo file kết nối với database

### 1. Tạo file cấu hình App.config

Click chuột phải vào tên ứng dụng trong Visual Studio (không phải Solution) -> Add -> New Item -> Application Configuration File

```
└📁 BAEK-PERCENT
  └📁 BAEK-PERCENT
    └📁 Class
    └📁 Forms
    └📁 Resources
    └📄 App.config
    ...
```

### 2. Sửa đổi file App.config

```
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <connectionStrings>
    <add name="BAEKconnection" connectionString="" />
  </connectionStrings>
</configuration>
```

Với connectionString lấy từ Connection String kết nối vào database của bạn trong SQL Server.

using System;
using System.Data;
using System.Data.SqlClient;

using BAEK_PERCENT.Database;

namespace BAEK_PERCENT.DAL
{
    internal class NhanVienDAL
    {
        private static readonly string TableName = "NhanVien";

        public static DataTable GetAllNhanVien()
        {
            string sql = @"SELECT * FROM NhanVien";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetNhanVienBySearch(string search)
        {
            string sql = @"SELECT * FROM NhanVien WHERE MaNV LIKE '%" + search + "%' OR TenNV LIKE N'%" + search + "%'";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static string InsertEmptyNhanVien()
        {
            string sqlInsert = "INSERT INTO " + TableName + " (TenNV, NgaySinh, GioiTinh, DiaChi, SDT, Luong) VALUES ('null', '01/01/2000', 0, 'null', 'null', -1)";

            DatabaseLayer.RunSql(sqlInsert);
            return GetLastMaNV();
        }

        public static string GetLastMaNV()
        {
            string sql = "SELECT TOP 1 MaNV FROM " + TableName + " ORDER BY MaNV DESC";

            DataTable dt = DatabaseLayer.GetDataToTable(sql);

            if (dt.Rows.Count == 0)
            {
                return "";
            }

            return dt.Rows[0]["MaNV"].ToString();
        }

        public static void DeleteEmptyNhanVien(string maNV)
        {
            string sqlCheck = "SELECT TenNV FROM " + TableName + " WHERE MaNV = @MaNV";
            SqlParameter[] param = { new SqlParameter("@MaNV", maNV) };

            DataTable dt = DatabaseLayer.GetDataToTable(sqlCheck, param);

            if (dt.Rows.Count > 0)
            {
                string tenNV = dt.Rows[0]["TenNV"].ToString();

                if (tenNV != "null")
                {
                    return;
                }
            }

            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaNV = @MaNV";
            SqlParameter[] deleteParams = { new SqlParameter("@MaNV", maNV) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static void UpdateNhanVien(string maNV, string tenNV, string tenDangNhap, DateTime ngaySinh, bool gioiTinh, string diaChi, string SDT, int luong)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET TenNV = @TenNV, TenDangNhap = @TenDangNhap, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DiaChi = @DiaChi, SDT = @SDT, Luong = @Luong WHERE MaNV = @MaNV";
            SqlParameter[] updateParams = {
                new SqlParameter("@TenNV", tenNV),
                new SqlParameter("@MaNV", maNV),
                new SqlParameter("@TenDangNhap", tenDangNhap),
                new SqlParameter("@NgaySinh", ngaySinh),
                new SqlParameter("@GioiTinh", gioiTinh),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@SDT", SDT),
                new SqlParameter("@Luong", luong)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void DeleteNhanVien(string maNV)
        {
            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaNV = @MaNV";
            SqlParameter[] deleteParams = { new SqlParameter("@MaNV", maNV) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        public static string GetTenNhanVienByMa(string maNV)
        {
            string query = "SELECT TenNV FROM NhanVien WHERE MaNV = @MaNV";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@MaNV", maNV)
            };

            DataTable dt = DatabaseLayer.GetDataToTable(query, parameters);
            
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["TenNV"].ToString();
            }

            return string.Empty;
        }
    }
}

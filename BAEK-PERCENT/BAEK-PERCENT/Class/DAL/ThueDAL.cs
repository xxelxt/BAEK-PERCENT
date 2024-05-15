using BAEK_PERCENT.Database;
using System;
using System.Data;
using System.Data.SqlClient;

namespace BAEK_PERCENT.DAL
{
    internal class ThueDAL
    {
        private static readonly string TableName = "ThueSach";
        private static readonly string TableCTName = "CTThueSach";

        public static DataTable GetAllThue()
        {
            string sql = $"SELECT T.MaThue, T.MaKH, KH.TenKH, T.MaNV, NV.TenNV, T.NgayThue, T.TienDatCoc FROM {TableName} T INNER JOIN KhachHang KH ON T.MaKH = KH.MaKH INNER JOIN NhanVien NV ON T.MaNV = NV.MaNV";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetCTThue(string maThue)
        {
            string sql = $"SELECT CT.MaSach, S.TenSach, S.DonGiaThue, CT.DaTra FROM {TableCTName} CT INNER JOIN Sach S ON CT.MaSach = S.MaSach WHERE CT.MaThue = @MaThue";
            SqlParameter[] param = { new SqlParameter("@MaThue", maThue) };

            return DatabaseLayer.GetDataToTable(sql, param);
        }
    }
}

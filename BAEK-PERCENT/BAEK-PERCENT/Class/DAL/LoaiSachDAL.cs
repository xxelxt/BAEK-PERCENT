using BAEK_PERCENT.Database;
using System.Data;
using System.Data.SqlClient;

namespace BAEK_PERCENT.DAL
{
    internal class LoaiSachDAL
    {
        private static readonly string TableName = "LoaiSach";

        public static DataTable GetAllLoaiSach()
        {
            string sql = @"SELECT * FROM LoaiSach";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetLoaiSachBySearch(string search)
        {
            string sql = @"SELECT * FROM LoaiSach WHERE MaLoai LIKE '%" + search + "%' OR TenLoai LIKE N'%" + search + "%'";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static string InsertEmptyLoaiSach()
        {
            string sqlInsert = "INSERT INTO " + TableName + " (TenLoai) VALUES ('null')";

            DatabaseLayer.RunSql(sqlInsert);
            return GetLastMaLoai();
        }

        public static string GetLastMaLoai()
        {
            string sql = "SELECT TOP 1 MaLoai FROM " + TableName + " ORDER BY MaLoai DESC";

            DataTable dt = DatabaseLayer.GetDataToTable(sql);

            if (dt.Rows.Count == 0)
            {
                return "";
            }

            return dt.Rows[0]["MaLoai"].ToString();
        }

        public static void DeleteEmptyLoaiSach(string maLoai)
        {
            string sqlCheck = "SELECT TenLoai FROM " + TableName + " WHERE MaLoai = @MaLoai";
            SqlParameter[] param = { new SqlParameter("@MaLoai", maLoai) };

            DataTable dt = DatabaseLayer.GetDataToTable(sqlCheck, param);

            if (dt.Rows.Count > 0)
            {
                string tenLoai = dt.Rows[0]["TenLoai"].ToString();

                if (tenLoai != "null")
                {
                    return;
                }
            }

            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaLoai = @MaLoai";
            SqlParameter[] deleteParams = { new SqlParameter("@MaLoai", maLoai) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        /*
        public static void InsertLoaiSach(string maLoai, string tenLoai)
        {
            string sqlCheckKey = "SELECT MaLoai FROM " + TableName + " WHERE MaLoai = @MaLoai";
            SqlParameter[] checkKeyParams = { new SqlParameter("@MaLoai", maLoai) };

            if (DatabaseLayer.CheckKey(sqlCheckKey, checkKeyParams))
            {
                throw new Exception("Mã loại sách đã tồn tại");
            }

            string sqlInsert = "INSERT INTO " + TableName + " (MaLoai, TenLoai) VALUES (@MaLoai, @TenLoai)";
            SqlParameter[] insertParams = {
                new SqlParameter("@MaLoai", maLoai),
                new SqlParameter("@TenLoai", tenLoai)
            };

            DatabaseLayer.RunSql(sqlInsert, insertParams);
        }
        */

        public static void UpdateLoaiSach(string maLoai, string tenLoai)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET TenLoai = @TenLoai WHERE MaLoai = @MaLoai";
            SqlParameter[] updateParams = {
                new SqlParameter("@TenLoai", tenLoai),
                new SqlParameter("@MaLoai", maLoai)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void DeleteLoaiSach(string maLoai)
        {
            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaLoai = @MaLoai";
            SqlParameter[] deleteParams = { new SqlParameter("@MaLoai", maLoai) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }
    }
}

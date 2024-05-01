using BAEK_PERCENT.Database;
using System.Data;
using System.Data.SqlClient;

namespace BAEK_PERCENT.DAL
{
    internal class ViPhamDAL
    {
        private static readonly string TableName = "ViPham";

        public static DataTable GetAllViPham()
        {
            string sql = @"SELECT * FROM ViPham";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static DataTable GetViPhamBySearch(string search)
        {
            string sql = @"SELECT * FROM ViPham WHERE MaVP LIKE '%" + search + "%' OR TenVP LIKE N'%" + search + "%'";

            return DatabaseLayer.GetDataToTable(sql);
        }

        public static string InsertEmptyViPham()
        {
            string sqlInsert = "INSERT INTO " + TableName + " (TenVP) VALUES ('null')";

            DatabaseLayer.RunSql(sqlInsert);
            return GetLastMaVP();
        }

        public static string GetLastMaVP()
        {
            string sql = "SELECT TOP 1 MaVP FROM " + TableName + " ORDER BY MaVP DESC";

            DataTable dt = DatabaseLayer.GetDataToTable(sql);

            if (dt.Rows.Count == 0)
            {
                return "";
            }

            return dt.Rows[0]["MaVP"].ToString();
        }

        public static void DeleteEmptyViPham(string maVP)
        {
            string sqlCheck = "SELECT TenVP FROM " + TableName + " WHERE MaVP = @MaVP";
            SqlParameter[] param = { new SqlParameter("@MaVP", maVP) };

            DataTable dt = DatabaseLayer.GetDataToTable(sqlCheck, param);

            if (dt.Rows.Count > 0)
            {
                string tenVP = dt.Rows[0]["TenVP"].ToString();

                if (tenVP != "null")
                {
                    return;
                }
            }

            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaVP = @MaVP";
            SqlParameter[] deleteParams = { new SqlParameter("@MaVP", maVP) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }

        /*
        public static void InsertViPham(string maVP, string tenVP)
        {
            string sqlCheckKey = "SELECT MaVP FROM " + TableName + " WHERE MaVP = @MaVP";
            SqlParameter[] checkKeyParams = { new SqlParameter("@MaVP", maVP) };

            if (DatabaseLayer.CheckKey(sqlCheckKey, checkKeyParams))
            {
                throw new Exception("Mã vi phạm đã tồn tại");
            }

            string sqlInsert = "INSERT INTO " + TableName + " (MaVP, TenVP) VALUES (@MaVP, @TenVP)";
            SqlParameter[] insertParams = {
                new SqlParameter("@MaVP", maVP),
                new SqlParameter("@TenVP", tenVP)
            };

            DatabaseLayer.RunSql(sqlInsert, insertParams);
        }
        */

        public static void UpdateViPham(string maVP, string tenVP)
        {
            string sqlUpdate = "UPDATE " + TableName + " SET TenVP = @TenVP WHERE MaVP = @MaVP";
            SqlParameter[] updateParams = {
                new SqlParameter("@TenVP", tenVP),
                new SqlParameter("@MaVP", maVP)
            };

            DatabaseLayer.RunSql(sqlUpdate, updateParams);
        }

        public static void DeleteViPham(string maVP)
        {
            string sqlDelete = "DELETE FROM " + TableName + " WHERE MaVP = @MaVP";
            SqlParameter[] deleteParams = { new SqlParameter("@MaVP", maVP) };

            DatabaseLayer.RunSqlDel(sqlDelete, deleteParams);
        }
    }
}

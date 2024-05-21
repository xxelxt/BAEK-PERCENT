using System;
using System.Data;
using System.Data.SqlClient;

using BAEK_PERCENT.Database;

namespace BAEK_PERCENT.DAL
{
    internal class BaoCaoDAL
    {
        public static DataTable GetBaoCaoLoaiSachYeuThich(DateTime ngayBD, DateTime ngayKT)
        {
            string sql = @"SELECT DISTINCT L.TenLV, COUNT(*) AS SoLuongMuon 
                    FROM CTThueSach CT 
                    INNER JOIN ThueSach T ON T.MaThue = CT.MaThue 
                    INNER JOIN Sach S ON CT.MaSach = S.MaSach 
                    INNER JOIN LinhVuc L ON L.MaLV = S.MaLV 
                    WHERE T.NgayThue BETWEEN @NgayBD AND @NgayKT 
                    GROUP BY L.TenLV 
                    ORDER BY SoLuongMuon DESC;";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@NgayBD", ngayBD),
                new SqlParameter("@NgayKT", ngayKT)
            };

            return DatabaseLayer.GetDataToTable(sql, sqlParameters);
        }

        public static DataTable GetBaoCaoSachYeuThich(DateTime ngayBD, DateTime ngayKT)
        {
            string sql = @"SELECT DISTINCT S.TenSach, COUNT(*) AS SoLuongMuon 
                    FROM CTThueSach CT 
                    INNER JOIN ThueSach T ON T.MaThue = CT.MaThue 
                    INNER JOIN Sach S ON CT.MaSach = S.MaSach 
                    WHERE T.NgayThue BETWEEN @NgayBD AND @NgayKT 
                    GROUP BY S.TenSach 
                    ORDER BY SoLuongMuon DESC;";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@NgayBD", ngayBD),
                new SqlParameter("@NgayKT", ngayKT)
            };

            return DatabaseLayer.GetDataToTable(sql, sqlParameters);
        }

        public static DataTable GetBaoCaoSachMatHong(DateTime ngayBD, DateTime ngayKT)
        {
            string sql = @"SELECT DISTINCT S.TenSach, VP.TenVP, COUNT(*) AS SoLuongSach
                    FROM CTTraSach CT
                    INNER JOIN TraSach T ON T.MaTra = CT.MaTra
                    INNER JOIN Sach S ON CT.MaSach = S.MaSach
                    INNER JOIN ViPham VP ON VP.MaVP = CT.MaVP
                    WHERE T.NgayTra BETWEEN @NgayBD AND @NgayKT AND VP.MaVP IN ('VP002', 'VP003')
                    GROUP BY S.TenSach, VP.TenVP
                    ORDER BY SoLuongSach DESC;";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@NgayBD", ngayBD),
                new SqlParameter("@NgayKT", ngayKT)
            };

            return DatabaseLayer.GetDataToTable(sql, sqlParameters);
        }

        public static DataTable GetDoanhThuTheoThang(DateTime ngayBD, DateTime ngayKT)
        {
            string sql = @"WITH AllMonths AS (
                    SELECT
                        YEAR(@NgayBD) AS Year,
                        MONTH(@NgayBD) AS Month
                    UNION ALL
                    SELECT
                        YEAR(DATEADD(MONTH, 1, DATEFROMPARTS(Year, Month, 1))) AS Year,
                        MONTH(DATEADD(MONTH, 1, DATEFROMPARTS(Year, Month, 1))) AS Month
                    FROM AllMonths
                    WHERE DATEADD(MONTH, 1, DATEFROMPARTS(Year, Month, 1)) <= @NgayKT
                ),
                MonthlyRevenue AS (
                    SELECT
                        YEAR(T.NgayThue) AS Year,
                        MONTH(T.NgayThue) AS Month,
                        COALESCE(SUM(T.TienDatCoc), 0) AS Revenue
                    FROM ThueSach T
                    LEFT JOIN TraSach R ON T.MaThue = R.MaThue
                    WHERE R.MaThue IS NULL
                    AND T.NgayThue BETWEEN @NgayBD AND @NgayKT
                    GROUP BY YEAR(T.NgayThue), MONTH(T.NgayThue)
                    UNION ALL
                    SELECT
                        YEAR(R.NgayTra) AS Year,
                        MONTH(R.NgayTra) AS Month,
                        COALESCE(SUM(R.TongTien), 0) AS Revenue
                    FROM TraSach R
                    INNER JOIN ThueSach T ON R.MaThue = T.MaThue
                    WHERE T.NgayThue BETWEEN @NgayBD AND @NgayKT
                    AND R.NgayTra BETWEEN @NgayBD AND @NgayKT
                    GROUP BY YEAR(R.NgayTra), MONTH(R.NgayTra)
                )

                SELECT
                    AM.Year,
                    AM.Month,
                    COALESCE(SUM(MR.Revenue), 0) AS MonthlyRevenue
                FROM AllMonths AM
                LEFT JOIN MonthlyRevenue MR ON AM.Year = MR.Year AND AM.Month = MR.Month
                GROUP BY AM.Year, AM.Month
                ORDER BY AM.Year, AM.Month;";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@NgayBD", ngayBD),
                new SqlParameter("@NgayKT", ngayKT)
            };

            return DatabaseLayer.GetDataToTable(sql, sqlParameters);
        }

        public static DataTable GetDoanhThuTheoTuan(DateTime ngayBD, DateTime ngayKT)
        {
            string sql = @"WITH WeeklyRevenue AS ( 
                SELECT 
                    YEAR(DateTable.WeekStart) AS Year, 
                    DATEPART(WEEK, DateTable.WeekStart) AS WeekNumber, 
                    CONCAT(CONVERT(VARCHAR(10), DateTable.WeekStart, 23), ' - ', CONVERT(VARCHAR(10), DateTable.WeekEnd, 23)) AS Week, 
                    COALESCE(SUM(MR.Revenue), 0) AS Revenue 
                FROM ( 
                    SELECT 
                        DATEADD(WEEK, DATEDIFF(WEEK, 0, @NgayBD) + number, 0) AS WeekStart, 
                        DATEADD(DAY, 6, DATEADD(WEEK, DATEDIFF(WEEK, 0, @NgayBD) + number, 0)) AS WeekEnd 
                    FROM master..spt_values 
                    WHERE type = 'P' AND number BETWEEN 0 AND DATEDIFF(WEEK, @NgayBD, @NgayKT) 
                ) AS DateTable 
                LEFT JOIN ( 
                    SELECT 
                        YEAR(T.NgayThue) AS Year, 
                        DATEPART(WEEK, T.NgayThue) AS Week, 
                        COALESCE(SUM(T.TienDatCoc), 0) AS Revenue 
                    FROM ThueSach T 
                    LEFT JOIN TraSach R ON T.MaThue = R.MaThue 
                    WHERE R.MaThue IS NULL 
                    AND T.NgayThue BETWEEN @NgayBD AND @NgayKT 
                    GROUP BY YEAR(T.NgayThue), DATEPART(WEEK, T.NgayThue) 
                    UNION ALL 
                    SELECT 
                        YEAR(R.NgayTra) AS Year, 
                        DATEPART(WEEK, R.NgayTra) AS Week, 
                        COALESCE(SUM(R.TongTien), 0) AS Revenue 
                    FROM TraSach R 
                    INNER JOIN ThueSach T ON R.MaThue = T.MaThue 
                    WHERE T.NgayThue BETWEEN @NgayBD AND @NgayKT 
                    AND R.NgayTra BETWEEN @NgayBD AND @NgayKT 
                    GROUP BY YEAR(R.NgayTra), DATEPART(WEEK, R.NgayTra) 
                ) AS MR ON YEAR(DateTable.WeekStart) = MR.Year AND DateTable.WeekStart <= @NgayKT AND DateTable.WeekEnd >= @NgayBD AND MR.Week = DATEPART(WEEK, DateTable.WeekStart) 
                GROUP BY YEAR(DateTable.WeekStart), DATEPART(WEEK, DateTable.WeekStart), CONCAT(CONVERT(VARCHAR(10), DateTable.WeekStart, 23), ' - ', CONVERT(VARCHAR(10), DateTable.WeekEnd, 23)) 
            ) 
            SELECT 
                Year, 
                WeekNumber, 
                Week, 
                SUM(Revenue) AS WeeklyRevenue 
            FROM WeeklyRevenue 
            WHERE WeekNumber BETWEEN DATEPART(WEEK, @NgayBD) AND DATEPART(WEEK, @NgayKT) 

            GROUP BY Year, WeekNumber, Week 
            ORDER BY Year, WeekNumber;";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@NgayBD", ngayBD),
                new SqlParameter("@NgayKT", ngayKT)
            };

            return DatabaseLayer.GetDataToTable(sql, sqlParameters);
        }
    }
}
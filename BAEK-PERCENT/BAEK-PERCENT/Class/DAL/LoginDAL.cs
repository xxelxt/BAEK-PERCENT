using BAEK_PERCENT.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BAEK_PERCENT.Class.Types;

namespace BAEK_PERCENT.DAL
{
    internal class LoginDAL
    {
        // UserRole? means it's a Nullable<UserRole>
        public static UserRole? TryLogin(string username, string password)
        {
            string sqlCheckKey = "SELECT * FROM TaiKhoan WHERE TenDangNhap = @username AND MatKhau = @password";
            SqlParameter[] checkKeyParams = { 
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
            };

            DataTable dt = DatabaseLayer.GetDataToTable(sqlCheckKey, checkKeyParams);

            if (dt.Rows.Count == 1)
            {
                return dt.Rows[0]["Quyen"].Equals(1) ? UserRole.Admin : UserRole.User;
            }
            else
            {
                return null;
            };
        }
    }
}

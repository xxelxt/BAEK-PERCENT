using System;
using System.Data;
using System.IO;

using Microsoft.Office.Interop.Excel;

namespace BAEK_PERCENT.Class
{
    public static class ExcelHelper
    {
        public static void CreateBillThue(System.Data.DataTable tblThongTinThue, System.Data.DataTable tblThongTinCTThue)
        {
            Application exApp = new Application();
            Workbook exBook;
            Worksheet exSheet;
            Range exRange;

            exBook = exApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            exSheet = (Worksheet)exBook.Worksheets[1];
            exSheet.Columns["B"].ColumnWidth = 13;

            // Định dạng tiêu đề và thông tin chung của hóa đơn
            exRange = exSheet.Range["A2:F2"];
            exRange.Merge();
            exRange.Font.Size = 12;
            exRange.Font.Bold = true;
            exRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            exRange.VerticalAlignment = XlVAlign.xlVAlignCenter;
            exRange.Value = "BAEK PERCENT";

            exRange = exSheet.Range["A3:F3"];
            exRange.Merge();
            exRange.Font.Size = 11;
            exRange.Font.Italic = true;
            exRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            exRange.VerticalAlignment = XlVAlign.xlVAlignCenter;
            exRange.Value = "Số 12 Chùa Bộc, Đống Đa, Hà Nội";

            exRange = exSheet.Range["A4:F4"];
            exRange.Merge();
            exRange.Font.Size = 11;
            exRange.Font.Italic = true;
            exRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            exRange.VerticalAlignment = XlVAlign.xlVAlignCenter;
            exRange.Value = "Điện thoại: 024 3852 1305";

            exRange = exSheet.Range["A6:F7"];
            exRange.Merge();
            exRange.Font.Size = 16;
            exRange.Font.Bold = true;
            exRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            exRange.VerticalAlignment = XlVAlign.xlVAlignCenter;
            exRange.Value = "HOÁ ĐƠN THUÊ SÁCH";

            if (tblThongTinThue.Rows.Count > 0)
            {
                exRange = exSheet.Range["A9:F9"];
                exRange.Merge();
                exRange.Font.Size = 11;
                //exRange.Font.Bold = true;
                exRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                exRange.Value = $"Mã thuê: {tblThongTinThue.Rows[0]["MaThue"]}";

                exRange = exSheet.Range["A10:F10"];
                exRange.Merge();
                exRange.Font.Size = 11;
                //exRange.Font.Bold = true;
                exRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                exRange.Value = $"Nhân viên: {tblThongTinThue.Rows[0]["TenNV"]}";

                exRange = exSheet.Range["A12:F12"];
                exRange.Merge();
                exRange.Font.Size = 11;
                //exRange.Font.Bold = true;
                exRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                exRange.Value = $"Khách hàng: {tblThongTinThue.Rows[0]["TenKH"]}";

                exRange = exSheet.Range["A13:F13"];
                exRange.Merge();
                exRange.Font.Size = 11;
                //exRange.Font.Bold = true;
                exRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                exRange.Value = $"Địa chỉ: {tblThongTinThue.Rows[0]["DiaChi"]}";

                exRange = exSheet.Range["A14:F14"];
                exRange.Merge();
                exRange.Font.Size = 11;
                //exRange.Font.Bold = true;
                exRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                exRange.Value = $"Điện thoại: {tblThongTinThue.Rows[0]["SDT"]}";

                exRange = exSheet.Range["A15:F15"];
                exRange.Merge();
                exRange.Font.Size = 11;
                //exRange.Font.Bold = true;
                exRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                exRange.Value = $"Ngày thuê: {Convert.ToDateTime(tblThongTinThue.Rows[0]["NgayThue"]).ToString("dd/MM/yyyy")}";

                exRange = exSheet.Range["A16:F16"];
                exRange.Merge();
                exRange.Font.Size = 11;
                //exRange.Font.Bold = true;
                exRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                exRange.Value = $"Ngày trả: {Convert.ToDateTime(tblThongTinThue.Rows[0]["NgayTra"]).ToString("dd/MM/yyyy")}";
            }

            // Định dạng bảng thông tin chi tiết hàng hóa
            exRange = exSheet.Range["A18:F18"];
            exRange.Merge();
            exRange.Font.Size = 12;
            exRange.Font.Bold = true;
            exRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            exRange.Value = "Thông tin chi tiết hoá đơn";

            exSheet.Cells[19, 1] = "STT";
            exSheet.Cells[19, 1].Font.Bold = true;

            exSheet.Cells[19, 2] = "Mã sách";
            exSheet.Cells[19, 2].Font.Bold = true;

            exRange = exSheet.Range["C19:E19"];
            exRange.Merge();
            exRange.Value = "Tên sách";
            exRange.Font.Bold = true;

            exSheet.Cells[19, 6] = "Giá thuê";
            exSheet.Cells[19, 6].Font.Bold = true;

            int rowIndex = 20;
            int stt = 1;
            foreach (DataRow row in tblThongTinCTThue.Rows)
            {
                exSheet.Cells[rowIndex, 1] = stt++;
                exSheet.Cells[rowIndex, 2] = row["MaSach"];

                exRange = exSheet.Range[$"C{rowIndex}:E{rowIndex}"];
                exRange.Merge();
                exRange.Value = row["TenSach"];
                exSheet.Cells[rowIndex, 6] = row["GiaThue"];
                rowIndex++;
            }

            if (tblThongTinThue.Rows.Count > 0)
            {
                exRange = exSheet.Range[$"D{rowIndex + 1}:F{rowIndex + 1}"];
                exRange.Merge();
                exRange.Font.Size = 12;
                exRange.Font.Bold = true;
                exRange.HorizontalAlignment = XlHAlign.xlHAlignRight;
                exRange.Value = "Tổng tiền: " + tblThongTinThue.Rows[0]["TongTien"];

                exRange = exSheet.Range[$"D{rowIndex + 2}:F{rowIndex + 2}"];
                exRange.Merge();
                exRange.Font.Size = 12;
                exRange.Font.Bold = true;
                exRange.HorizontalAlignment = XlHAlign.xlHAlignRight;
                exRange.Value = "Tiền đặt cọc: " + tblThongTinThue.Rows[0]["TienDatCoc"];

                exRange = exSheet.Range[$"A{rowIndex + 4}:F{rowIndex + 4}"];
                exRange.Merge();
                exRange.Font.Size = 11;
                exRange.Font.Italic = true;
                exRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                exRange.Value = $"Bằng chữ: {Functions.ChuyenSoSangChu(tblThongTinThue.Rows[0]["TongTien"].ToString())}";
            }

            exSheet.Rows[$"1:{rowIndex + 4}"].RowHeight = 16.5;

            exApp.Visible = true;

            // Lưu file Excel
            string filePath = $"E:\\rkive\\6\\.NET\\BAEK\\Excel\\BillThue\\{tblThongTinThue.Rows[0]["MaThue"]}.xlsx"; // Đường dẫn lưu file

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            
            exBook.SaveAs(filePath); // Lưu file Excel
            exApp.Visible = true; // Hiển thị file Excel

            // Giải phóng tài nguyên COM
            ReleaseObject(exSheet);
            ReleaseObject(exBook);
            ReleaseObject(exApp);
        }

        public static void CreateBillTra(System.Data.DataTable tblThongTinTra, System.Data.DataTable tblThongTinCTTra)
        {
            Application exApp = new Application();
            Workbook exBook;
            Worksheet exSheet;
            Range exRange;

            exBook = exApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            exSheet = (Worksheet)exBook.Worksheets[1];
            exSheet.Columns["B"].ColumnWidth = 13;

            // Định dạng tiêu đề và thông tin chung của hóa đơn
            exRange = exSheet.Range["A2:F2"];
            exRange.Merge();
            exRange.Font.Size = 12;
            exRange.Font.Bold = true;
            exRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            exRange.VerticalAlignment = XlVAlign.xlVAlignCenter;
            exRange.Value = "BAEK PERCENT";

            exRange = exSheet.Range["A3:F3"];
            exRange.Merge();
            exRange.Font.Size = 11;
            exRange.Font.Italic = true;
            exRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            exRange.VerticalAlignment = XlVAlign.xlVAlignCenter;
            exRange.Value = "Số 12 Chùa Bộc, Đống Đa, Hà Nội";

            exRange = exSheet.Range["A4:F4"];
            exRange.Merge();
            exRange.Font.Size = 11;
            exRange.Font.Italic = true;
            exRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            exRange.VerticalAlignment = XlVAlign.xlVAlignCenter;
            exRange.Value = "Điện thoại: 024 3852 1305";

            exRange = exSheet.Range["A6:F7"];
            exRange.Merge();
            exRange.Font.Size = 16;
            exRange.Font.Bold = true;
            exRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            exRange.VerticalAlignment = XlVAlign.xlVAlignCenter;
            exRange.Value = "HOÁ ĐƠN TRẢ SÁCH";

            if (tblThongTinTra.Rows.Count > 0)
            {
                exRange = exSheet.Range["A9:F9"];
                exRange.Merge();
                exRange.Font.Size = 11;
                //exRange.Font.Bold = true;
                exRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                exRange.Value = $"Mã trả: {tblThongTinTra.Rows[0]["MaTra"]}";

                exRange = exSheet.Range["A10:F10"];
                exRange.Merge();
                exRange.Font.Size = 11;
                //exRange.Font.Bold = true;
                exRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                exRange.Value = $"Mã thuê: {tblThongTinTra.Rows[0]["MaThue"]}";

                exRange = exSheet.Range["A11:F11"];
                exRange.Merge();
                exRange.Font.Size = 11;
                //exRange.Font.Bold = true;
                exRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                exRange.Value = $"Nhân viên: {tblThongTinTra.Rows[0]["TenNV"]}";

                exRange = exSheet.Range["A13:F13"];
                exRange.Merge();
                exRange.Font.Size = 11;
                //exRange.Font.Bold = true;
                exRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                exRange.Value = $"Khách hàng: {tblThongTinTra.Rows[0]["TenKH"]}";

                exRange = exSheet.Range["A14:F14"];
                exRange.Merge();
                exRange.Font.Size = 11;
                //exRange.Font.Bold = true;
                exRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                exRange.Value = $"Địa chỉ: {tblThongTinTra.Rows[0]["DiaChi"]}";

                exRange = exSheet.Range["A15:F15"];
                exRange.Merge();
                exRange.Font.Size = 11;
                //exRange.Font.Bold = true;
                exRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                exRange.Value = $"Điện thoại: {tblThongTinTra.Rows[0]["SDT"]}";

                exRange = exSheet.Range["A16:F16"];
                exRange.Merge();
                exRange.Font.Size = 11;
                //exRange.Font.Bold = true;
                exRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                exRange.Value = $"Ngày thuê: {Convert.ToDateTime(tblThongTinTra.Rows[0]["NgayThue"]).ToString("dd/MM/yyyy")}";

                exRange = exSheet.Range["A17:F17"];
                exRange.Merge();
                exRange.Font.Size = 11;
                //exRange.Font.Bold = true;
                exRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                exRange.Value = $"Ngày trả: {Convert.ToDateTime(tblThongTinTra.Rows[0]["NgayTra"]).ToString("dd/MM/yyyy")}";

                exRange = exSheet.Range["A18:F18"];
                exRange.Merge();
                exRange.Font.Size = 11;
                //exRange.Font.Bold = true;
                exRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                exRange.Value = $"Ngày thực tế: {Convert.ToDateTime(tblThongTinTra.Rows[0]["NgayThucTe"]).ToString("dd/MM/yyyy")}";
            }

            // Định dạng bảng thông tin chi tiết hàng hóa
            exRange = exSheet.Range["A20:F20"];
            exRange.Merge();
            exRange.Font.Size = 12;
            exRange.Font.Bold = true;
            exRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            exRange.Value = "Thông tin chi tiết phạt do vi phạm";

            exSheet.Cells[21, 1] = "STT";
            exSheet.Cells[21, 1].Font.Bold = true;

            exSheet.Cells[21, 2] = "Mã sách";
            exSheet.Cells[21, 2].Font.Bold = true;

            exRange = exSheet.Range["C21:D21"];
            exRange.Merge();
            exRange.Value = "Tên sách";
            exRange.Font.Bold = true;

            exSheet.Cells[21, 5] = "Vi phạm";
            exSheet.Cells[21, 5].Font.Bold = true;

            exSheet.Cells[21, 6] = "Thành tiền";
            exSheet.Cells[21, 6].Font.Bold = true;

            int rowIndex = 22;
            int stt = 1;
            foreach (DataRow row in tblThongTinCTTra.Rows)
            {
                exSheet.Cells[rowIndex, 1] = stt++;
                exSheet.Cells[rowIndex, 2] = row["MaSach"];

                exRange = exSheet.Range[$"C{rowIndex}:D{rowIndex}"];
                exRange.Merge();
                exRange.Value = row["TenSach"];
                exSheet.Cells[rowIndex, 5] = row["TenVP"];
                exSheet.Cells[rowIndex, 6] = row["ThanhTien"];
                rowIndex++;
            }

            if (tblThongTinTra.Rows.Count > 0)
            {
                exRange = exSheet.Range[$"D{rowIndex + 1}:F{rowIndex + 1}"];
                exRange.Merge();
                exRange.Font.Size = 12;
                exRange.Font.Bold = true;
                exRange.HorizontalAlignment = XlHAlign.xlHAlignRight;
                exRange.Value = "Tiền thuê: " + tblThongTinTra.Rows[0]["TienThue"];

                exRange = exSheet.Range[$"D{rowIndex + 2}:F{rowIndex + 2}"];
                exRange.Merge();
                exRange.Font.Size = 12;
                exRange.Font.Bold = true;
                exRange.HorizontalAlignment = XlHAlign.xlHAlignRight;
                exRange.Value = "Tiền phạt: " + tblThongTinTra.Rows[0]["TienPhat"];

                exRange = exSheet.Range[$"D{rowIndex + 3}:F{rowIndex + 3}"];
                exRange.Merge();
                exRange.Font.Size = 12;
                exRange.Font.Bold = true;
                exRange.HorizontalAlignment = XlHAlign.xlHAlignRight;
                exRange.Value = "Tổng tiền: " + tblThongTinTra.Rows[0]["TongTien"];

                exRange = exSheet.Range[$"A{rowIndex + 5}:F{rowIndex + 5}"];
                exRange.Merge();
                exRange.Font.Size = 11;
                exRange.Font.Italic = true;
                exRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                exRange.Value = $"Bằng chữ: {Functions.ChuyenSoSangChu(tblThongTinTra.Rows[0]["TongTien"].ToString())}";
            }

            exSheet.Columns["E:F"].ColumnWidth = 10;
            exSheet.Rows[$"1:{rowIndex + 5}"].RowHeight = 16.5;

            exApp.Visible = true;

            // Lưu file Excel
            string filePath = $"E:\\rkive\\6\\.NET\\BAEK\\Excel\\BillTra\\{tblThongTinTra.Rows[0]["MaTra"]}.xlsx"; // Đường dẫn lưu file
            
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            
            exBook.SaveAs(filePath); // Lưu file Excel
            exApp.Visible = true; // Hiển thị file Excel

            // Giải phóng tài nguyên COM
            ReleaseObject(exSheet);
            ReleaseObject(exBook);
            ReleaseObject(exApp);
        }

        private static void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                Console.WriteLine("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
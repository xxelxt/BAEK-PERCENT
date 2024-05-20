﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

using BAEK_PERCENT.Database;
using MaterialSkin;
using MaterialSkin.Controls;

namespace BAEK_PERCENT.Forms
{
    public partial class frmHome : MaterialForm
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void swtDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (swtDarkMode.Checked)
            {
                EnableDarkMode();
            }
            else
            {
                EnableLightMode();
            }
        }

        private MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        private void EnableDarkMode()
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            var darkestColorScheme = new ColorScheme(
                Color.FromArgb(12, 12, 12),        // Darkest Gray
                Color.FromArgb(8, 8, 8),           // Darkest Black
                Color.FromArgb(18, 18, 18),        // Very Dark Gray
                Color.FromArgb(255, 150, 79),      // Orange
                TextShade.WHITE
            );
            materialSkinManager.ColorScheme = darkestColorScheme;

        }

        private void EnableLightMode()
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            var lightColorScheme = new ColorScheme(
                Color.FromArgb(255, 255, 255),     // White
                Color.FromArgb(240, 240, 240),     // Light Gray
                Color.FromArgb(255, 255, 255),     // White
                Color.FromArgb(255, 150, 79),      // Orange
                TextShade.BLACK
            );
            materialSkinManager.ColorScheme = lightColorScheme;
        }

        private void donthue_Click(object sender, EventArgs e)
        {
            Loc.Show();
            //doanhthu.Hide();
            //bangtheloaiyeuthich.Hide();
            DateTime selectedDate = start.Value;
            int day_start = selectedDate.Day;
            int month_start = selectedDate.Month;
            int year_start = selectedDate.Year;


            string _start = year_start.ToString() + "-" + month_start.ToString() + "-" + day_start.ToString();
            DateTime selectedDate_e = end.Value;
            int day_end = selectedDate_e.Day;
            int month_end = selectedDate_e.Month;
            int year_end = selectedDate_e.Year;

            String sql_donthue = null;
            string x_value = null;
            string x_axit = null;
            string _loc = Loc.Text;
            string _end = year_end.ToString() + "-" + month_end.ToString() + "-" + day_end.ToString();
            // SQL query to get monthly revenue
            if (_loc == "Ngày")
            {
                sql_donthue = "SELECT ngay, soluong FROM soluongdonthuetheongay('" + _start + "','" + _end + "')";
                x_value = "ngay";
                x_axit = "Ngày";
            }
            else
            {
                if (_loc == "Tháng")
                {
                    sql_donthue = "SELECT thang, soluong FROM soluongdonthuetheothang('" + _start + "','" + _end + "')";
                    x_value = "thang";
                    x_axit = "Tháng";
                }
                else
                {
                    sql_donthue = "SELECT nam, soluong FROM soluongdonthuetheonam('" + _start + "','" + _end + "')";
                    x_value = "nam";
                    x_axit = "Năm";
                }
            }
            DataTable dt = DatabaseLayer.GetDataToTable(sql_donthue);
            Console.WriteLine(sql_donthue);
            // Ensure the series "doanhthu" exists and is added to the chart
            if (!bangdonthue.Series.IsUniqueName("bangdonthue"))
            {
                bangdonthue.Series.Remove(bangdonthue.Series["bangdonthue"]);
            }
            Series seriesBangdonthue = new Series("bangdonthue");
            // Đổi loại biểu đồ thành đường
            seriesBangdonthue.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            // Thiết lập màu và độ dày của đường line
            seriesBangdonthue.Color = Color.Blue; // Màu xanh
            seriesBangdonthue.BorderWidth = 2; // Độ dày là 2 pixel
            bangdonthue.Series.Add(seriesBangdonthue);

            // Binding data to the chart
            bangdonthue.DataSource = dt;
            // Set the name for X-axis
            bangdonthue.ChartAreas[0].AxisX.Title = x_axit;
            // Set the name for Y-axis
            bangdonthue.ChartAreas[0].AxisY.Title = "Số lượng";

            bangdonthue.Series["bangdonthue"].XValueMember = x_value.ToString();
            Console.WriteLine(x_value);
            if (_loc == "Ngày")
            {
                bangdonthue.Series["bangdonthue"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            }
            else
            {
                bangdonthue.Series["bangdonthue"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            }
            bangdonthue.Series["bangdonthue"].YValueMembers = "soluong";
            bangdonthue.Series["bangdonthue"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            bangdonthue.Show();

        }
    }
}

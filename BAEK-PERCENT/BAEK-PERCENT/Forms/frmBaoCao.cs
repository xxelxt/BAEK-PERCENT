using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

using BAEK_PERCENT.DAL;
using MaterialSkin.Controls;

namespace BAEK_PERCENT.Forms
{
    public partial class frmBaoCao : MaterialForm
    {
        public frmBaoCao()
        {
            InitializeComponent();

            cboBaoCao.Items.Add("Báo cáo doanh thu theo tháng");
            cboBaoCao.Items.Add("Báo cáo doanh thu theo tuần");
            cboBaoCao.Items.Add("Báo cáo loại sách được yêu thích");
            cboBaoCao.Items.Add("Báo cáo sách được mượn nhiều nhất");
            cboBaoCao.Items.Add("Báo cáo sách bị mất/hỏng");

            cboBaoCao.SelectedItem = null;

            dtpNgayBD.MaxDate = DateTime.Today;
            dtpNgayKT.MinDate = DateTime.Today;
            dtpNgayKT.MaxDate = DateTime.Today;
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            dtpNgayBD.Enabled = false;
            dtpNgayKT.Enabled = false;

            btnTaoBaoCao.Enabled = false;
            btnXuatBaoCao.Enabled = false;

            chrBaoCao.Visible = false;
        }

        private void dtpNgayBD_ValueChanged(object sender, EventArgs e)
        {
            dtpNgayKT.MinDate = dtpNgayBD.Value;
        }

        private void dtpNgayKT_ValueChanged(object sender, EventArgs e)
        {
            dtpNgayBD.MaxDate = dtpNgayKT.Value;
        }

        private void cboBaoCao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBaoCao.SelectedIndex.ToString() != null)
            {
                dtpNgayBD.Enabled = true;
                dtpNgayKT.Enabled = true;

                btnTaoBaoCao.Enabled = true;
                btnXuatBaoCao.Enabled = true;
            }
            else
            {
                dtpNgayBD.Enabled = false;
                dtpNgayKT.Enabled = false;

                btnTaoBaoCao.Enabled = false;
                btnXuatBaoCao.Enabled = false;
            }
        }

        private void btnTaoBaoCao_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpNgayBD.Value;
            DateTime endDate = dtpNgayKT.Value;

            chrBaoCao.Visible = true;

            switch (cboBaoCao.SelectedIndex)
            {
                case 0:
                    BCDoanhThuThang();
                    break;
                case 1:
                    //BCDoanhThuTuan();
                    break;
                case 2:
                    //BCLoaiSachYeuThich();
                    break;
                case 3:
                    //BCSachYeuThich();
                    break;
                case 4:
                    //BCSachMatHong();
                    break;
                default:
                    break;
            }
        }

        private void BCDoanhThuThang()
        {
            DateTime startDate = dtpNgayBD.Value;
            DateTime endDate = dtpNgayKT.Value;

            DataTable dt = BaoCaoDAL.GetDoanhThuTheoThang(startDate, endDate);
            chrBaoCao.Series.Clear();

            Series series = new Series("Doanh thu")
            {
                XValueType = ChartValueType.Date,
                ChartType = SeriesChartType.Column,
                Font = new Font("Microsoft Sans Serif", 14)
            };

            foreach (DataRow row in dt.Rows)
            {
                int year = Convert.ToInt32(row["Year"]);
                int month = Convert.ToInt32(row["Month"]);
                decimal revenue = Convert.ToDecimal(row["MonthlyRevenue"]);

                DateTime dateValue = new DateTime(year, month, 1);

                series.Points.AddXY(dateValue, revenue);
                series.Points[series.Points.Count - 1].Label = string.Format("{0:#,##0}đ", revenue);
                series.Points[series.Points.Count - 1].Font = new Font("Microsoft Sans Serif", 12); // Set font for data labels
            }

            chrBaoCao.Series.Add(series);
            chrBaoCao.ChartAreas[0].AxisX.LabelStyle.Format = "MMM yyyy";
            chrBaoCao.ChartAreas[0].AxisX.Interval = 1;
            chrBaoCao.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
            chrBaoCao.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount;
            chrBaoCao.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chrBaoCao.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            chrBaoCao.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Microsoft Sans Serif", 12);
            chrBaoCao.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Microsoft Sans Serif", 12);

            chrBaoCao.Titles.Clear();
            Title title = new Title("Báo cáo doanh thu theo tháng", Docking.Top, new Font("Arial", 18, FontStyle.Bold), Color.Black);
            chrBaoCao.Titles.Add(title);

            chrBaoCao.Legends.Clear();
            Legend legend = new Legend
            {
                Docking = Docking.Bottom,
                Alignment = StringAlignment.Center,
                Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular)
            };
            chrBaoCao.Legends.Add(legend);
        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {

        }

    }
}

using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;
using BAEK_PERCENT.Class.Types;
using BAEK_PERCENT.Database;
using BAEK_PERCENT.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BAEK_PERCENT.Class;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace BAEK_PERCENT
{
    public partial class frmMain : MaterialForm
    {
        private frmSach childFormSach;
        private frmThue childFormThue;
        private frmTra childFormTra;
        private frmBaoCao childFormBaoCao;
        private frmKhach childFormKhach;

        private frmNhanVien childFormNhanVien;
        private frmTacGia childFormTacGia;
        private frmLinhVuc childFormLinhVuc;

        private frmLoaiSach childFormLoaiSach;
        private frmNgonNgu childFormNgonNgu;
        private frmViPham childFormViPham;

        private frmTaiKhoan childFormTaiKhoan;
        private frmThongTin childFormThongTin;

        public frmMain()
        {
            InitializeComponent();

            Color primaryColor = Color.FromArgb(255, 255, 255);       // White
            Color darkPrimaryColor = Color.FromArgb(240, 240, 240);   // Light Gray
            Color lightPrimaryColor = Color.FromArgb(255, 255, 255);  // White
            Color accentColor = Color.FromArgb(255, 150, 79);         // Orange

            // Set the theme to light
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Create a custom color scheme
            var colorScheme = new ColorScheme(
                primaryColor,
                darkPrimaryColor,
                lightPrimaryColor,
                accentColor,
                TextShade.BLACK // Use BLACK text shade to contrast with light backgrounds
            );

            // Apply the custom color scheme
            materialSkinManager.ColorScheme = colorScheme;

            materialSkinManager.AddFormToManage(this);

            // Initialize all form controls
            initAllForm();

            // Update the form title based on the selected tab (assuming materialTabControl is correctly initialized)
            UpdateFormTitle(materialTabControl.SelectedTab);

        }

        private MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        private void initForm(MaterialForm form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            materialSkinManager.AddFormToManage(form);
        }

        private void initAllForm()
        {
            initFormSach();
            initFormThue();
            initFormTra();
            initFormBaoCao();

            initFormKhach();
            initFormLoaiSach();
            initFormNgonNgu();

            initFormTacGia();
            initFormLinhVuc();
            initFormNhanVien();

            initFormViPham();
            initFormTaiKhoan();
            initFormThongTin();
        }

        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFormTitle(materialTabControl.SelectedTab);
        }

        private void UpdateFormTitle(TabPage selectedTab)
        {
            if (selectedTab != null)
            {
                this.Text = $"{selectedTab.Text}";
            }
        }

        private void initFormSach()
        {
            childFormSach = new frmSach();
            initForm(childFormSach);
            tabPageSach.Controls.Add(childFormSach);
            childFormSach.Show();
        }

        private void initFormThue()
        {
            childFormThue = new frmThue();
            initForm(childFormThue);
            tabPageThue.Controls.Add(childFormThue);
            childFormThue.Show();
        }

        private void initFormTra()
        {
            childFormTra = new frmTra();
            initForm(childFormTra);
            tabPageTra.Controls.Add(childFormTra);
            childFormTra.Show();
        }

        private void initFormBaoCao()
        {
            childFormBaoCao = new frmBaoCao();
            initForm(childFormBaoCao);
            tabPageBC.Controls.Add(childFormBaoCao);
            childFormBaoCao.Show();
        }

        private void initFormKhach()
        {
            childFormKhach = new frmKhach();
            initForm(childFormKhach);
            tabPageKhach.Controls.Add(childFormKhach);
            childFormKhach.Show();
        }

        private void initFormNhanVien()
        {
            childFormNhanVien = new frmNhanVien();
            initForm(childFormNhanVien);
            tabPageNV.Controls.Add(childFormNhanVien);
            childFormNhanVien.Show();
        }

        private void initFormTacGia()
        {
            childFormTacGia = new frmTacGia();
            initForm(childFormTacGia);
            tabPageTG.Controls.Add(childFormTacGia);
            childFormTacGia.Show();
        }

        private void initFormLinhVuc()
        {
            childFormLinhVuc = new frmLinhVuc();
            initForm(childFormLinhVuc);
            tabPageLV.Controls.Add(childFormLinhVuc);
            childFormLinhVuc.Show();
        }

        private void initFormLoaiSach()
        {
            childFormLoaiSach = new frmLoaiSach();
            initForm(childFormLoaiSach);
            tabPageLoai.Controls.Add(childFormLoaiSach);
            childFormLoaiSach.Show();
        }

        private void initFormNgonNgu()
        {
            childFormNgonNgu = new frmNgonNgu();
            initForm(childFormNgonNgu);
            tabPageNN.Controls.Add(childFormNgonNgu);
            childFormNgonNgu.Show();
        }

        private void initFormViPham()
        {
            childFormViPham = new frmViPham();
            initForm(childFormViPham);
            tabPageVP.Controls.Add(childFormViPham);
            childFormViPham.Show();
        }

        private void initFormTaiKhoan()
        {
            childFormTaiKhoan = new frmTaiKhoan();
            initForm(childFormTaiKhoan);
            tabPageTK.Controls.Add(childFormTaiKhoan);
            childFormTaiKhoan.Show();
        }

        private void initFormThongTin()
        {
            childFormThongTin = new frmThongTin();
            initForm(childFormThongTin);
            tabPageTT.Controls.Add(childFormThongTin);
            childFormThongTin.Show();
        }

        public UserRole currentRole;

        private void atEnd_frmMain_Shown(object sender, EventArgs e)
        {
            UpdateTabVisibility(); // Update tab visibility when the form is shown
        }

        private void SetUserRole(UserRole role)
        {
            this.currentRole = role;
            UpdateTabVisibility(); // Update tab visibility when role changes
        }

        private void frmMain_VisibleChanged(object sender, EventArgs e)
        {
            UpdateTabVisibility();
        }

        private void UpdateTabVisibility()
        {
            if (this.currentRole == UserRole.User)
            {
                HideUserTabs();
            }
            else if (this.currentRole == UserRole.Admin)
            {
                ShowAllTabs();
            }
        }

        private void HideUserTabs()
        {
            if (Drawer != null && Drawer.BaseTabControl != null)
            {
                this.Drawer.HideTabPage(tabPageBC); 
                this.Drawer.HideTabPage(tabPageNV);
                this.Drawer.HideTabPage(tabPageVP);
                this.Drawer.HideTabPage(tabPageSach);
                this.Drawer.HideTabPage(tabPageNN);
                this.Drawer.HideTabPage(tabPageTK);
            }
        }

        private void ShowAllTabs()
        {
            if (Drawer != null && Drawer.BaseTabControl != null)
            {
                this.Drawer.ShowTabPage(tabPageBC);
                this.Drawer.ShowTabPage(tabPageNV);
                this.Drawer.ShowTabPage(tabPageVP);
                this.Drawer.ShowTabPage(tabPageSach);
                this.Drawer.ShowTabPage(tabPageNN);
                this.Drawer.ShowTabPage(tabPageTK);
            }
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

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
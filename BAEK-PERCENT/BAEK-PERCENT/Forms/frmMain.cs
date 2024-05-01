using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;
using BAEK_PERCENT.Class.Types;
using BAEK_PERCENT.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace BAEK_PERCENT
{
    public partial class frmMain : MaterialForm
    {
        private frmSach childFormSach;
        private frmThue childFormThue;
        private frmTra childFormTra;
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

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

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
                this.Drawer.ShowTabPage(tabPageNV);
                this.Drawer.ShowTabPage(tabPageVP);
                this.Drawer.ShowTabPage(tabPageSach);
                this.Drawer.ShowTabPage(tabPageNN);
                this.Drawer.ShowTabPage(tabPageTK);
            }
        }
    }
}
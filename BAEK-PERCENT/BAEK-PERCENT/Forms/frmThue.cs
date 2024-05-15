using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAEK_PERCENT.Class;
using BAEK_PERCENT.DAL;
using BAEK_PERCENT.Database;
using MaterialSkin;
using MaterialSkin.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BAEK_PERCENT.Forms
{
    public partial class frmThue : MaterialForm
    {
        private DataTable tblThueSach;
        private DataTable tblCTThueSach;

        private bool isSearching = false;
        private string currentSearchKeyword = "";

        public frmThue()
        {
            InitializeComponent();

            InitializeListView();
            InitializeListViewCT();

            LoadData();
        }

        private void InitializeListView()
        {
            listViewThue.FullRowSelect = true;
            listViewThue.MultiSelect = false;
            listViewThue.UseCompatibleStateImageBehavior = false;
            listViewThue.View = View.Details;

            listViewThue.Columns.Add("MaThue", "Mã thuê");
            listViewThue.Columns.Add("TenKH", "Tên khách hàng");
            listViewThue.Columns.Add("NgayThue", "Ngày thuê");
            listViewThue.Columns.Add("TienDatCoc", "Tiền đặt cọc");
        }

        private void InitializeListViewCT()
        {
            listViewCTThue.FullRowSelect = true;
            listViewCTThue.MultiSelect = false;
            listViewCTThue.UseCompatibleStateImageBehavior = false;
            listViewCTThue.View = View.Details;

            listViewCTThue.Columns.Add("MaSach", "Mã sách");
            listViewCTThue.Columns.Add("TenSach", "Tên sách");
            listViewCTThue.Columns.Add("DonGiaThue", "Đơn giá thuê");
            listViewCTThue.Columns.Add("DaTra", "Tình trạng");
        }

        private void frmThue_Load(object sender, EventArgs e)
        {

        }

        private void AdjustColumnWidth(MaterialSkin.Controls.MaterialListView listView)
        {
            int totalWidth = listView.ClientSize.Width;
            double col1Percentage = 0.2;
            double col2Percentage = 0.3;
            double col3Percentage = 0.25;
            double col4Percentage = 0.25;

            int col1Width = (int)(totalWidth * col1Percentage);
            int col2Width = (int)(totalWidth * col2Percentage);
            int col3Width = (int)(totalWidth * col3Percentage);
            int col4Width = (int)(totalWidth * col4Percentage);

            listView.Columns[0].Width = col1Width;
            listView.Columns[1].Width = col2Width;
            listView.Columns[2].Width = col3Width;
            listView.Columns[3].Width = col4Width;
        }

        private void LoadData()
        {
            try
            {
                if (isSearching)
                    tblThueSach = ThueDAL.GetAllThue();
                    //tblThueSach = ThueDAL.GetThueBySearch(currentSearchOption, currentSearchKeyword);
                else
                    tblThueSach = ThueDAL.GetAllThue();

                LoadListView();
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadDataCT(string maThue)
        {
            try
            {
                tblCTThueSach = ThueDAL.GetCTThue(maThue);

                LoadListViewCT();
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadListView()
        {
            ClearListView(listViewThue);

            foreach (DataRow row in tblThueSach.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaThue"].ToString());
                item.SubItems.Add(row["TenKH"].ToString());

                item.Tag = new
                {
                    MaKH = row["MaKH"].ToString(),
                    MaNV = row["MaNV"].ToString(),
                    TenNV = row["TenNV"].ToString()
                };

                DateTime ngayThue;
                if (DateTime.TryParse(row["NgayThue"].ToString(), out ngayThue))
                {
                    string ngayThueFormatted = ngayThue.ToString("dd/MM/yyyy");

                    item.SubItems.Add(ngayThueFormatted);
                }
                else
                {
                    item.SubItems.Add("");
                }

                item.SubItems.Add(row["TienDatCoc"].ToString());

                listViewThue.Items.Add(item);
            }

            AdjustColumnWidth(listViewThue);
        }

        private void LoadListViewCT()
        {
            ClearListView(listViewCTThue);

            foreach (DataRow row in tblCTThueSach.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaSach"].ToString());
                item.SubItems.Add(row["TenSach"].ToString());
                item.SubItems.Add(row["DonGiaThue"].ToString());

                string trangThai = "";
                if (row["DaTra"] != null && row["DaTra"] != DBNull.Value)
                {
                    bool trangThaiValue = Convert.ToBoolean(row["DaTra"]);
                    trangThai = trangThaiValue ? "Đã trả" : "Chưa/không trả";
                }
                else
                {
                    trangThai = "";
                }

                item.SubItems.Add(trangThai);

                listViewCTThue.Items.Add(item);
            }

            AdjustColumnWidth(listViewCTThue);
        }

        private void ClearListView(MaterialSkin.Controls.MaterialListView listView)
        {
            listView.Items.Clear();
        }

        private void listViewThue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                Functions.HandleInfo("Đang ở chế độ thêm mới");
                txtMaSach.Focus();
                return;
            }

            if (tblThueSach.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewThue.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewThue.SelectedItems[0];
                txtMaThue.Text = selectedItem.SubItems[0].Text;
                txtTenKH.Text = selectedItem.SubItems[1].Text;

                string ngayThueStr = selectedItem.SubItems[2].Text;
                DateTime ngayThue;
                if (DateTime.TryParse(ngayThueStr, out ngayThue))
                {
                    txtNgayThue.Text = ngayThue.ToString("dd/MM/yyyy");
                }
                else
                {
                    txtNgayThue.Text = "";
                }
                
                txtTienDatCoc.Text = selectedItem.SubItems[3].Text;

                dynamic tagData = selectedItem.Tag;
                txtMaKH.Text = tagData.MaKH;
                txtMaNV.Text = tagData.MaNV;
                txtTenNV.Text = tagData.TenNV;

                string maThue = txtMaThue.Text.Trim();
                LoadDataCT(maThue);

                //btnSua.Enabled = true;
                //btnXoa.Enabled = true;
                //btnHuy.Enabled = true;
            }
            else
            {
                //ResetValues();

                //btnSua.Enabled = false;
                //btnXoa.Enabled = false;
                //btnHuy.Enabled = false;

                ClearListView(listViewCTThue);
            }
        }

        private void listViewCTThue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                Functions.HandleInfo("Đang ở chế độ thêm mới");
                txtMaSach.Focus();
                return;
            }

            if (tblThueSach.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewThue.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewCTThue.SelectedItems[0];
                txtMaSach.Text = selectedItem.SubItems[0].Text;
                txtTenSach.Text = selectedItem.SubItems[1].Text;

                if (selectedItem.SubItems[3].Text == "Đã trả")
                {
                    rdoDaTra.Checked = true;
                    rdoChuaTra.Checked = false;
                }
                else if (selectedItem.SubItems[3].Text == "Nữ")
                {
                    rdoDaTra.Checked = false;
                    rdoChuaTra.Checked = true;
                }

                //btnSua.Enabled = true;
                //btnXoa.Enabled = true;
                //btnHuy.Enabled = true;
            }
            else
            {
                //ResetValuesCT();

                //btnSua.Enabled = false;
                //btnXoa.Enabled = false;
                //btnHuy.Enabled = false;
            }
        }
    }
}
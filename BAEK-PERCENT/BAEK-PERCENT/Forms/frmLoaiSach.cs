﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BAEK_PERCENT.Class;
using BAEK_PERCENT.DAL;
using MaterialSkin;
using MaterialSkin.Controls;

namespace BAEK_PERCENT.Forms
{
    public partial class frmLoaiSach : MaterialForm
    {
        private DataTable tblLoaiSach;

        private bool isSearching = false;
        private string currentSearchKeyword = "";

        public frmLoaiSach()
        {
            InitializeComponent();
            InitializeListView();
            LoadData();
        }

        private void InitializeListView()
        {
            listViewLoai.FullRowSelect = true;
            listViewLoai.MultiSelect = false;
            listViewLoai.UseCompatibleStateImageBehavior = false;
            listViewLoai.View = View.Details;

            listViewLoai.Columns.Add("MaLoai", "Mã loại sách");
            listViewLoai.Columns.Add("TenLoai", "Tên loại sách");
        }

        private void frmLoaiSach_Load(object sender, EventArgs e)
        {
            txtMaLoai.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void AdjustColumnWidth()
        {
            int totalWidth = listViewLoai.ClientSize.Width;
            double col1Percentage = 0.3;
            double col2Percentage = 0.7;
            int col1Width = (int)(totalWidth * col1Percentage);
            int col2Width = (int)(totalWidth * col2Percentage);

            listViewLoai.Columns[0].Width = col1Width;
            listViewLoai.Columns[1].Width = col2Width;
        }

        private void LoadData()
        {
            try
            {
                if (isSearching)
                    tblLoaiSach = LoaiSachDAL.GetLoaiSachBySearch(currentSearchKeyword);
                else
                    tblLoaiSach = LoaiSachDAL.GetAllLoaiSach();

                LoadListView();
            }
            catch (Exception ex)
            {
                Functions.HandleError("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadListView()
        {
            ClearListView();

            foreach (DataRow row in tblLoaiSach.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaLoai"].ToString());
                item.SubItems.Add(row["TenLoai"].ToString());
                listViewLoai.Items.Add(item);
            }

            AdjustColumnWidth();
        }

        private void ClearListView()
        {
            listViewLoai.Items.Clear();
        }

        private void listViewLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                Functions.HandleInfo("Đang ở chế độ thêm mới");
                txtMaLoai.Focus();
                return;
            }

            if (tblLoaiSach.Rows.Count == 0)
            {
                Functions.HandleInfo("Không có dữ liệu");
                return;
            }

            if (listViewLoai.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewLoai.SelectedItems[0];
                txtMaLoai.Text = selectedItem.SubItems[0].Text;
                txtTenLoai.Text = selectedItem.SubItems[1].Text;

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                txtMaLoai.Text = "";
                txtTenLoai.Text = "";
            }
        }

        private void ResetValues()
        {
            txtMaLoai.Text = "";
            txtTenLoai.Text = "";
        }

        private bool ValidateInput()
        {
            /*
            if (string.IsNullOrWhiteSpace(txtMaLoai.Text))
            {
                Functions.HandleWarning("Bạn phải nhập mã loại sách");
                txtMaLoai.Focus();
                return false;
            }
            */

            if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
            {
                Functions.HandleWarning("Bạn phải nhập tên loại sách");
                txtTenLoai.Focus();
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;

            btnLuu.Enabled = true;
            ResetValues();
            txtTenLoai.Focus();

            string newMaLoai = LoaiSachDAL.InsertEmptyLoaiSach();
            txtMaLoai.Text = newMaLoai;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listViewLoai.SelectedItems.Count == 0)
            {
                Functions.HandleInfo("Bạn chưa chọn bản ghi nào để sửa");
                return;
            }
            
            if (ValidateInput())
            {
                string maLoai = txtMaLoai.Text.Trim();
                string tenLoai = txtTenLoai.Text.Trim();

                try
                {
                    LoaiSachDAL.UpdateLoaiSach(maLoai, tenLoai);
                    Functions.HandleInfo("Cập nhật loại sách thành công");
                    LoadData();
                    ResetValues();
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi cập nhật loại sách: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maLoai = txtMaLoai.Text.Trim();

            if (!string.IsNullOrEmpty(maLoai))
            {
                if (Functions.HandleQuestion("Bạn có muốn xóa không?"))
                {
                    try
                    {
                        LoaiSachDAL.DeleteLoaiSach(maLoai);
                        Functions.HandleInfo("Xóa loại sách thành công");
                        LoadData();
                        ResetValues();
                    }
                    catch (Exception ex)
                    {
                        Functions.HandleError("Lỗi khi xóa loại sách: " + ex.Message);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string maLoai = txtMaLoai.Text.Trim();
                string tenLoai = txtTenLoai.Text.Trim();

                try
                {
                    LoaiSachDAL.UpdateLoaiSach(maLoai, tenLoai);
                    Functions.HandleInfo("Thêm loại sách thành công");
                    LoadData();
                    ResetValues();

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnHuy.Enabled = false;
                    btnLuu.Enabled = false;
                    txtMaLoai.Enabled = false;
                }
                catch (Exception ex)
                {
                    Functions.HandleError("Lỗi khi thêm loại sách: " + ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string maLoai = txtMaLoai.Text.Trim();

            ResetValues();

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaLoai.Enabled = false;

            txtTimKiem.Text = "";
            isSearching = false;

            if (!string.IsNullOrEmpty(maLoai))
            {
                LoaiSachDAL.DeleteEmptyLoaiSach(maLoai);
            }
            LoadData();
        }

        private void PerformSearch()
        {
            currentSearchKeyword = txtTimKiem.Text.Trim();
            isSearching = true;

            LoadData();

            btnHuy.Enabled = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformSearch();
                e.SuppressKeyPress = true;
            }
        }
    }
}

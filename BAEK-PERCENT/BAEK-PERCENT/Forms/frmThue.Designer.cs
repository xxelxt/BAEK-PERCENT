namespace BAEK_PERCENT.Forms
{
    partial class frmThue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            this.cboTimKiem = new MaterialSkin.Controls.MaterialComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenKH = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtTenNV = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtTienDatCoc = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtMaKH = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMaThue = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNgayThue = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtMaNV = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtTimKiem = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.btnHuy = new MaterialSkin.Controls.MaterialButton();
            this.btnLuu = new MaterialSkin.Controls.MaterialButton();
            this.listViewCTThue = new MaterialSkin.Controls.MaterialListView();
            this.btnThem = new MaterialSkin.Controls.MaterialButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoChuaTra = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoDaTra = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTenSach = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.btnXoa = new MaterialSkin.Controls.MaterialButton();
            this.txtMaSach = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.listViewThue = new MaterialSkin.Controls.MaterialListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.AutoSize = false;
            this.btnTimKiem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTimKiem.Depth = 0;
            this.btnTimKiem.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.HighEmphasis = true;
            this.btnTimKiem.Icon = null;
            this.btnTimKiem.Location = new System.Drawing.Point(905, 27);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 12, 4, 6);
            this.btnTimKiem.MaximumSize = new System.Drawing.Size(96, 40);
            this.btnTimKiem.MinimumSize = new System.Drawing.Size(0, 48);
            this.btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Padding = new System.Windows.Forms.Padding(3);
            this.btnTimKiem.Size = new System.Drawing.Size(96, 48);
            this.btnTimKiem.TabIndex = 158;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTimKiem.UseAccentColor = false;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTimKiem.AutoResize = false;
            this.cboTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboTimKiem.Depth = 0;
            this.cboTimKiem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboTimKiem.DropDownHeight = 174;
            this.cboTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimKiem.DropDownWidth = 121;
            this.cboTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboTimKiem.FormattingEnabled = true;
            this.cboTimKiem.IntegralHeight = false;
            this.cboTimKiem.ItemHeight = 43;
            this.cboTimKiem.Location = new System.Drawing.Point(726, 26);
            this.cboTimKiem.MaxDropDownItems = 4;
            this.cboTimKiem.MinimumSize = new System.Drawing.Size(150, 0);
            this.cboTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(158, 49);
            this.cboTimKiem.StartIndex = 0;
            this.cboTimKiem.TabIndex = 160;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtTienDatCoc);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.materialLabel9);
            this.groupBox1.Controls.Add(this.txtMaThue);
            this.groupBox1.Controls.Add(this.materialLabel7);
            this.groupBox1.Controls.Add(this.materialLabel6);
            this.groupBox1.Controls.Add(this.materialLabel8);
            this.groupBox1.Controls.Add(this.materialLabel5);
            this.groupBox1.Controls.Add(this.txtNgayThue);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(27, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(973, 230);
            this.groupBox1.TabIndex = 161;
            this.groupBox1.TabStop = false;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenKH.AnimateReadOnly = false;
            this.txtTenKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTenKH.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTenKH.Depth = 0;
            this.txtTenKH.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.HideSelection = true;
            this.txtTenKH.LeadingIcon = null;
            this.txtTenKH.Location = new System.Drawing.Point(466, 91);
            this.txtTenKH.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtTenKH.MaxLength = 32767;
            this.txtTenKH.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtTenKH.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.PasswordChar = '\0';
            this.txtTenKH.PrefixSuffixText = null;
            this.txtTenKH.ReadOnly = false;
            this.txtTenKH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTenKH.SelectedText = "";
            this.txtTenKH.SelectionLength = 0;
            this.txtTenKH.SelectionStart = 0;
            this.txtTenKH.ShortcutsEnabled = true;
            this.txtTenKH.Size = new System.Drawing.Size(483, 48);
            this.txtTenKH.TabIndex = 138;
            this.txtTenKH.TabStop = false;
            this.txtTenKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenKH.TrailingIcon = null;
            this.txtTenKH.UseSystemPasswordChar = false;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNV.AnimateReadOnly = false;
            this.txtTenNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTenNV.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTenNV.Depth = 0;
            this.txtTenNV.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.HideSelection = true;
            this.txtTenNV.LeadingIcon = null;
            this.txtTenNV.Location = new System.Drawing.Point(466, 155);
            this.txtTenNV.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtTenNV.MaxLength = 32767;
            this.txtTenNV.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtTenNV.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.PasswordChar = '\0';
            this.txtTenNV.PrefixSuffixText = null;
            this.txtTenNV.ReadOnly = false;
            this.txtTenNV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTenNV.SelectedText = "";
            this.txtTenNV.SelectionLength = 0;
            this.txtTenNV.SelectionStart = 0;
            this.txtTenNV.ShortcutsEnabled = true;
            this.txtTenNV.Size = new System.Drawing.Size(483, 48);
            this.txtTenNV.TabIndex = 142;
            this.txtTenNV.TabStop = false;
            this.txtTenNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenNV.TrailingIcon = null;
            this.txtTenNV.UseSystemPasswordChar = false;
            // 
            // txtTienDatCoc
            // 
            this.txtTienDatCoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTienDatCoc.AnimateReadOnly = true;
            this.txtTienDatCoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTienDatCoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTienDatCoc.Depth = 0;
            this.txtTienDatCoc.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienDatCoc.HideSelection = true;
            this.txtTienDatCoc.LeadingIcon = null;
            this.txtTienDatCoc.Location = new System.Drawing.Point(764, 28);
            this.txtTienDatCoc.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtTienDatCoc.MaxLength = 32767;
            this.txtTienDatCoc.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtTienDatCoc.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTienDatCoc.Name = "txtTienDatCoc";
            this.txtTienDatCoc.PasswordChar = '\0';
            this.txtTienDatCoc.PrefixSuffixText = null;
            this.txtTienDatCoc.ReadOnly = false;
            this.txtTienDatCoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTienDatCoc.SelectedText = "";
            this.txtTienDatCoc.SelectionLength = 0;
            this.txtTienDatCoc.SelectionStart = 0;
            this.txtTienDatCoc.ShortcutsEnabled = true;
            this.txtTienDatCoc.Size = new System.Drawing.Size(185, 48);
            this.txtTienDatCoc.TabIndex = 143;
            this.txtTienDatCoc.TabStop = false;
            this.txtTienDatCoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTienDatCoc.TrailingIcon = null;
            this.txtTienDatCoc.UseSystemPasswordChar = false;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaKH.AnimateReadOnly = false;
            this.txtMaKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMaKH.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaKH.Depth = 0;
            this.txtMaKH.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.HideSelection = true;
            this.txtMaKH.LeadingIcon = null;
            this.txtMaKH.Location = new System.Drawing.Point(144, 91);
            this.txtMaKH.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtMaKH.MaxLength = 32767;
            this.txtMaKH.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtMaKH.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.PasswordChar = '\0';
            this.txtMaKH.PrefixSuffixText = null;
            this.txtMaKH.ReadOnly = false;
            this.txtMaKH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMaKH.SelectedText = "";
            this.txtMaKH.SelectionLength = 0;
            this.txtMaKH.SelectionStart = 0;
            this.txtMaKH.ShortcutsEnabled = true;
            this.txtMaKH.Size = new System.Drawing.Size(183, 48);
            this.txtMaKH.TabIndex = 136;
            this.txtMaKH.TabStop = false;
            this.txtMaKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaKH.TrailingIcon = null;
            this.txtMaKH.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(73, 43);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(63, 19);
            this.materialLabel1.TabIndex = 83;
            this.materialLabel1.Text = "Mã thuê:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(356, 170);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(105, 19);
            this.materialLabel4.TabIndex = 137;
            this.materialLabel4.Text = "Tên nhân viên:";
            // 
            // materialLabel9
            // 
            this.materialLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(35, 170);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(101, 19);
            this.materialLabel9.TabIndex = 135;
            this.materialLabel9.Text = "Mã nhân viên:";
            // 
            // txtMaThue
            // 
            this.txtMaThue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaThue.AnimateReadOnly = true;
            this.txtMaThue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMaThue.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaThue.Depth = 0;
            this.txtMaThue.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThue.HideSelection = true;
            this.txtMaThue.LeadingIcon = null;
            this.txtMaThue.Location = new System.Drawing.Point(144, 28);
            this.txtMaThue.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtMaThue.MaxLength = 32767;
            this.txtMaThue.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtMaThue.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaThue.Name = "txtMaThue";
            this.txtMaThue.PasswordChar = '\0';
            this.txtMaThue.PrefixSuffixText = null;
            this.txtMaThue.ReadOnly = false;
            this.txtMaThue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMaThue.SelectedText = "";
            this.txtMaThue.SelectionLength = 0;
            this.txtMaThue.SelectionStart = 0;
            this.txtMaThue.ShortcutsEnabled = true;
            this.txtMaThue.Size = new System.Drawing.Size(183, 48);
            this.txtMaThue.TabIndex = 84;
            this.txtMaThue.TabStop = false;
            this.txtMaThue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaThue.TrailingIcon = null;
            this.txtMaThue.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(665, 43);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(93, 19);
            this.materialLabel7.TabIndex = 101;
            this.materialLabel7.Text = "Tiền đặt cọc:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(342, 105);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(119, 19);
            this.materialLabel6.TabIndex = 141;
            this.materialLabel6.Text = "Tên khách hàng:";
            // 
            // materialLabel8
            // 
            this.materialLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(21, 105);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(115, 19);
            this.materialLabel8.TabIndex = 139;
            this.materialLabel8.Text = "Mã khách hàng:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(384, 43);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(77, 19);
            this.materialLabel5.TabIndex = 97;
            this.materialLabel5.Text = "Ngày thuê:";
            // 
            // txtNgayThue
            // 
            this.txtNgayThue.AllowPromptAsInput = true;
            this.txtNgayThue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNgayThue.AnimateReadOnly = false;
            this.txtNgayThue.AsciiOnly = false;
            this.txtNgayThue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNgayThue.BeepOnError = false;
            this.txtNgayThue.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtNgayThue.Depth = 0;
            this.txtNgayThue.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNgayThue.HidePromptOnLeave = false;
            this.txtNgayThue.HideSelection = true;
            this.txtNgayThue.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtNgayThue.LeadingIcon = null;
            this.txtNgayThue.Location = new System.Drawing.Point(466, 28);
            this.txtNgayThue.Mask = "00/00/0000";
            this.txtNgayThue.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtNgayThue.MaxLength = 32767;
            this.txtNgayThue.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtNgayThue.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNgayThue.Name = "txtNgayThue";
            this.txtNgayThue.PasswordChar = '\0';
            this.txtNgayThue.PrefixSuffixText = null;
            this.txtNgayThue.PromptChar = '_';
            this.txtNgayThue.ReadOnly = false;
            this.txtNgayThue.RejectInputOnFirstFailure = false;
            this.txtNgayThue.ResetOnPrompt = true;
            this.txtNgayThue.ResetOnSpace = true;
            this.txtNgayThue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNgayThue.SelectedText = "";
            this.txtNgayThue.SelectionLength = 0;
            this.txtNgayThue.SelectionStart = 0;
            this.txtNgayThue.ShortcutsEnabled = true;
            this.txtNgayThue.Size = new System.Drawing.Size(170, 48);
            this.txtNgayThue.SkipLiterals = true;
            this.txtNgayThue.TabIndex = 100;
            this.txtNgayThue.TabStop = false;
            this.txtNgayThue.Text = "  /  /";
            this.txtNgayThue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNgayThue.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtNgayThue.TrailingIcon = null;
            this.txtNgayThue.UseSystemPasswordChar = false;
            this.txtNgayThue.ValidatingType = null;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaNV.AnimateReadOnly = false;
            this.txtMaNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMaNV.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaNV.Depth = 0;
            this.txtMaNV.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.HideSelection = true;
            this.txtMaNV.LeadingIcon = null;
            this.txtMaNV.Location = new System.Drawing.Point(144, 155);
            this.txtMaNV.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtMaNV.MaxLength = 32767;
            this.txtMaNV.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtMaNV.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.PasswordChar = '\0';
            this.txtMaNV.PrefixSuffixText = null;
            this.txtMaNV.ReadOnly = false;
            this.txtMaNV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMaNV.SelectedText = "";
            this.txtMaNV.SelectionLength = 0;
            this.txtMaNV.SelectionStart = 0;
            this.txtMaNV.ShortcutsEnabled = true;
            this.txtMaNV.Size = new System.Drawing.Size(183, 48);
            this.txtMaNV.TabIndex = 140;
            this.txtMaNV.TabStop = false;
            this.txtMaNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaNV.TrailingIcon = null;
            this.txtMaNV.UseSystemPasswordChar = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.AnimateReadOnly = false;
            this.txtTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTimKiem.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTimKiem.Depth = 0;
            this.txtTimKiem.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.HideSelection = true;
            this.txtTimKiem.LeadingIcon = null;
            this.txtTimKiem.Location = new System.Drawing.Point(27, 27);
            this.txtTimKiem.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtTimKiem.MaxLength = 32767;
            this.txtTimKiem.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PrefixSuffixText = null;
            this.txtTimKiem.ReadOnly = false;
            this.txtTimKiem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.SelectionLength = 0;
            this.txtTimKiem.SelectionStart = 0;
            this.txtTimKiem.ShortcutsEnabled = true;
            this.txtTimKiem.Size = new System.Drawing.Size(674, 48);
            this.txtTimKiem.TabIndex = 159;
            this.txtTimKiem.TabStop = false;
            this.txtTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimKiem.TrailingIcon = null;
            this.txtTimKiem.UseSystemPasswordChar = false;
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = false;
            this.materialButton1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(405, 409);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MaximumSize = new System.Drawing.Size(0, 36);
            this.materialButton1.MinimumSize = new System.Drawing.Size(80, 36);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(80, 36);
            this.materialButton1.TabIndex = 156;
            this.materialButton1.Text = "In";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHuy.AutoSize = false;
            this.btnHuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHuy.Depth = 0;
            this.btnHuy.DrawShadows = false;
            this.btnHuy.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.HighEmphasis = true;
            this.btnHuy.Icon = null;
            this.btnHuy.Location = new System.Drawing.Point(310, 409);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHuy.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnHuy.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnHuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHuy.Size = new System.Drawing.Size(80, 36);
            this.btnHuy.TabIndex = 155;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHuy.UseAccentColor = false;
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLuu.AutoSize = false;
            this.btnLuu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLuu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLuu.Depth = 0;
            this.btnLuu.DrawShadows = false;
            this.btnLuu.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.HighEmphasis = true;
            this.btnLuu.Icon = null;
            this.btnLuu.Location = new System.Drawing.Point(214, 409);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLuu.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnLuu.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLuu.Size = new System.Drawing.Size(80, 36);
            this.btnLuu.TabIndex = 154;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLuu.UseAccentColor = false;
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // listViewCTThue
            // 
            this.listViewCTThue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewCTThue.AutoSizeTable = false;
            this.listViewCTThue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewCTThue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewCTThue.CheckBoxes = true;
            this.listViewCTThue.Depth = 0;
            this.listViewCTThue.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCTThue.FullRowSelect = true;
            this.listViewCTThue.HideSelection = false;
            this.listViewCTThue.Location = new System.Drawing.Point(24, 175);
            this.listViewCTThue.MinimumSize = new System.Drawing.Size(400, 150);
            this.listViewCTThue.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewCTThue.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewCTThue.Name = "listViewCTThue";
            this.listViewCTThue.OwnerDraw = true;
            this.listViewCTThue.Size = new System.Drawing.Size(461, 213);
            this.listViewCTThue.TabIndex = 82;
            this.listViewCTThue.UseCompatibleStateImageBehavior = false;
            this.listViewCTThue.View = System.Windows.Forms.View.Details;
            this.listViewCTThue.SelectedIndexChanged += new System.EventHandler(this.listViewCTThue_SelectedIndexChanged);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThem.AutoSize = false;
            this.btnThem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThem.Depth = 0;
            this.btnThem.DrawShadows = false;
            this.btnThem.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.HighEmphasis = true;
            this.btnThem.Icon = null;
            this.btnThem.Location = new System.Drawing.Point(25, 409);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThem.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnThem.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThem.Size = new System.Drawing.Size(80, 36);
            this.btnThem.TabIndex = 151;
            this.btnThem.Text = "Thêm";
            this.btnThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThem.UseAccentColor = false;
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rdoChuaTra);
            this.groupBox2.Controls.Add(this.rdoDaTra);
            this.groupBox2.Controls.Add(this.materialLabel2);
            this.groupBox2.Controls.Add(this.txtTenSach);
            this.groupBox2.Controls.Add(this.materialLabel10);
            this.groupBox2.Controls.Add(this.materialButton1);
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.txtMaSach);
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Controls.Add(this.listViewCTThue);
            this.groupBox2.Location = new System.Drawing.Point(489, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 465);
            this.groupBox2.TabIndex = 162;
            this.groupBox2.TabStop = false;
            // 
            // rdoChuaTra
            // 
            this.rdoChuaTra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rdoChuaTra.AutoSize = true;
            this.rdoChuaTra.Depth = 0;
            this.rdoChuaTra.Location = new System.Drawing.Point(194, 125);
            this.rdoChuaTra.Margin = new System.Windows.Forms.Padding(0);
            this.rdoChuaTra.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoChuaTra.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoChuaTra.Name = "rdoChuaTra";
            this.rdoChuaTra.Ripple = true;
            this.rdoChuaTra.Size = new System.Drawing.Size(147, 37);
            this.rdoChuaTra.TabIndex = 160;
            this.rdoChuaTra.TabStop = true;
            this.rdoChuaTra.Text = "Chưa/không trả";
            this.rdoChuaTra.UseVisualStyleBackColor = true;
            // 
            // rdoDaTra
            // 
            this.rdoDaTra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rdoDaTra.AutoSize = true;
            this.rdoDaTra.Depth = 0;
            this.rdoDaTra.Location = new System.Drawing.Point(105, 125);
            this.rdoDaTra.Margin = new System.Windows.Forms.Padding(0);
            this.rdoDaTra.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoDaTra.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoDaTra.Name = "rdoDaTra";
            this.rdoDaTra.Ripple = true;
            this.rdoDaTra.Size = new System.Drawing.Size(78, 37);
            this.rdoDaTra.TabIndex = 159;
            this.rdoDaTra.TabStop = true;
            this.rdoDaTra.Text = "Đã trả";
            this.rdoDaTra.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(24, 134);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(78, 19);
            this.materialLabel2.TabIndex = 158;
            this.materialLabel2.Text = "Trạng thái:";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenSach.AnimateReadOnly = true;
            this.txtTenSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTenSach.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTenSach.Depth = 0;
            this.txtTenSach.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.HideSelection = true;
            this.txtTenSach.LeadingIcon = null;
            this.txtTenSach.Location = new System.Drawing.Point(194, 64);
            this.txtTenSach.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtTenSach.MaxLength = 32767;
            this.txtTenSach.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtTenSach.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.PasswordChar = '\0';
            this.txtTenSach.PrefixSuffixText = null;
            this.txtTenSach.ReadOnly = false;
            this.txtTenSach.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTenSach.SelectedText = "";
            this.txtTenSach.SelectionLength = 0;
            this.txtTenSach.SelectionStart = 0;
            this.txtTenSach.ShortcutsEnabled = true;
            this.txtTenSach.Size = new System.Drawing.Size(291, 48);
            this.txtTenSach.TabIndex = 145;
            this.txtTenSach.TabStop = false;
            this.txtTenSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenSach.TrailingIcon = null;
            this.txtTenSach.UseSystemPasswordChar = false;
            // 
            // materialLabel10
            // 
            this.materialLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(191, 33);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(70, 19);
            this.materialLabel10.TabIndex = 157;
            this.materialLabel10.Text = "Tên sách:";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoa.AutoSize = false;
            this.btnXoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoa.Depth = 0;
            this.btnXoa.DrawShadows = false;
            this.btnXoa.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.HighEmphasis = true;
            this.btnXoa.Icon = null;
            this.btnXoa.Location = new System.Drawing.Point(119, 409);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoa.MaximumSize = new System.Drawing.Size(0, 36);
            this.btnXoa.MinimumSize = new System.Drawing.Size(80, 36);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoa.Size = new System.Drawing.Size(80, 36);
            this.btnXoa.TabIndex = 153;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoa.UseAccentColor = false;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaSach.AnimateReadOnly = false;
            this.txtMaSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMaSach.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaSach.Depth = 0;
            this.txtMaSach.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach.HideSelection = true;
            this.txtMaSach.LeadingIcon = null;
            this.txtMaSach.Location = new System.Drawing.Point(24, 64);
            this.txtMaSach.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtMaSach.MaxLength = 32767;
            this.txtMaSach.MinimumSize = new System.Drawing.Size(0, 48);
            this.txtMaSach.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.PasswordChar = '\0';
            this.txtMaSach.PrefixSuffixText = null;
            this.txtMaSach.ReadOnly = false;
            this.txtMaSach.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMaSach.SelectedText = "";
            this.txtMaSach.SelectionLength = 0;
            this.txtMaSach.SelectionStart = 0;
            this.txtMaSach.ShortcutsEnabled = true;
            this.txtMaSach.Size = new System.Drawing.Size(148, 48);
            this.txtMaSach.TabIndex = 144;
            this.txtMaSach.TabStop = false;
            this.txtMaSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaSach.TrailingIcon = null;
            this.txtMaSach.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(23, 33);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(66, 19);
            this.materialLabel3.TabIndex = 146;
            this.materialLabel3.Text = "Mã sách:";
            // 
            // listViewThue
            // 
            this.listViewThue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewThue.AutoSizeTable = false;
            this.listViewThue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewThue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewThue.CheckBoxes = true;
            this.listViewThue.Depth = 0;
            this.listViewThue.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewThue.FullRowSelect = true;
            this.listViewThue.HideSelection = false;
            this.listViewThue.Location = new System.Drawing.Point(27, 338);
            this.listViewThue.MinimumSize = new System.Drawing.Size(400, 150);
            this.listViewThue.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewThue.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewThue.Name = "listViewThue";
            this.listViewThue.OwnerDraw = true;
            this.listViewThue.Size = new System.Drawing.Size(450, 458);
            this.listViewThue.TabIndex = 161;
            this.listViewThue.UseCompatibleStateImageBehavior = false;
            this.listViewThue.View = System.Windows.Forms.View.Details;
            this.listViewThue.SelectedIndexChanged += new System.EventHandler(this.listViewThue_SelectedIndexChanged);
            // 
            // frmThue
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1024, 819);
            this.Controls.Add(this.listViewThue);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cboTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.groupBox2);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "frmThue";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Text = "frmThue";
            this.Load += new System.EventHandler(this.frmThue_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private MaterialSkin.Controls.MaterialComboBox cboTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox2 txtTenKH;
        private MaterialSkin.Controls.MaterialTextBox2 txtTenNV;
        private MaterialSkin.Controls.MaterialTextBox2 txtTienDatCoc;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaKH;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaThue;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtNgayThue;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaNV;
        private MaterialSkin.Controls.MaterialTextBox2 txtTimKiem;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton btnHuy;
        private MaterialSkin.Controls.MaterialButton btnLuu;
        private MaterialSkin.Controls.MaterialListView listViewCTThue;
        private MaterialSkin.Controls.MaterialButton btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton btnXoa;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaSach;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 txtTenSach;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialRadioButton rdoChuaTra;
        private MaterialSkin.Controls.MaterialRadioButton rdoDaTra;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialListView listViewThue;
    }
}
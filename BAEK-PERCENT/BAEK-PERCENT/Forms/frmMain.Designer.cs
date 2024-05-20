namespace BAEK_PERCENT
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.materialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.bangdonthue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.materialFloatingActionButton3 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.materialFloatingActionButton2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.donthue = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.tabPageSach = new System.Windows.Forms.TabPage();
            this.tabPageThue = new System.Windows.Forms.TabPage();
            this.tabPageTra = new System.Windows.Forms.TabPage();
            this.tabPageKhach = new System.Windows.Forms.TabPage();
            this.tabPageNV = new System.Windows.Forms.TabPage();
            this.tabPageTG = new System.Windows.Forms.TabPage();
            this.tabPageLV = new System.Windows.Forms.TabPage();
            this.tabPageLoai = new System.Windows.Forms.TabPage();
            this.tabPageNN = new System.Windows.Forms.TabPage();
            this.tabPageVP = new System.Windows.Forms.TabPage();
            this.tabPageTK = new System.Windows.Forms.TabPage();
            this.tabPageTT = new System.Windows.Forms.TabPage();
            this.start = new System.Windows.Forms.DateTimePicker();
            this.end = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Loc = new System.Windows.Forms.ComboBox();
            this.materialTabControl.SuspendLayout();
            this.tabPageHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bangdonthue)).BeginInit();
            this.materialCard3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl
            // 
            this.materialTabControl.Controls.Add(this.tabPageHome);
            this.materialTabControl.Controls.Add(this.tabPageSach);
            this.materialTabControl.Controls.Add(this.tabPageThue);
            this.materialTabControl.Controls.Add(this.tabPageTra);
            this.materialTabControl.Controls.Add(this.tabPageKhach);
            this.materialTabControl.Controls.Add(this.tabPageNV);
            this.materialTabControl.Controls.Add(this.tabPageTG);
            this.materialTabControl.Controls.Add(this.tabPageLV);
            this.materialTabControl.Controls.Add(this.tabPageLoai);
            this.materialTabControl.Controls.Add(this.tabPageNN);
            this.materialTabControl.Controls.Add(this.tabPageVP);
            this.materialTabControl.Controls.Add(this.tabPageTK);
            this.materialTabControl.Controls.Add(this.tabPageTT);
            this.materialTabControl.Depth = 0;
            this.materialTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl.ImageList = this.imageList1;
            this.materialTabControl.Location = new System.Drawing.Point(0, 80);
            this.materialTabControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.materialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl.Multiline = true;
            this.materialTabControl.Name = "materialTabControl";
            this.materialTabControl.SelectedIndex = 0;
<<<<<<< Updated upstream
            this.materialTabControl.Size = new System.Drawing.Size(1276, 917);
=======
            this.materialTabControl.Size = new System.Drawing.Size(1340, 1017);
>>>>>>> Stashed changes
            this.materialTabControl.TabIndex = 0;
            this.materialTabControl.SelectedIndexChanged += new System.EventHandler(this.mainTabControl_SelectedIndexChanged);
            // 
            // tabPageHome
            // 
            this.tabPageHome.Controls.Add(this.Loc);
            this.tabPageHome.Controls.Add(this.textBox1);
            this.tabPageHome.Controls.Add(this.end);
            this.tabPageHome.Controls.Add(this.start);
            this.tabPageHome.Controls.Add(this.bangdonthue);
            this.tabPageHome.Controls.Add(this.materialCard3);
            this.tabPageHome.Controls.Add(this.materialCard2);
            this.tabPageHome.Controls.Add(this.materialCard1);
            this.tabPageHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageHome.ImageKey = "HomeIcon.png";
            this.tabPageHome.Location = new System.Drawing.Point(4, 31);
            this.tabPageHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
<<<<<<< Updated upstream
            this.tabPageHome.Size = new System.Drawing.Size(1268, 882);
=======
            this.tabPageHome.Size = new System.Drawing.Size(1332, 982);
>>>>>>> Stashed changes
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Trang chủ";
            this.tabPageHome.UseVisualStyleBackColor = true;
            this.tabPageHome.Click += new System.EventHandler(this.tabPageHome_Click);
            // 
            // bangdonthue
            // 
            chartArea2.Name = "ChartArea1";
            this.bangdonthue.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.bangdonthue.Legends.Add(legend2);
            this.bangdonthue.Location = new System.Drawing.Point(357, 75);
            this.bangdonthue.Name = "bangdonthue";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.bangdonthue.Series.Add(series2);
            this.bangdonthue.Size = new System.Drawing.Size(861, 642);
            this.bangdonthue.TabIndex = 6;
            this.bangdonthue.Text = "chart1";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.label5);
            this.materialCard3.Controls.Add(this.label6);
            this.materialCard3.Controls.Add(this.materialFloatingActionButton3);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(43, 546);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(260, 171);
            this.materialCard3.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số đơn thuê tháng này";
            // 
            // materialFloatingActionButton3
            // 
            this.materialFloatingActionButton3.Depth = 0;
            this.materialFloatingActionButton3.Icon = ((System.Drawing.Image)(resources.GetObject("materialFloatingActionButton3.Icon")));
            this.materialFloatingActionButton3.ImageIndex = 12;
            this.materialFloatingActionButton3.ImageList = this.imageList1;
            this.materialFloatingActionButton3.Location = new System.Drawing.Point(187, 98);
            this.materialFloatingActionButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton3.Name = "materialFloatingActionButton3";
            this.materialFloatingActionButton3.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton3.TabIndex = 1;
            this.materialFloatingActionButton3.Text = "materialFloatingActionButton3";
            this.materialFloatingActionButton3.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "HomeIcon.png");
            this.imageList1.Images.SetKeyName(1, "KhachHangIcon.png");
            this.imageList1.Images.SetKeyName(2, "LinhVucIcon.png");
            this.imageList1.Images.SetKeyName(3, "LoaiSachIcon.png");
            this.imageList1.Images.SetKeyName(4, "NgonNguIcon.png");
            this.imageList1.Images.SetKeyName(5, "NhanVienIcon.png");
            this.imageList1.Images.SetKeyName(6, "SachTruyenIcon.png");
            this.imageList1.Images.SetKeyName(7, "TacGiaIcon.png");
            this.imageList1.Images.SetKeyName(8, "TaiKhoanIcon.png");
            this.imageList1.Images.SetKeyName(9, "ThueSachIcon.png");
            this.imageList1.Images.SetKeyName(10, "TraSachIcon.png");
            this.imageList1.Images.SetKeyName(11, "ViPhamIcon.png");
            this.imageList1.Images.SetKeyName(12, "LogoutIcon.png");
            this.imageList1.Images.SetKeyName(13, "ThongTinIcon.png");
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.label3);
            this.materialCard2.Controls.Add(this.label4);
            this.materialCard2.Controls.Add(this.materialFloatingActionButton2);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(43, 288);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(260, 171);
            this.materialCard2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số đơn thuê tháng này";
            // 
            // materialFloatingActionButton2
            // 
            this.materialFloatingActionButton2.Depth = 0;
            this.materialFloatingActionButton2.Icon = ((System.Drawing.Image)(resources.GetObject("materialFloatingActionButton2.Icon")));
            this.materialFloatingActionButton2.ImageIndex = 12;
            this.materialFloatingActionButton2.ImageList = this.imageList1;
            this.materialFloatingActionButton2.Location = new System.Drawing.Point(187, 98);
            this.materialFloatingActionButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton2.Name = "materialFloatingActionButton2";
            this.materialFloatingActionButton2.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton2.TabIndex = 1;
            this.materialFloatingActionButton2.Text = "materialFloatingActionButton2";
            this.materialFloatingActionButton2.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.donthue);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(43, 34);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(260, 171);
            this.materialCard1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số đơn thuê tháng này";
            // 
            // donthue
            // 
            this.donthue.Depth = 0;
            this.donthue.Icon = ((System.Drawing.Image)(resources.GetObject("donthue.Icon")));
            this.donthue.ImageIndex = 12;
            this.donthue.ImageList = this.imageList1;
            this.donthue.Location = new System.Drawing.Point(187, 98);
            this.donthue.MouseState = MaterialSkin.MouseState.HOVER;
            this.donthue.Name = "donthue";
            this.donthue.Size = new System.Drawing.Size(56, 56);
            this.donthue.TabIndex = 1;
            this.donthue.Text = "materialFloatingActionButton1";
            this.donthue.UseVisualStyleBackColor = true;
            this.donthue.Click += new System.EventHandler(this.donthue_Click);
            // 
            // tabPageSach
            // 
            this.tabPageSach.BackColor = System.Drawing.Color.Transparent;
            this.tabPageSach.ImageKey = "SachTruyenIcon.png";
            this.tabPageSach.Location = new System.Drawing.Point(4, 31);
            this.tabPageSach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageSach.Name = "tabPageSach";
<<<<<<< Updated upstream
            this.tabPageSach.Size = new System.Drawing.Size(1300, 920);
=======
            this.tabPageSach.Size = new System.Drawing.Size(1316, 959);
>>>>>>> Stashed changes
            this.tabPageSach.TabIndex = 1;
            this.tabPageSach.Text = "Sách truyện";
            // 
            // tabPageThue
            // 
            this.tabPageThue.ImageKey = "ThueSachIcon.png";
            this.tabPageThue.Location = new System.Drawing.Point(4, 31);
            this.tabPageThue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageThue.Name = "tabPageThue";
<<<<<<< Updated upstream
            this.tabPageThue.Size = new System.Drawing.Size(1300, 920);
=======
            this.tabPageThue.Size = new System.Drawing.Size(1316, 959);
>>>>>>> Stashed changes
            this.tabPageThue.TabIndex = 2;
            this.tabPageThue.Text = "Thuê sách";
            this.tabPageThue.UseVisualStyleBackColor = true;
            // 
            // tabPageTra
            // 
            this.tabPageTra.ImageKey = "TraSachIcon.png";
            this.tabPageTra.Location = new System.Drawing.Point(4, 31);
            this.tabPageTra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageTra.Name = "tabPageTra";
<<<<<<< Updated upstream
            this.tabPageTra.Size = new System.Drawing.Size(1300, 920);
=======
            this.tabPageTra.Size = new System.Drawing.Size(1316, 959);
>>>>>>> Stashed changes
            this.tabPageTra.TabIndex = 3;
            this.tabPageTra.Text = "Trả sách";
            this.tabPageTra.UseVisualStyleBackColor = true;
            // 
            // tabPageKhach
            // 
            this.tabPageKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageKhach.ImageKey = "KhachHangIcon.png";
            this.tabPageKhach.Location = new System.Drawing.Point(4, 31);
            this.tabPageKhach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageKhach.Name = "tabPageKhach";
<<<<<<< Updated upstream
            this.tabPageKhach.Size = new System.Drawing.Size(1300, 920);
=======
            this.tabPageKhach.Size = new System.Drawing.Size(1316, 959);
>>>>>>> Stashed changes
            this.tabPageKhach.TabIndex = 4;
            this.tabPageKhach.Text = "Khách hàng";
            this.tabPageKhach.UseVisualStyleBackColor = true;
            // 
            // tabPageNV
            // 
            this.tabPageNV.ImageKey = "NhanVienIcon.png";
            this.tabPageNV.Location = new System.Drawing.Point(4, 31);
            this.tabPageNV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageNV.Name = "tabPageNV";
<<<<<<< Updated upstream
            this.tabPageNV.Size = new System.Drawing.Size(1300, 920);
=======
            this.tabPageNV.Size = new System.Drawing.Size(1316, 959);
>>>>>>> Stashed changes
            this.tabPageNV.TabIndex = 5;
            this.tabPageNV.Text = "Nhân viên";
            this.tabPageNV.UseVisualStyleBackColor = true;
            // 
            // tabPageTG
            // 
            this.tabPageTG.ImageKey = "TacGiaIcon.png";
            this.tabPageTG.Location = new System.Drawing.Point(4, 31);
            this.tabPageTG.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageTG.Name = "tabPageTG";
<<<<<<< Updated upstream
            this.tabPageTG.Size = new System.Drawing.Size(1300, 920);
=======
            this.tabPageTG.Size = new System.Drawing.Size(1316, 959);
>>>>>>> Stashed changes
            this.tabPageTG.TabIndex = 6;
            this.tabPageTG.Text = "Tác giả";
            this.tabPageTG.UseVisualStyleBackColor = true;
            // 
            // tabPageLV
            // 
            this.tabPageLV.AutoScroll = true;
            this.tabPageLV.BackColor = System.Drawing.Color.Transparent;
            this.tabPageLV.ImageKey = "LinhVucIcon.png";
            this.tabPageLV.Location = new System.Drawing.Point(4, 31);
            this.tabPageLV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageLV.Name = "tabPageLV";
<<<<<<< Updated upstream
            this.tabPageLV.Size = new System.Drawing.Size(1300, 920);
=======
            this.tabPageLV.Size = new System.Drawing.Size(1316, 959);
>>>>>>> Stashed changes
            this.tabPageLV.TabIndex = 7;
            this.tabPageLV.Text = "Lĩnh vực";
            // 
            // tabPageLoai
            // 
            this.tabPageLoai.ImageKey = "LoaiSachIcon.png";
            this.tabPageLoai.Location = new System.Drawing.Point(4, 31);
            this.tabPageLoai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageLoai.Name = "tabPageLoai";
<<<<<<< Updated upstream
            this.tabPageLoai.Size = new System.Drawing.Size(1300, 920);
=======
            this.tabPageLoai.Size = new System.Drawing.Size(1316, 959);
>>>>>>> Stashed changes
            this.tabPageLoai.TabIndex = 8;
            this.tabPageLoai.Text = "Loại sách";
            this.tabPageLoai.UseVisualStyleBackColor = true;
            // 
            // tabPageNN
            // 
            this.tabPageNN.ImageKey = "NgonNguIcon.png";
            this.tabPageNN.Location = new System.Drawing.Point(4, 31);
            this.tabPageNN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageNN.Name = "tabPageNN";
<<<<<<< Updated upstream
            this.tabPageNN.Size = new System.Drawing.Size(1300, 920);
=======
            this.tabPageNN.Size = new System.Drawing.Size(1316, 959);
>>>>>>> Stashed changes
            this.tabPageNN.TabIndex = 9;
            this.tabPageNN.Text = "Ngôn ngữ";
            this.tabPageNN.UseVisualStyleBackColor = true;
            // 
            // tabPageVP
            // 
            this.tabPageVP.ImageKey = "ViPhamIcon.png";
            this.tabPageVP.Location = new System.Drawing.Point(4, 31);
            this.tabPageVP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageVP.Name = "tabPageVP";
<<<<<<< Updated upstream
            this.tabPageVP.Size = new System.Drawing.Size(1300, 920);
=======
            this.tabPageVP.Size = new System.Drawing.Size(1316, 959);
>>>>>>> Stashed changes
            this.tabPageVP.TabIndex = 10;
            this.tabPageVP.Text = "Vi phạm";
            this.tabPageVP.UseVisualStyleBackColor = true;
            // 
            // tabPageTK
            // 
            this.tabPageTK.ImageKey = "TaiKhoanIcon.png";
            this.tabPageTK.Location = new System.Drawing.Point(4, 31);
            this.tabPageTK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageTK.Name = "tabPageTK";
<<<<<<< Updated upstream
            this.tabPageTK.Size = new System.Drawing.Size(1300, 920);
=======
            this.tabPageTK.Size = new System.Drawing.Size(1316, 959);
>>>>>>> Stashed changes
            this.tabPageTK.TabIndex = 11;
            this.tabPageTK.Text = "Tài khoản";
            this.tabPageTK.UseVisualStyleBackColor = true;
            // 
            // tabPageTT
            // 
            this.tabPageTT.ImageKey = "ThongTinIcon.png";
            this.tabPageTT.Location = new System.Drawing.Point(4, 31);
            this.tabPageTT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageTT.Name = "tabPageTT";
<<<<<<< Updated upstream
            this.tabPageTT.Size = new System.Drawing.Size(1300, 920);
=======
            this.tabPageTT.Size = new System.Drawing.Size(1316, 959);
>>>>>>> Stashed changes
            this.tabPageTT.TabIndex = 12;
            this.tabPageTT.Text = "Thông tin";
            this.tabPageTT.UseVisualStyleBackColor = true;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(435, 34);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(200, 21);
            this.start.TabIndex = 7;
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(796, 34);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(200, 21);
            this.end.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 9;
            // 
            // Loc
            // 
            this.Loc.FormattingEnabled = true;
            this.Loc.Items.AddRange(new object[] {
            "Ngày",
            "Tháng",
            "Năm"});
            this.Loc.Location = new System.Drawing.Point(1097, 32);
            this.Loc.Name = "Loc";
            this.Loc.Size = new System.Drawing.Size(121, 23);
            this.Loc.TabIndex = 10;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< Updated upstream
            this.ClientSize = new System.Drawing.Size(1280, 1000);
=======
            this.ClientSize = new System.Drawing.Size(1344, 1100);
>>>>>>> Stashed changes
            this.Controls.Add(this.materialTabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl;
            this.DrawerWidth = 250;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_56;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1200, 960);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(0, 80, 4, 3);
            this.Text = "BAEK-PERCENT";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.atEnd_frmMain_Shown);
            this.VisibleChanged += new System.EventHandler(this.frmMain_VisibleChanged);
            this.materialTabControl.ResumeLayout(false);
            this.tabPageHome.ResumeLayout(false);
            this.tabPageHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bangdonthue)).EndInit();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPageThue;
        private System.Windows.Forms.TabPage tabPageTra;
        private System.Windows.Forms.TabPage tabPageKhach;
        private System.Windows.Forms.TabPage tabPageNV;
        private System.Windows.Forms.TabPage tabPageTG;
        private System.Windows.Forms.TabPage tabPageLV;
        private System.Windows.Forms.TabPage tabPageLoai;
        private System.Windows.Forms.TabPage tabPageNN;
        private System.Windows.Forms.TabPage tabPageVP;
        private System.Windows.Forms.TabPage tabPageTK;
        private MaterialSkin.Controls.MaterialFloatingActionButton donthue;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton3;
        private System.Windows.Forms.TabPage tabPageSach;
        private System.Windows.Forms.TabPage tabPageTT;
        private System.Windows.Forms.DataVisualization.Charting.Chart bangdonthue;
        private System.Windows.Forms.DateTimePicker end;
        private System.Windows.Forms.DateTimePicker start;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox Loc;
    }
}


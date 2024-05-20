namespace BAEK_PERCENT.Forms
{
    partial class frmHome
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.Loc = new System.Windows.Forms.ComboBox();
            this.end = new System.Windows.Forms.DateTimePicker();
            this.start = new System.Windows.Forms.DateTimePicker();
            this.bangdonthue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.materialFloatingActionButton3 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.materialFloatingActionButton2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.donthue = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.swtDarkMode = new MaterialSkin.Controls.MaterialSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.bangdonthue)).BeginInit();
            this.materialCard3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Loc
            // 
            this.Loc.FormattingEnabled = true;
            this.Loc.Items.AddRange(new object[] {
            "Ngày",
            "Tháng",
            "Năm"});
            this.Loc.Location = new System.Drawing.Point(839, 93);
            this.Loc.Name = "Loc";
            this.Loc.Size = new System.Drawing.Size(121, 21);
            this.Loc.TabIndex = 17;
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(583, 93);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(200, 20);
            this.end.TabIndex = 16;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(370, 93);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(200, 20);
            this.start.TabIndex = 15;
            // 
            // bangdonthue
            // 
            chartArea3.Name = "ChartArea1";
            this.bangdonthue.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.bangdonthue.Legends.Add(legend3);
            this.bangdonthue.Location = new System.Drawing.Point(370, 126);
            this.bangdonthue.Name = "bangdonthue";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.bangdonthue.Series.Add(series3);
            this.bangdonthue.Size = new System.Drawing.Size(590, 450);
            this.bangdonthue.TabIndex = 14;
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
            this.materialCard3.Location = new System.Drawing.Point(49, 469);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(260, 171);
            this.materialCard3.TabIndex = 13;
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
            this.materialFloatingActionButton3.Location = new System.Drawing.Point(187, 98);
            this.materialFloatingActionButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton3.Name = "materialFloatingActionButton3";
            this.materialFloatingActionButton3.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton3.TabIndex = 1;
            this.materialFloatingActionButton3.Text = "materialFloatingActionButton3";
            this.materialFloatingActionButton3.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.label3);
            this.materialCard2.Controls.Add(this.label4);
            this.materialCard2.Controls.Add(this.materialFloatingActionButton2);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(49, 270);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(260, 171);
            this.materialCard2.TabIndex = 12;
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
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(49, 71);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(260, 171);
            this.materialCard1.TabIndex = 11;
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
            this.donthue.Icon = null;
            this.donthue.ImageIndex = 12;
            this.donthue.Location = new System.Drawing.Point(904, 582);
            this.donthue.MouseState = MaterialSkin.MouseState.HOVER;
            this.donthue.Name = "donthue";
            this.donthue.Size = new System.Drawing.Size(56, 56);
            this.donthue.TabIndex = 1;
            this.donthue.Text = "materialFloatingActionButton1";
            this.donthue.UseVisualStyleBackColor = true;
            this.donthue.Click += new System.EventHandler(this.donthue_Click);
            // 
            // swtDarkMode
            // 
            this.swtDarkMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.swtDarkMode.AutoSize = true;
            this.swtDarkMode.Depth = 0;
            this.swtDarkMode.Location = new System.Drawing.Point(867, 20);
            this.swtDarkMode.Margin = new System.Windows.Forms.Padding(0);
            this.swtDarkMode.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swtDarkMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.swtDarkMode.Name = "swtDarkMode";
            this.swtDarkMode.Ripple = true;
            this.swtDarkMode.Size = new System.Drawing.Size(135, 37);
            this.swtDarkMode.TabIndex = 18;
            this.swtDarkMode.Text = "Dark mode";
            this.swtDarkMode.UseVisualStyleBackColor = true;
            this.swtDarkMode.CheckedChanged += new System.EventHandler(this.swtDarkMode_CheckedChanged);
            // 
            // frmHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1024, 819);
            this.Controls.Add(this.swtDarkMode);
            this.Controls.Add(this.Loc);
            this.Controls.Add(this.donthue);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.bangdonthue);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "frmHome";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Text = "frmHome";
            ((System.ComponentModel.ISupportInitialize)(this.bangdonthue)).EndInit();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Loc;
        private System.Windows.Forms.DateTimePicker end;
        private System.Windows.Forms.DateTimePicker start;
        private System.Windows.Forms.DataVisualization.Charting.Chart bangdonthue;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton3;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialFloatingActionButton donthue;
        private MaterialSkin.Controls.MaterialSwitch swtDarkMode;
    }
}
namespace BAEK_PERCENT.Forms
{
    partial class frmThongTin
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
            this.logOutBtn = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // logOutBtn
            // 
            this.logOutBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logOutBtn.BackColor = System.Drawing.Color.Coral;
            this.logOutBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.logOutBtn.Depth = 0;
            this.logOutBtn.ForeColor = System.Drawing.Color.IndianRed;
            this.logOutBtn.HighEmphasis = true;
            this.logOutBtn.Icon = null;
            this.logOutBtn.Location = new System.Drawing.Point(90, 154);
            this.logOutBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.logOutBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.logOutBtn.Size = new System.Drawing.Size(82, 36);
            this.logOutBtn.TabIndex = 1;
            this.logOutBtn.Text = "Log out";
            this.logOutBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.logOutBtn.UseAccentColor = false;
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // frmThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logOutBtn);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "frmThongTin";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Text = "frmThongTin";
            this.Load += new System.EventHandler(this.frmThongTin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton logOutBtn;
    }
}
using System;

using MaterialSkin.Controls;

namespace BAEK_PERCENT.Forms
{
    public partial class frmThongTin : MaterialForm
    {
        public frmThongTin()
        {
            InitializeComponent();
        }

        private void frmThongTin_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Program.FormControl.CurrentForm
                = Program.FormControl.loginForm;
        }
    }
}

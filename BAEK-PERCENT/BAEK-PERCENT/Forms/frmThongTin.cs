using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
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

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Program.FormControl.CurrentForm
                = Program.FormControl.loginForm;
        }
    }
}

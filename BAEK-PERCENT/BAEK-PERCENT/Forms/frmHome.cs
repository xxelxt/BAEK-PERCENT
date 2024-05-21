using System;
using System.Drawing;

using MaterialSkin;
using MaterialSkin.Controls;

namespace BAEK_PERCENT.Forms
{
    public partial class frmHome : MaterialForm
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void swtDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (swtDarkMode.Checked)
            {
                EnableDarkMode();
            }
            else
            {
                EnableLightMode();
            }
        }

        private MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        private void EnableDarkMode()
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            var darkestColorScheme = new ColorScheme(
                Color.FromArgb(12, 12, 12),        // Darkest Gray
                Color.FromArgb(8, 8, 8),           // Darkest Black
                Color.FromArgb(18, 18, 18),        // Very Dark Gray
                Color.FromArgb(255, 150, 79),      // Orange
                TextShade.WHITE
            );
            materialSkinManager.ColorScheme = darkestColorScheme;

        }

        private void EnableLightMode()
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            var lightColorScheme = new ColorScheme(
                Color.FromArgb(255, 255, 255),     // White
                Color.FromArgb(240, 240, 240),     // Light Gray
                Color.FromArgb(255, 255, 255),     // White
                Color.FromArgb(255, 150, 79),      // Orange
                TextShade.BLACK
            );
            materialSkinManager.ColorScheme = lightColorScheme;
        }
    }
}
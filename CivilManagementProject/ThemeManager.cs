using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CivilManagementProject
{
    internal class ThemeManager
    {
        public static bool IsDarkMode { get; private set; } = false;

        // Color Palette
        private static readonly Color LightBg = Color.FromArgb(245, 245, 245);
        private static readonly Color LightFg = Color.FromArgb(20, 20, 20);
        private static readonly Color LightCard = Color.White;

        private static readonly Color DarkBg = Color.FromArgb(32, 32, 32);
        private static readonly Color DarkFg = Color.FromArgb(240, 240, 240);
        private static readonly Color DarkCard = Color.FromArgb(45, 45, 45);

        public static void ToggleTheme(Form form)
        {
            IsDarkMode = !IsDarkMode;
            ApplyTheme(form);
        }

        public static void ApplyTheme(Control control)
        {
            Color bg = IsDarkMode ? DarkBg : LightBg;
            Color fg = IsDarkMode ? DarkFg : LightFg;
            Color cardBg = IsDarkMode ? DarkCard : LightCard;

            if (control is Form form)
            {
                form.BackColor = bg;
                form.ForeColor = fg;
            }

            foreach (Control c in control.Controls)
            {
                // Update controls based on type
                if (c is Button || c is TextBox || c is Panel || c is GroupBox)
                {
                    c.BackColor = cardBg;
                    c.ForeColor = fg;
                }
                else if (c is Label || c is CheckBox || c is RadioButton)
                {
                    c.BackColor = Color.Transparent;
                    c.ForeColor = fg;
                }
                else if(c is DataGridView dgv){
                    dgv.BackgroundColor = cardBg;
                    dgv.DefaultCellStyle.BackColor = cardBg;
                    dgv.DefaultCellStyle.ForeColor = fg;
                    dgv.GridColor = IsDarkMode ? Color.Gray : Color.LightGray;
                }

                // Recursively update nested controls (Panels, GroupBoxes, etc.)
                if (c.HasChildren)
                {
                    ApplyTheme(c);
                }
            }
        }
    }
}

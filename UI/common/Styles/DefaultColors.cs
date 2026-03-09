using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.common.Styles;

namespace UI.common
{
    public static class DefaultColors
    {
        // Brand Primary colors remain largely same, maybe slightly tweaked for contrast in dark mode
        public static Color Primary => ThemeManager.IsDarkMode ? ColorTranslator.FromHtml("#1D4ED8") : ColorTranslator.FromHtml("#06406A");
        public static Color PrimaryMid => ThemeManager.IsDarkMode ? ColorTranslator.FromHtml("#2563EB") : ColorTranslator.FromHtml("#0A5C99");

        // Backgrounds
        public static Color BgPanel => ThemeManager.IsDarkMode ? Color.FromArgb(30, 41, 59) : Color.WhiteSmoke;
        public static Color InputBg => ThemeManager.IsDarkMode ? Color.FromArgb(51, 65, 85) : Color.FromArgb(248, 250, 252);
        public static Color ButtonSecondaryBg => ThemeManager.IsDarkMode ? Color.FromArgb(71, 85, 105) : Color.FromArgb(241, 245, 249);
        
        // Text
        public static Color TextPrimary => ThemeManager.IsDarkMode ? Color.FromArgb(241, 245, 249) : Color.FromArgb(31, 41, 55);
        public static Color TextSecondary => ThemeManager.IsDarkMode ? Color.FromArgb(148, 163, 184) : Color.FromArgb(100, 116, 139);

        // Borders & Lines
        public static Color LineColor => ThemeManager.IsDarkMode ? Color.FromArgb(71, 85, 105) : Color.FromArgb(217, 226, 236);
        public static Color GridLines => ThemeManager.IsDarkMode ? Color.FromArgb(51, 65, 85) : Color.FromArgb(217, 226, 236);

        // DataGrid Specific
        public static Color RowAlt => ThemeManager.IsDarkMode ? Color.FromArgb(15, 23, 42) : Color.FromArgb(238, 243, 247);
    }
}

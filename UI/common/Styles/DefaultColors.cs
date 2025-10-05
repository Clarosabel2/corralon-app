using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.common
{
    public static class DefaultColors
    {
        public static readonly Color Primary = ColorTranslator.FromHtml("#06406A");
        public static readonly Color PrimaryMid = ColorTranslator.FromHtml("#0A5C99");
        public static readonly Color RowAlt = ColorTranslator.FromHtml("#EEF3F7");
        public static readonly Color GridLines = ColorTranslator.FromHtml("#D9E2EC");

        public static readonly Color BgPanel = Color.WhiteSmoke;
        public static readonly Color TextPrimary = Color.FromArgb(31, 41, 55);   // gris oscuro
        public static readonly Color LineColor = Color.FromArgb(217, 226, 236); // línea sutil
    }
}

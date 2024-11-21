using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace UI.Controls
{
    public class MenuRenderer : ToolStripProfessionalRenderer
    {
        private Color _primaryColor;
        private Color _textColor;
        private int _arrowThickness;

        public MenuRenderer(bool isMain, Color primaryColor, Color textColor) : base(new MenuColorTable(isMain, primaryColor))
        {
            this._primaryColor = primaryColor;
            this._textColor = textColor;
            if (isMain) _arrowThickness = 3;
            else _arrowThickness = 2;
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            base.OnRenderItemText(e);
            e.Item.ForeColor = e.Item.Selected ? Color.White : _primaryColor;
        }

        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            base.OnRenderArrow(e);
            var graph = e.Graphics;
            var arrowSize = new Size(5, 12);
            var arrowColor = e.Item.Selected ? Color.White : _primaryColor;
            var rect = new Rectangle(e.ArrowRectangle.Location.X,
                (e.ArrowRectangle.Height - arrowSize.Height) / 2,
                arrowSize.Width,
                arrowSize.Height);
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(arrowColor, _arrowThickness))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rect.Left, rect.Top, rect.Right, rect.Top + rect.Height / 2);
                path.AddLine(rect.Right, rect.Top + rect.Right/2, rect.Left, rect.Top + rect.Height);
                graph.DrawPath(pen, path);
            }
        }
    }
}

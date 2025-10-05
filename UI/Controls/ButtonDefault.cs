using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using UI.common;

namespace UI.Controls
{
    public class ButtonDefault : System.Windows.Forms.Button
    {
        public ButtonDefault()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = DefaultColors.Primary;
            this.ForeColor = Color.White;
            this.Font = new Font("Century Gothic", 10.5f, FontStyle.Bold);
            this.Size = new Size(118, 36);
            this.Cursor = Cursors.Hand;
            this.DoubleBuffered = true; // reduce parpadeo
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);

            if (this.Enabled)
            {
                // estilo normal
                this.BackColor = DefaultColors.Primary;
                this.ForeColor = Color.White;
                this.Cursor = Cursors.Hand;
            }
            else
            {
                // estilo deshabilitado
                this.BackColor = Color.Gray;
                this.ForeColor = Color.LightGray;
                this.Cursor = Cursors.Default;
            }
        }
    }
}


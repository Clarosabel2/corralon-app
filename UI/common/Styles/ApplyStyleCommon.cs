using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.common.Styles
{
    public static class ApplyStyleCommon
    {
        public static void DGVStyle(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 18f, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = DefaultColors.Primary;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(12, 10, 12, 10);
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersHeight = 50;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgv.DefaultCellStyle.Font = new Font("Century Gothic", 15f, FontStyle.Regular);
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = DefaultColors.PrimaryMid;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.DefaultCellStyle.Padding = new Padding(12, 8, 12, 8);
            dgv.RowTemplate.Height = 38;

            // Alternancia sutil (zebra)
            dgv.AlternatingRowsDefaultCellStyle.BackColor = DefaultColors.RowAlt;

            // ===== Bordes y líneas minimalistas =====
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = DefaultColors.GridLines;                           
            dgv.RowHeadersVisible = false;                                     

            // ===== Comportamiento profesional =====
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToResizeRows = false;
            foreach (DataGridViewColumn c in dgv.Columns)
            {
                c.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
                c.DefaultCellStyle.NullValue = "";                       
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            foreach (DataGridViewColumn c in dgv.Columns)
            {
                if (c is DataGridViewButtonColumn btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.DefaultCellStyle.BackColor = Color.White;
                    btn.DefaultCellStyle.ForeColor = DefaultColors.Primary;
                    btn.DefaultCellStyle.SelectionBackColor = Color.White;
                    btn.DefaultCellStyle.SelectionForeColor = DefaultColors.Primary;
                }
            }
        }

        

        public static void ButtonStyle(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = DefaultColors.Primary;        // #06406A
            btn.ForeColor = Color.White;
            btn.Font = new Font("Century Gothic", 10.5f, FontStyle.Bold);
            btn.Height = 36;
            btn.Cursor = Cursors.Hand;
            btn.FlatAppearance.MouseOverBackColor = DefaultColors.PrimaryMid; // #0A5C99
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.common.Utils
{
    public static class DGVHelper
    {
        public static void AddNewDGVColumnToDGV(
            DataGridViewColumn col,
            string headerText,
            string name,
            DataGridViewAutoSizeColumnMode sizeMode,
            DataGridView dgv,
            Image staticImageIfImageCol = null,
            DataGridViewImageCellLayout layout = DataGridViewImageCellLayout.Zoom,
            int? fixedWidth = null,
            bool bindTextColumns = true     
        )
        {
            if (col == null) throw new ArgumentNullException(nameof(col));
            if (dgv == null) throw new ArgumentNullException(nameof(dgv));

            col.HeaderText = headerText ?? "";
            col.Name = name ?? "";
            col.ReadOnly = true;

            if (col is DataGridViewImageColumn imgCol)
            {
                imgCol.ImageLayout = layout;
                imgCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                imgCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                imgCol.Width = fixedWidth ?? 64;

                if (staticImageIfImageCol != null)
                {
                    imgCol.Image = staticImageIfImageCol;
                    imgCol.DataPropertyName = null;
                }
                else
                {
                    imgCol.DataPropertyName = null;
                }
            }
            else
            {
         
                col.AutoSizeMode = sizeMode;
                col.DataPropertyName = bindTextColumns ? name : null;
            }

            dgv.Columns.Add(col);
        }
    }
}

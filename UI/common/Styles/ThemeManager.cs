using System;
using System.Drawing;

namespace UI.common.Styles
{
    public static class ThemeManager
    {
        public static event EventHandler OnThemeChanged;

        private static bool _isDarkMode = false;
        public static bool IsDarkMode
        {
            get { return _isDarkMode; }
            set
            {
                if (_isDarkMode != value)
                {
                    _isDarkMode = value;
                    OnThemeChanged?.Invoke(null, EventArgs.Empty);
                }
            }
        }

        public static void ApplyTheme(System.Windows.Forms.Control.ControlCollection controls)
        {
            foreach (System.Windows.Forms.Control control in controls)
            {
                ApplyThemeToControl(control);
                if (control.HasChildren)
                {
                    ApplyTheme(control.Controls);
                }
            }
        }

        private static void ApplyThemeToControl(System.Windows.Forms.Control control)
        {
            // Apply standard background and foreground colors
            
            if (control is System.Windows.Forms.Panel || 
                control is System.Windows.Forms.FlowLayoutPanel || 
                control is System.Windows.Forms.TableLayoutPanel)
            {
                // Solo cambiar paneles genéricos u oscuros, no los que tienen color custom en diseño
                // como el panelMenu o el pnlHeader. Por ahora setearemos BackColor a BgPanel para
                // los que sean Control o White o parecidos.
                if (control.BackColor == Color.White || control.BackColor == Color.WhiteSmoke || control.BackColor == Color.FromArgb(245, 247, 250) || control.BackColor == Color.FromArgb(248, 250, 252) || control.BackColor == Color.LightGray || control.BackColor == Color.Gainsboro || control.BackColor == Color.FromArgb(30, 30, 30))
                {
                     control.BackColor = DefaultColors.BgPanel;
                }
                
                // FormMain specific: Left menu and Top bar - Let's keep them their original color 
                // but the content panels will be themed.
            }
            else if (control is System.Windows.Forms.Label || 
                     control is System.Windows.Forms.CheckBox || 
                     control is System.Windows.Forms.RadioButton || 
                     control is System.Windows.Forms.GroupBox)
            {
                control.ForeColor = DefaultColors.TextPrimary;
                if (control is System.Windows.Forms.GroupBox)
                {
                    control.BackColor = DefaultColors.BgPanel;
                }
            }
            else if (control is System.Windows.Forms.TextBox || 
                     control is System.Windows.Forms.ComboBox || 
                     control is System.Windows.Forms.NumericUpDown)
            {
                control.BackColor = DefaultColors.InputBg;
                control.ForeColor = DefaultColors.TextPrimary;
                
                if (control is System.Windows.Forms.TextBox txt)
                {
                    txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                }
            }
            else if (control is System.Windows.Forms.Button btn)
            {
                // Refrescar botones ya aplicar el estilo genérico si aplica
                if (btn.FlatStyle == System.Windows.Forms.FlatStyle.Flat)
                {
                    if (btn.BackColor == Color.FromArgb(16, 163, 74) || btn.BackColor == Color.FromArgb(22, 163, 74) || btn.BackColor == Color.FromArgb(220, 38, 38) || btn.BackColor == Color.FromArgb(4, 41, 60))
                        return; // Keep specialized button colors (Action buttons, menu sidebar buttons)
                    
                    if (btn.Name.StartsWith("btnCancel") || btn.BackColor == Color.FromArgb(241, 245, 249))
                    {
                        btn.BackColor = DefaultColors.ButtonSecondaryBg;
                        btn.ForeColor = DefaultColors.TextPrimary;
                    }
                    else
                    {
                        // Standard Primary buttons
                        btn.BackColor = DefaultColors.Primary;
                        btn.ForeColor = Color.White;
                    }
                }
            }
            else if (control is System.Windows.Forms.DataGridView dgv)
            {
                dgv.BackgroundColor = DefaultColors.BgPanel;
                
                dgv.DefaultCellStyle.BackColor = DefaultColors.InputBg;
                dgv.DefaultCellStyle.ForeColor = DefaultColors.TextPrimary;
                dgv.DefaultCellStyle.SelectionBackColor = DefaultColors.PrimaryMid;
                dgv.DefaultCellStyle.SelectionForeColor = Color.White;
                
                dgv.AlternatingRowsDefaultCellStyle.BackColor = DefaultColors.RowAlt;
                
                dgv.ColumnHeadersDefaultCellStyle.BackColor = DefaultColors.Primary;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv.GridColor = DefaultColors.GridLines;
            }
            else if (control is System.Windows.Forms.TabControl tab)
            {
                // TabControl theming is limited in WinForms, but we can set the Form/Panel behind it
                // We'll rely on the DrawItem event if custom drawing exists, otherwise OS defaults.
            }
        }
    }
}

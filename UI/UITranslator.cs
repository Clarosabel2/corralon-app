using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public static class UITranslator
    {
        public static void ApplyTranslations(Control parent,  Dictionary<string, string> translations)
        {
            try
            {
                if (translations is null) throw new Exception("No hay traducciones para el form: " + parent.Name);

                foreach (Control ctrl in parent.Controls)
                {
                    if (ctrl is Button || ctrl is Label || ctrl is GroupBox || ctrl is TextBox  || ctrl is CheckBox)
                    {
                        if (translations.ContainsKey(ctrl.Name))
                        {
                            ctrl.Text = translations[ctrl.Name];
                        }
                    }
                    if (ctrl.HasChildren)
                    {
                        ApplyTranslations(ctrl, translations);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Resources;
using System.Windows.Forms;

namespace UI
{
    internal class ResxExporter
    {
        public static void ExportControlsToResx(Form form, string resxFilePath)
        {
            Dictionary<string, string> existingResources = new Dictionary<string, string>();

            if (File.Exists(resxFilePath))
            {
                using (ResXResourceReader resxReader = new ResXResourceReader(resxFilePath))
                {
                    foreach (DictionaryEntry entry in resxReader)
                    {
                        string key = entry.Key.ToString();
                        string value = entry.Value?.ToString() ?? "";
                        existingResources[key] = value;
                    }
                }
            }
            using (ResXResourceWriter resxWriter = new ResXResourceWriter(resxFilePath))
            {
                void ProcessControls(Control parent)
                {
                    foreach (Control control in parent.Controls)
                    {
                        if (control is Button || control is Label || control is GroupBox || control is LinkLabel)
                        {
                            string controlInfo = $"{form.Name}:{control.Name}";

                            if (!existingResources.ContainsKey(controlInfo))
                            {
                                resxWriter.AddResource(controlInfo, "");
                            }
                        }
                        if (control.HasChildren)
                        {
                            ProcessControls(control);
                        }
                    }
                }

                foreach (var resource in existingResources)
                {
                    resxWriter.AddResource(resource.Key, resource.Value);
                }
                ProcessControls(form);
            }
            MessageBox.Show($"Archivo .resx actualizado en: {resxFilePath}", "Exportación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

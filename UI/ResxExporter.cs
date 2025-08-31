using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Resources;
using System.Windows.Forms;
using System.Reflection;
using System.Linq;
using BLL;

namespace UI
{
    internal class ResxExporter
    {
        private static readonly string[] ResxFiles =
        {
            @"../../Resources/ResourceForms.resx",
            @"../../Resources/Resource1.resx",
            @"../../Resources/ResourceControlsForms.resx"
        };

        public static void CreateResxFileIfNotExist()
        {
            foreach (string resxFile in ResxFiles)
            {
                if (!File.Exists(resxFile))
                {
                    using (var writer = new ResXResourceWriter(resxFile))
                    {

                    }
                }
            }
        }
        private static bool IsFormExistInResx(string formName)
        {
            var existingResources = new Dictionary<string, string>();
            using (ResXResourceReader resxReader = new ResXResourceReader(ResxFiles[0]))
            {
                foreach (DictionaryEntry entry in resxReader)
                {
                    existingResources[entry.Key.ToString()] = entry.Value?.ToString() ?? "";
                }
            }
            if (existingResources.ContainsKey(formName))
            {
                return true;
            }
            existingResources[formName] = "";
            using (ResXResourceWriter writer = new ResXResourceWriter(ResxFiles[0]))
            {
                foreach (var kv in existingResources)
                {
                    writer.AddResource(kv.Key, kv.Value);
                }
            }
            return false;

        }

        private static bool IsExportable(Control c) =>
            c is Button ||
            c is Label ||
            c is GroupBox ||
            c is LinkLabel ||
            c is CheckBox ||
            c is RadioButton
            ;

        public static void ExportControlsFormToResx(Form form)
        {
            //Esta escrito el form en el resx entonces los controles tambien
            if (IsFormExistInResx(form.Name)) return;
            string targetResx = ResxFiles[1];
            var existing = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);


            if (File.Exists(targetResx))
            {
                using (var reader = new ResXResourceReader(targetResx))
                {
                    // Opcional: reader.UseResXDataNodes = true;
                    foreach (DictionaryEntry entry in reader)
                    {
                        string key = entry.Key?.ToString() ?? "";
                        string value = entry.Value?.ToString() ?? "";
                        if (key.Length > 0) existing[key] = value;
                    }
                }
            }

            IEnumerable<Control> Walk(Control parent)
            {
                foreach (Control child in parent.Controls)
                {
                    yield return child;
                    if (child.HasChildren)
                    {
                        foreach (var grand in Walk(child))
                            yield return grand;
                    }
                }
            }

            using (var writer = new ResXResourceWriter(targetResx))
            {
                foreach (var kv in existing)
                    writer.AddResource(kv.Key, kv.Value);

                foreach (var c in Walk(form))
                {
                    if (!IsExportable(c)) continue;
                    if (string.IsNullOrWhiteSpace(c.Name)) continue;

                    string key = $"{form.Name}:{c.Name}";
                    if (!existing.ContainsKey(key))
                    {
                        string value = c.Text?.ToString() ?? "";
                        writer.AddResource(key, value);
                    }
                }

                writer.Generate(); // opcional; using lo hace al Dispose
            }
        }
    }
}

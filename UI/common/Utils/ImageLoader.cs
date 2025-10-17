using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.common.Utils
{
    public static class ImageLoader
    {
        public static Image LoadSafe(string relOrAbsPath)
        {
            if (string.IsNullOrWhiteSpace(relOrAbsPath)) return null;

            string path = relOrAbsPath;
            if (!Path.IsPathRooted(path))
                path = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                                      relOrAbsPath.Replace('/', Path.DirectorySeparatorChar)));

            if (!File.Exists(path)) return Properties.Resources.img_icon;

            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var ms = new MemoryStream())
            { fs.CopyTo(ms); ms.Position = 0; return Image.FromStream(ms); }
        }
    }
}

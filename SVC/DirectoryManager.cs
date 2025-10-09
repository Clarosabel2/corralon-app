using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVC
{
    public sealed class DirectoryManager
    {
        /// <summary>Ruta absoluta del root administrado.</summary>
        public string Root { get; }

        /// <summary>Crea el manager asegurando que el root exista.</summary>
        public DirectoryManager(string rootAbsolutePath)
        {
            if (string.IsNullOrWhiteSpace(rootAbsolutePath))
                throw new ArgumentException("Root inválido.", nameof(rootAbsolutePath));

            Root = Path.GetFullPath(rootAbsolutePath);
            Directory.CreateDirectory(Root);
        }

        /// <summary>Factory: base en la carpeta del ejecutable (portable/dev).</summary>
        public static DirectoryManager FromAppBase(params string[] subfolders)
        {
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var path = CombineStatic(baseDir, subfolders);
            return new DirectoryManager(path);
        }

        /// <summary>Factory: %ProgramData%\Company\App (producción, todos los usuarios).</summary>
        public static DirectoryManager FromCommonAppData(string company, string app, params string[] subfolders)
        {
            if (string.IsNullOrWhiteSpace(company)) throw new ArgumentException("company");
            if (string.IsNullOrWhiteSpace(app)) throw new ArgumentException("app");

            var baseDir = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            var all = new[] { baseDir, company, app }.Concat(subfolders ?? new string[0]).ToArray();
            var path = Path.Combine(all);
            return new DirectoryManager(path);
        }

        private string RootWithSep =>
            Root.EndsWith(Path.DirectorySeparatorChar.ToString()) ? Root : Root + Path.DirectorySeparatorChar;

        private static string CombineStatic(string baseDir, params string[] segments)
        {
            if (segments == null || segments.Length == 0) return baseDir;
            var all = new[] { baseDir }.Concat(segments).ToArray();
            return Path.Combine(all);
        }

        /// <summary>Combina segmentos con el root y devuelve ruta absoluta normalizada.</summary>
        public string Combine(params string[] segments)
        {
            if (segments == null || segments.Length == 0) return Root;
            var all = new[] { Root }.Concat(segments).ToArray();
            var combined = Path.Combine(all);
            return Path.GetFullPath(combined);
        }

        /// <summary>Crea (si no existe) y devuelve la ruta absoluta del subdirectorio.</summary>
        public string Ensure(params string[] segments)
        {
            var abs = Combine(segments);
            Directory.CreateDirectory(abs);
            return abs;
        }

        /// <summary>¿Existe el subdirectorio?</summary>
        public bool Exists(params string[] segments) => Directory.Exists(Combine(segments));

        /// <summary>Verifica si una ruta absoluta cae dentro del root administrado.</summary>
        public bool IsInsideRoot(string path)
        {
            if (string.IsNullOrWhiteSpace(path)) return false;
            var full = Path.GetFullPath(path);
            return full.StartsWith(RootWithSep, StringComparison.OrdinalIgnoreCase) ||
                   string.Equals(full.TrimEnd(Path.DirectorySeparatorChar),
                                 Root.TrimEnd(Path.DirectorySeparatorChar),
                                 StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>Convierte una ruta RELATIVA (estilo URL o SO) a ruta ABSOLUTA dentro del root.</summary>
        public string ToAbsolute(string relativePath)
        {
            if (string.IsNullOrWhiteSpace(relativePath)) return null;
            if (Path.IsPathRooted(relativePath))
                throw new InvalidOperationException("Se esperaba una ruta RELATIVA al root.");

            var normalized = relativePath.Replace('/', Path.DirectorySeparatorChar);
            var segments = normalized.Split(new[] { Path.DirectorySeparatorChar }, StringSplitOptions.RemoveEmptyEntries);
            var abs = Combine(segments);
            if (!IsInsideRoot(abs))
                throw new InvalidOperationException("La ruta resultante queda fuera del root.");
            return abs;
        }

        /// <summary>Convierte una ruta ABSOLUTA a ruta RELATIVA (estilo URL) respecto del root.</summary>
        public string ToRelative(string absolutePath)
        {
            if (string.IsNullOrWhiteSpace(absolutePath)) return null;
            var full = Path.GetFullPath(absolutePath);
            if (!IsInsideRoot(full))
                throw new InvalidOperationException("La ruta no pertenece al root.");

            var rel = full.Substring(RootWithSep.Length);
            return rel.Replace(Path.DirectorySeparatorChar, '/');
        }

        /// <summary>Normaliza un nombre de archivo removiendo caracteres inválidos.</summary>
        public string SafeFileName(string name, char replaceWith = '_')
        {
            if (string.IsNullOrEmpty(name)) return "unnamed";
            var invalid = Path.GetInvalidFileNameChars();
            var chars = name.Select(ch => invalid.Contains(ch) ? replaceWith : ch).ToArray();
            var cleaned = new string(chars).Trim();
            return string.IsNullOrWhiteSpace(cleaned) ? "unnamed" : cleaned;
        }

        /// <summary>Crea un subdirectorio (relativo) y devuelve un NUEVO manager anclado a ese subdirectorio.</summary>
        public DirectoryManager CreateSubDirectory(string relativeSubPath)
        {
            if (string.IsNullOrWhiteSpace(relativeSubPath))
                throw new ArgumentException("Subruta inválida.", nameof(relativeSubPath));
            if (Path.IsPathRooted(relativeSubPath))
                throw new InvalidOperationException("Debe ser una ruta RELATIVA.");

            var abs = ToAbsolute(relativeSubPath);
            Directory.CreateDirectory(abs);
            return new DirectoryManager(abs);
        }

        /// <summary>Overload por segmentos para CreateSubDirectory.</summary>
        public DirectoryManager CreateSubDirectory(params string[] segments)
        {
            var rel = string.Join("/", segments ?? new string[0]);
            return CreateSubDirectory(rel);
        }

        /// <summary>Copia un archivo externo al root/<destDirs>/GUID.ext y devuelve la RUTA RELATIVA.</summary>
        public string CopyInAutoName(string sourceAbsolute, params string[] destRelativeDirs)
        {
            if (string.IsNullOrWhiteSpace(sourceAbsolute) || !File.Exists(sourceAbsolute))
                throw new FileNotFoundException("Archivo de origen no encontrado.", sourceAbsolute);

            var ext = Path.GetExtension(sourceAbsolute);
            var fileName = $"{Guid.NewGuid():N}{ext}";
            var destFolderAbs = Ensure(destRelativeDirs);
            var destAbs = Path.Combine(destFolderAbs, fileName);

            File.Copy(sourceAbsolute, destAbs, overwrite: false);
            return ToRelative(destAbs);
        }

        /// <summary>Mueve un archivo dentro del root usando rutas relativas.</summary>
        public void MoveInside(string srcRelative, string dstRelative, bool overwrite = false)
        {
            var srcAbs = ToAbsolute(srcRelative);
            var dstAbs = ToAbsolute(dstRelative);
            var dstDir = Path.GetDirectoryName(dstAbs);
            if (!string.IsNullOrEmpty(dstDir)) Directory.CreateDirectory(dstDir);
            if (overwrite && File.Exists(dstAbs)) File.Delete(dstAbs);
            File.Move(srcAbs, dstAbs);
        }

        /// <summary>Copia un archivo dentro del root usando rutas relativas.</summary>
        public void CopyInside(string srcRelative, string dstRelative, bool overwrite = false)
        {
            if (string.IsNullOrWhiteSpace(srcRelative))
                throw new ArgumentException("srcRelative no puede ser nulo/ vacío.", nameof(srcRelative));
            if (string.IsNullOrWhiteSpace(dstRelative))
                throw new ArgumentException("dstRelative no puede ser nulo/ vacío.", nameof(dstRelative));
            if (Path.IsPathRooted(srcRelative))
                throw new InvalidOperationException("srcRelative debe ser RELATIVO al Root.");
            if (Path.IsPathRooted(dstRelative))
                throw new InvalidOperationException("dstRelative debe ser RELATIVO al Root.");

            var srcAbs = ToAbsolute(srcRelative);
            var dstAbs = ToAbsolute(dstRelative);

            if (!File.Exists(srcAbs))
                throw new FileNotFoundException($"No existe el archivo origen (rel: {srcRelative})", srcAbs);

            // Asegurar carpeta destino
            var dstDir = Path.GetDirectoryName(dstAbs);
            if (!string.IsNullOrEmpty(dstDir)) Directory.CreateDirectory(dstDir);

            // Evitar copiar sobre sí mismo
            if (string.Equals(srcAbs, dstAbs, StringComparison.OrdinalIgnoreCase))
                return;

            File.Copy(srcAbs, dstAbs, overwrite);
        }

        /// <summary>Elimina subdirectorios vacíos (recursivo). Devuelve la cantidad eliminada.</summary>
        public int DeleteEmptySubdirectories()
        {
            int count = 0;
            var dirs = Directory.GetDirectories(Root, "*", SearchOption.AllDirectories)
                                .OrderByDescending(d => d.Length)
                                .ToArray();
            foreach (var dir in dirs)
            {
                if (!Directory.EnumerateFileSystemEntries(dir).Any())
                {
                    Directory.Delete(dir, false);
                    count++;
                }
            }
            return count;
        }
    }
}

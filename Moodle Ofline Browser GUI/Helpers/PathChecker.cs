using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Ofline_Browser_GUI.Helpers
{
    public static class PathChecker
    {

        /*
string ext;
ext = Path.GetExtension(FilePath);
if (FilePath.Length == 0 || FolderPath.Length == 0)
{
    System.Windows.Forms.MessageBox.Show("Wybierz obie sciezki", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
}
else if (ext != ".mbz")
{
    System.Windows.Forms.MessageBox.Show("Nieprawidłowy plik", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
}
else if (!System.IO.Directory.Exists(FolderPath))
{
    System.Windows.Forms.MessageBox.Show("Nieprawidłowa ścieżki do pliku", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
}
*/
        public static bool CheckCompressedFilePath(string path)
        {
            bool isOk = false;
            if (Path.GetExtension(path).ToLower() == ".mbz")
                isOk = true;
            return isOk;
        }
        public static bool CheckOutputFolder(string path)
        {
            bool isOk = false;
            if (Directory.Exists(path))
                isOk = true;
            return isOk;
        }
        public static bool CheckCourseFolder(string path)
        {
            bool isOk = false;
            if (Directory.Exists(path))
                isOk = true;
            return isOk;
        }
    }
}

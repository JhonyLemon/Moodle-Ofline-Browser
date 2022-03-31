using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle_Ofline_Browser_Core;

namespace Moodle_Ofline_Browser_Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            MbzDecompressor.Extract(@"C:\Users\Adam\Downloads\testBackup.mbz");
        }
    }
}

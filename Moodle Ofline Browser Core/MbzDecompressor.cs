using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpCompress.Readers;
using SharpCompress.Common;

namespace Moodle_Ofline_Browser_Core
{
    public static class MbzDecompressor
    {
        public static void Extract(string path)
        {
            using (Stream stream = File.OpenRead(path))
            {
                var reader = ReaderFactory.Open(stream);
                while (reader.MoveToNextEntry())
                {
                    if (!reader.Entry.IsDirectory)
                    {
                        ExtractionOptions opt = new ExtractionOptions
                        {
                            ExtractFullPath = true,
                            Overwrite = true
                        };
                        //reader.WriteEntryToDirectory(@"C:\Users\Adam\Downloads\test", opt);
                        IEntry entry = reader.Entry;
                        using (EntryStream entryStream = reader.OpenEntryStream())
                        {
                            StringBuilder stringBuilder = new StringBuilder();
                            const int bufSize = 1024 * 16;//16k
                            byte[] buf = new byte[bufSize];
                            while (entryStream.Read(buf,0,bufSize)>0)
                            {
                                stringBuilder.Append(System.Text.Encoding.UTF8.GetString(buf));
                            }
                            string s = stringBuilder.ToString();
                        }
                    }
                }
            }
        }

    }
}

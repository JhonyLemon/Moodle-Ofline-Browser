using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpCompress.Readers;
using SharpCompress.Common;
using System.Xml.Serialization;
using Moodle_Ofline_Browser_Core.models;

namespace Moodle_Ofline_Browser_Core
{
    public static class MbzDecompressor
    {
        public static async Task<int> Extract(string filePath, string folderPath, IProgress<Progress> progress)
        {

            int numberOfFiles = 0;
            long fileSize = new FileInfo(filePath).Length;
            long filesSize = 0;
            using (Stream stream = File.OpenRead(filePath))
            {
                var reader = ReaderFactory.Open(stream);
                while (reader.MoveToNextEntry())
                {
                    if (!reader.Entry.IsDirectory)
                    {
                        string shortName = reader.Entry.Key.Replace('/', '\\');
                        Progress result = new Progress();
                        result.CallerTask = "Decompressor";
                        try
                        {
                            reader.WriteEntryToDirectory(folderPath, new ExtractionOptions { ExtractFullPath = true, Overwrite = true });

                            filesSize += reader.Entry.CompressedSize;
                            result.Percentage = (int)((100 * filesSize) / fileSize);
                            if (result.Percentage > 100)
                                result.Percentage = 100;
                            numberOfFiles++;
                            result.Message = "File decompressed: " + shortName;
                        }
                        catch (Exception e)
                        {
                            result.Message = "File cannot be decompressed: " + shortName;
                        }
                        progress.Report(result);
                    }
                }
            }
            return numberOfFiles;
        }
    }
}

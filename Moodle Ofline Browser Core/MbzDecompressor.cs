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
    public class MbzDecompressor : CoreModule
    {

        private int numberOfFiles = 0;
        private long fileSize = 0;
        private long currentFileSize = 0;
        private long filesSize = 0;
        public static readonly string CALLER_NAME = "DECOMPRESSOR";

        public int Extract(string filePath, string folderPath, string logFileName)
        {

            numberOfFiles = 0;
            fileSize = new FileInfo(filePath).Length;
            filesSize = 0;

            using (Stream stream = File.OpenRead(filePath))
            {
                var reader = ReaderFactory.Open(stream);
                while (reader.MoveToNextEntry())
                {
                    if (!reader.Entry.IsDirectory)
                    {
                        currentFileSize = reader.Entry.CompressedSize;
                        string shortName = reader.Entry.Key.Replace('/', '\\');
                        ProgressReportEventArgs result = null;
                        try
                        {
                            reader.WriteEntryToDirectory(folderPath, new ExtractionOptions { ExtractFullPath = true, Overwrite = true });
                            result = MakeResult(shortName, true);
                        }
                        catch (Exception)
                        {
                            result = MakeResult(shortName, false);
                        }
                        if (logFileName!=null)
                            WriteLogToFile(folderPath + '\\' + logFileName, result.Message);
                        OnProgressReport(result);
                    }
                }
            }
            return numberOfFiles;
        }

        protected override ProgressReportEventArgs MakeResult(string shortName, bool isOk)
        {
            ProgressReportEventArgs result = null;
            result = base.MakeResult(shortName, isOk);
            if (isOk)
                    shortName = "Plik " + shortName + " zostal zdekompresowany";
                else
                    shortName = "Plik " + shortName + " nie zostal zdekompresowany";
            filesSize += currentFileSize;
            int percentage = (int)((100 * filesSize) / fileSize);
            if (percentage > 100)
                percentage = 100;
            numberOfFiles++;
            result.CallerTask = CALLER_NAME;
            result.Message = shortName;
            result.Percentage = percentage;
            return result;
        }
    }
}

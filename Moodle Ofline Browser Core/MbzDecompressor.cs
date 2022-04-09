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
    public class MbzDecompressor
    {
        public event EventHandler<ProgressReportEventArgs> ProgressReport;
        public static async Task<int> ExtractAsync(string filePath, string folderPath, IProgress<ProgressReportEventArgs> progress)
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
                        ProgressReportEventArgs result = new ProgressReportEventArgs();
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

        public int Extract(string filePath, string folderPath)
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
                        ProgressReportEventArgs result = new ProgressReportEventArgs();
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
                        OnProgressReport(result);
                    }
                }
            }
            return numberOfFiles;
        }

        protected virtual void OnProgressReport(ProgressReportEventArgs e)
        {
            EventHandler<ProgressReportEventArgs> handler = ProgressReport;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle_Ofline_Browser_Core.models;
using Moodle_Ofline_Browser_Core;

namespace Moodle_Ofline_Browser_GUI.Helpers
{
    public class DataProviderHelper
    {
        public string PathFrom { get; set; }
        public string PathTo { get; set; }
        public List<Progress> Progresses { get; set; }
        public Progress<Progress> Progress { get; set; }

        public DataProviderHelper(string pathFrom, string pathTo)
        {
            PathFrom = pathFrom;
            PathTo = pathTo;
            Progresses = new List<Progress>();
            Progress = new Progress<Progress>();
            Progress.ProgressChanged += OnUpdate;
        }

        public DataProviderHelper(string pathFrom)
        {
            PathFrom = pathFrom;
            Progresses = new List<Progress>();
            Progress = new Progress<Progress>();
            Progress.ProgressChanged += OnUpdate;
        }

        public FullCourse GetFullCourse()
        {
            FullCourse fullCourse=null;

            return fullCourse;
        }

        private void OnUpdate(object sender, Progress e)
        {
            
        }
    }
}

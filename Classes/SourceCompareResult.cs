using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoRocketFontes.Classes
{
    public struct SourceDiff
    {
        public string filename;
        public string DateRPO;
        public string HourRPO;
        public string DateRepository;
        public string HourRepository;
    }
    public class SourceCompareResult
    {
        public List<SourceDiff> sourceDiff;
        public List<Source> sourceNonExistent;

        public SourceCompareResult()
        {
            sourceDiff = new List<SourceDiff>();
            sourceNonExistent = new List<Source>();
        }
    }
}

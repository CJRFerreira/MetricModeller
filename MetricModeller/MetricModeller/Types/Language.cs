using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricModeller.Types
{
    public class Language
    {
        public String Name { get; set; }

        public Int32 Level { get; set; }

        public Int32 LinesPerFP { get; set; }

        public Language(string name, int level, int linesPerFP)
        {
            Name = name;
            Level = level;
            LinesPerFP = linesPerFP;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
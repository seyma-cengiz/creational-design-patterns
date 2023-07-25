using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Builder
{
    public class Report
    {
        public string Header { get; set; }
        public string FileExtension { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }

    }
}

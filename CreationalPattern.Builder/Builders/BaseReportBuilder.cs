using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Builder.Builders
{
    public abstract class BaseReportBuilder
    {
        protected Report _report;
        public abstract void SetHeader();
        public abstract void SetExtension();
        public abstract void SetSummary();
        public abstract void SetContent();

        public Report CreateNewReport()
        {
            return new Report();
        }
        public Report GetReport()
        {
            return _report;
        }
    }
}

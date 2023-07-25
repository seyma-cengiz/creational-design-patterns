using CreationalPattern.Builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Builder
{
    public class Director
    {
        private readonly BaseReportBuilder _builder;
        public Director(BaseReportBuilder builder)
        {
            _builder = builder;
        }

        public Report CreateMinimalReport()
        {
            _builder.SetHeader();
            _builder.SetSummary();
            return _builder.GetReport();
        }

        public Report CreateDetailedReport()
        {
            _builder.SetHeader();
            _builder.SetExtension();
            _builder.SetContent();
            return _builder.GetReport();
        }
    }
}

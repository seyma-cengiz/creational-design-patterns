using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Builder.Builders
{
    public class ExcelReportBuilder : BaseReportBuilder
    {
        public ExcelReportBuilder()
        {
            _report = CreateNewReport();
        }

        public override void SetContent()
        {
            _report.Content = "This is excel report with more detail.";
        }

        public override void SetExtension()
        {
            _report.FileExtension = ".xlsx";
        }

        public override void SetHeader()
        {
            _report.Header = "EXCEL REPORT";
        }

        public override void SetSummary()
        {
            _report.Summary = "Simple excel report.";
        }

    }
}

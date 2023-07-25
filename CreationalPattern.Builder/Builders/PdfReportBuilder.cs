using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Builder.Builders
{
    public class PdfReportBuilder : BaseReportBuilder
    {
        public PdfReportBuilder()
        {
            _report = CreateNewReport();
        }

        public override void SetContent()
        {
            _report.Content = "This is pdf report with more detail.";
        }

        public override void SetExtension()
        {
            _report.FileExtension = ".pdf";
        }

        public override void SetHeader()
        {
            _report.Header = "PDF REPORT";
        }

        public override void SetSummary()
        {
            _report.Summary = "Simple pdf report.";
        }
    }
}

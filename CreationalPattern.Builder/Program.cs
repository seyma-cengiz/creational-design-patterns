using CreationalPattern.Builder;
using CreationalPattern.Builder.Builders;

var minimalReportList = new List<Report>();
var detailedReportList = new List<Report>();

var director = new Director(new PdfReportBuilder());
var report = director.CreateMinimalReport();
minimalReportList.Add(report);

report = director.CreateDetailedReport();
detailedReportList.Add(report);

director = new Director(new ExcelReportBuilder());
report = director.CreateMinimalReport();
minimalReportList.Add(report);

report = director.CreateDetailedReport();
detailedReportList.Add(report);

foreach (var minimalReport in minimalReportList)
{
    Console.WriteLine(minimalReport.Header);
    Console.WriteLine(minimalReport.Summary);
    Console.WriteLine("-------------------");
}

foreach (var detailedReport in detailedReportList)
{
    Console.WriteLine(detailedReport.Header);
    Console.WriteLine(detailedReport.FileExtension);
    Console.WriteLine(detailedReport.Content);
    Console.WriteLine("-------------------");
}
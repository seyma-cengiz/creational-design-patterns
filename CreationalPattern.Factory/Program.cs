// See https://aka.ms/new-console-template for more information

using CreationalPattern.Factory.Documents;

Document resume = new Resume();
Console.WriteLine($"{nameof(resume)} created with this pages:");
foreach (var page in resume.Pages)
{
    Console.WriteLine(page.GetPageName());
}

Document report = new Report();
Console.WriteLine($"{nameof(report)} created with this pages:");
foreach (var page in report.Pages)
{
    Console.WriteLine(page.GetPageName());
}

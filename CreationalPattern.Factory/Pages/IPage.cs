using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Factory.Pages
{
    public interface IPage
    {
        string GetPageName();
    }

    public class PersonalInfoPage : IPage
    {
        public string GetPageName()
        {
            return "Personal Info Page";
        }
    }

    public class ExperiencePage: IPage
    {
        public string GetPageName()
        {
            return "Experience Page";
        }
    }

    public class SummaryPage: IPage
    {
        public string GetPageName()
        {
            return "Summary Page";
        }
    }

    public class ConclusionPage : IPage
    {
        public string GetPageName()
        {
            return "Conclusion Page";
        }
    }
}

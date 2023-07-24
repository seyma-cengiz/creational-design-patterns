using CreationalPattern.Factory.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Factory.Documents
{
    public abstract class Document
    {
        public List<IPage> Pages { get; set; }

        public Document()
        {
            Pages = new List<IPage>();
            this.CreatePages();
        }

        public abstract void CreatePages();
    }

    public class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new PersonalInfoPage());
            Pages.Add(new ExperiencePage());
        }
    }

    public class Report : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new SummaryPage());
            Pages.Add(new ConclusionPage());
        }
    }
}

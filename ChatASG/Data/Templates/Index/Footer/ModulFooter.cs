using ChatASG.Data.Templates.Base;
using Data.FooterSection;
using Microsoft.AspNetCore.Components;

namespace Data.FooterSectio
{
    public class DataAddFooter
    {
        
        public List<DataFooterLinkSection> LinkSections { get; set; } = new();
     
        public DataFooterBottom? PolicyLinks { get; set; }

        public DataFooterBrandInfo? Iinfo { get; set; }
        public DataFooterNewsletter? INewsletter { get; set; }


    }
    public class DataFooterBrandInfo 
    {
        public string? Icon { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }
    }
    public class DataFooterLinkSection
    {
        public string Title { get; set; } = "";
        public List<FooterLink> Links { get; set; } = new();
    }

    public class FooterLink
    {
        public string Text { get; set; } = "";
        public string Url { get; set; } = "#";
    }
    public class DataFooterNewsletter 
    {
        public string? Name { get; set; }

        public string? Title { get; set; }
        public string? Label { get; set; }

        public string? Icon { get; set; }
    }

    public class DataFooterBottom
    {
        public string Title { get; set; } = "";
        public List<BottomLink> ILinks { get; set; } = new();

    }
    public class BottomLink
    {
        public string Text { get; set; } = "";
        public string Url { get; set; } = "#";
    }
}

using ChatASG.Data.Templates.Base;
using Data.FooterSection;
using Microsoft.AspNetCore.Components;

namespace Data.FooterSectio
{
    public class FooterData
    {
        
        public List<DataFooterLinkSection> LinkSections { get; set; } = new();
     
        public DataFooterBottom? PolicyLinks { get; set; }

        public DataFooterBrandInfo? Iinfo { get; set; }
        public DataFooterNewsletter? INewsletter { get; set; }


    }
    public class DataFooterBrandInfo : ModulsBase
    {
       
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
    public class DataFooterNewsletter : ModulsBase
    {
     
    }

    public class DataFooterBottom
    {
        public string Title { get; set; } = "";
        public List<FooterLink> Links { get; set; } = new();
    }

}

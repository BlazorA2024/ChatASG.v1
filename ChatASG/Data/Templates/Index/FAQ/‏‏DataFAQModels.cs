using ChatASG.Data.Templates.Base;
using Microsoft.AspNetCore.Components;

namespace Data.FAQModels;
public class DataAddFAQ
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public List<DataFaq> Items { get; set; } = new();

    public DataStillFAQ? IstillFAQ { get; set; }
}
public class DataFaq
{
    public string Question { get; set; } = string.Empty;
    public string Answer { get; set; } = string.Empty;
    public List<string>? BulletPoints { get; set; } // Optional
    public bool HasIconList { get; set; } = false;   // Use icons if true
}


public class DataStillFAQ 
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Button { get; set; }

}



















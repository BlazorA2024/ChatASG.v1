using ChatASG.Data.Templates.Base;
using Data.HeaderModels;
using Microsoft.AspNetCore.Components;

namespace Data.SectionModels;
public class DataButtons 
{
   

    public string? Icon { get; set; }
    public string? ClassButton { get; set; } 
    public string? IconColor { get; set; }
    public string? Button { get; set; }

    public string? Link { get; set; }
}


public class DataHeroImageStats 
{
    public string? Name { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; }
}


public class DataHeroIntro 
{
    public string? Name { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Label { get; set; }

    public DataHeroImageStats? IStats { get; set; } 
    public List<DataButtons> Items { get; set; } = new();
}












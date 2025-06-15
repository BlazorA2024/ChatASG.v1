using ChatASG.Data.Templates.Base;
using Data.HeaderModels;
using Microsoft.AspNetCore.Components;

namespace Data.FeaturesSectionModels;
public class DataFeatures 
{
    public string? Icon { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? IconColor { get; set; }
    public string? IconBackground { get; set; }
}





public class DataAddFeatures 
{
    public string? Name { get; set; }

    public string? Description { get; set; }

    public List<DataFeatures> Items { get; set; }  = new List<DataFeatures>();
}

















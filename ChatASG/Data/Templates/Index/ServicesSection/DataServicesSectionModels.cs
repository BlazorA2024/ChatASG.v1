using ChatASG.Data.Templates.Base;
using Data.HeaderModels;
using Microsoft.AspNetCore.Components;

namespace Data.ServicesSectionModels;
public class DataStudios 
{
    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Link { get; set; }
    public string? FrameSrc { get; set; }
}

public class DataAddStudios 
{
    public string? Name { get; set; }

   
    public List<DataStudios> Items { get; set; } = new();
}






















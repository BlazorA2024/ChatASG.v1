using ChatASG.Data.Templates.Base;
using Data.HeaderModels;
using Microsoft.AspNetCore.Components;

namespace Data.OurservicesModels;

public class DataOurservice  
{
    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? IconColor { get; set; }

    public List<string> Features { get; set; } = new();
}



public class DataOurservicesCard 
{
    public string? Icon { get; set; }

    public string? IconColor { get; set; }

    public string? IconBackground { get; set; }
    public DataOurservice? dataOurservice {  get; set; }
       
    }

   

public class DataAddOurservices 
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public List<DataOurservicesCard> Items { get; set; } = new List<DataOurservicesCard>();
}









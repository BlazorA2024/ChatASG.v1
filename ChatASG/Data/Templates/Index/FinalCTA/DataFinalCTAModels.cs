using ChatASG.Data.Templates.Base;
using Microsoft.AspNetCore.Components;

namespace Data.FinalCTAModul;


public class DataAddFinalCTA
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? InputPlaceholder { get; set; }
    public string? ButtonText { get; set; }
    public List<string> Features { get; set; } = new();
    public DataFinalCTA? IFinalCTA { get; set; }
}

public class DataFinalCTA
{
    public string? Button { get; set; }

    public string? InputPlaceholder { get; set; }

}




























//using ChatASG.Data.Templates.Base;
//using Microsoft.AspNetCore.Components;

//namespace Data.FinalCTAModul;
//public class DataCardFinalCTA 
//{
//    public string? Button { get; set; } 

//    public string? InputPlaceholder { get; set; } 

//}


//public class FinalCtaData
//{
//    public string? Title { get; set; } 
//    public string? Description { get; set; }
//    public string? InputPlaceholder { get; set; }
//    public string? ButtonText { get; set; } 
//    public List<string> Features { get; set; } = new();
//    public DataCardFinalCTA? IFinalCTA { get; set; }
//}
















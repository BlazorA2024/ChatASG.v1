using ChatASG.Data.Templates.Base;
using Microsoft.AspNetCore.Components;

namespace Data.FinalCTA5;
public class DataCardFinalCTA : ModulsBase
{
    
    public string InputPlaceholder { get; set; } = string.Empty;
    
}


public class StylesCardFinalCT : StyleBaseComponentCard
{

    [Parameter] public string? ClassInputGroup { get; set; }
    [Parameter] public string? ClassInput { get; set; }
    [Parameter] public string? ClassButton { get; set; }
    [Parameter] public string? ClassFeatureItem { get; set; }


    public static string KeyInputGroup = "inputGroup";
    public static string KeyInput = "input";
    public static string KeyButton = "button";
    public static string KeyFeatureItem = "featureItem";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {

        { KeyInputGroup, "flex flex-col sm:flex-row justify-center space-y-4 sm:space-y-0 sm:space-x-6 max-w-lg mx-auto" },
        { KeyInput, "w-full px-5 py-4 rounded-full bg-dark border border-gray-700 focus:outline-none focus:ring-2 focus:ring-accent" },
        { KeyButton, "absolute right-1 top-1 bg-gradient-to-r from-accent to-accent2 text-dark font-bold px-4 py-3 rounded-full hover:opacity-90 transition" },
        { KeyFeatureItem, "relative flex-grow" },
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {

        if (ClassInputGroup == null)
            ClassInputGroup = " ";
        if (ClassInput == null)
            ClassInput = " ";
        if (KeyButton == null)
            ClassButton = " ";

        if (ClassFeatureItem == null)
            ClassFeatureItem = " ";

            if (classes == null || IsIgnoredStyle)
                return Task.FromResult(false);


        ClassInputGroup += " " + classes[KeyInputGroup];
        ClassInput += " " + classes[KeyInput];
        ClassButton += " " + classes[KeyButton];
        ClassFeatureItem += " " + classes[KeyFeatureItem];

        return base.UpdateStyleAsync(classes);
    }
}
public class CardFinalCT : ComponentBaseCard<DataCardFinalCTA>
{
    public static ICollection<string> NAMECLASSES => StylesCardFinalCT.CLASSES.Keys.ToList();

    public override TypeComponentCard Type => throw new NotImplementedException();

    public override void Build(DataCardFinalCTA db)
    {
        DataBuild = db;
    }

    public static CardFinalCT Create(DataCardFinalCTA data)
    {
        var instance = new CardFinalCT();
        instance.Build(data);
        return instance;
    }
}


public class FinalCtaData
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string InputPlaceholder { get; set; } = string.Empty;
    public string ButtonText { get; set; } = string.Empty;
    public List<string> Features { get; set; } = new();
    public DataCardFinalCTA ICTA { get; set; }
}
public class StylesFinalCtaCard : StyleBaseComponentCard
{
    [Parameter] public string? ClassSection { get; set; }
    [Parameter] public string? ClassTitle { get; set; }
    [Parameter] public string? ClassDescription { get; set; }
   // [Parameter] public string? ClassInputGroup { get; set; }
  //  [Parameter] public string? ClassInput { get; set; }
  //  [Parameter] public string? ClassButton { get; set; }
    [Parameter] public string? ClassFeatures { get; set; }
    [Parameter] public string? ClassFeatureItem { get; set; }
    [Parameter] public string? ClassFeatureIcon { get; set; }

    public static string KeySection = "section";
    public static string KeyClassContainer = "classContainer";
    public static string KeyTitle = "title";
    public static string KeyDescription = "description";
    //public static string KeyInputGroup = "inputGroup";
    //public static string KeyInput = "input";
    //public static string KeyButton = "button";
    public static string KeyFeatures = "features";
    public static string KeyFeatureItem = "featureItem";
    public static string KeyFeatureIcon = "featureIcon";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeySection, "py-20 px-4 sm:px-10 lg:px-20 xl:px-32 bg-gradient-to-br from-primary to-dark text-center" },
        { KeyClassContainer, "max-w-3xl mx-auto" },
        { KeyTitle, "text-3xl sm:text-4xl font-bold mb-6" },
        { KeyDescription, "text-lg text-gray-300 mb-10" },
        //{ KeyInputGroup, "flex flex-col sm:flex-row justify-center space-y-4 sm:space-y-0 sm:space-x-6 max-w-lg mx-auto" },
        //{ KeyInput, "w-full px-5 py-4 rounded-full bg-dark border border-gray-700 focus:outline-none focus:ring-2 focus:ring-accent" },
        //{ KeyButton, "absolute right-1 top-1 bg-gradient-to-r from-accent to-accent2 text-dark font-bold px-4 py-3 rounded-full hover:opacity-90 transition" },
        { KeyFeatures, "flex justify-center mt-8 space-x-4" },
        { KeyFeatureItem, "flex items-center text-sm text-gray-400" },
        { KeyFeatureIcon, "text-green-400 mr-2" }
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (ClassSection == null)
            ClassSection = " ";
        if(KeyClassContainer ==null)
           ClassContainer = " ";
        if(ClassTitle== null)
            ClassTitle = " ";
         if(ClassDescription == null)
             ClassDescription = " ";
        // if(ClassInputGroup == null)
        //    ClassInputGroup = " ";
        //if (ClassInput == null)           
        //     ClassInput = " ";
        //if (KeyButton == null)
        //    ClassButton = " ";
        if(ClassFeatures ==null)
        ClassFeatures  = " ";
        if (ClassFeatureItem == null)
            ClassFeatureItem = " ";
        if (ClassFeatureIcon == null)
            ClassFeatureIcon = " ";

        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassSection += " " + classes[KeySection];
        ClassContainer += " " + classes[KeyClassContainer];
        ClassTitle += " " + classes[KeyTitle];
        ClassDescription += " " + classes[KeyDescription];
        //ClassInputGroup += " " + classes[KeyInputGroup];
        //ClassInput += " " + classes[KeyInput];
        //ClassButton += " " + classes[KeyButton];
        ClassFeatures += " " + classes[KeyFeatures];
        ClassFeatureItem += " " + classes[KeyFeatureItem];
        ClassFeatureIcon += " " + classes[KeyFeatureIcon];

        return base.UpdateStyleAsync(classes);
    }
}
public class CardFinalCta : ComponentBaseCard<FinalCtaData>
{
    public CardFinalCT ICTA { get; set; }

    public static ICollection<string> NAMECLASSES => StylesFinalCtaCard.CLASSES.Keys.ToList();

    public override TypeComponentCard Type => throw new NotImplementedException();

    public override void Build(FinalCtaData db)
    {
        DataBuild = db;
        ICTA = CardFinalCT.Create(db.ICTA);
        // IStats = CardHeroImageStats.Create(db.IStats);

    }

    public static CardFinalCta Create(FinalCtaData data)
    {
        var instance = new CardFinalCta();
        instance.Build(data);
        return instance;
    }
}






















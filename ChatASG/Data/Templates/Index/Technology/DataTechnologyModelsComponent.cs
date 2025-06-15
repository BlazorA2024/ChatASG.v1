using ChatASG.Data.Templates.Base;
using Data.HeaderModels;
using Data.ModulsTechnology;
using Microsoft.AspNetCore.Components;

namespace Data.Technology;

//public class DataTechnology : ModulsBase
//{
   
//    public string ColorIcon { get; set; } = "";
//    public string BgIcon { get; set; } = "";
//}
public class StylesTechnologyCard : StyleBaseComponentCard
{
    [Parameter] public string? ClassTitle { get; set; }
    [Parameter] public string? ClassDescription { get; set; }

    public static string KeyClassContainer = "classContainer";
    public static string KeyClassItem  = "classItem";

    public static string KeyClassTitle = "classTitle";
    public static string KeyClassDescription = "classDescription";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyClassContainer, "" },
        {KeyClassItem, "flex items-start "  },
        { KeyClassTitle, "text-lg font-bold mb-2" },
        { KeyClassDescription, "text-gray-400" }
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (KeyClassContainer == null)
            ClassContainer = " ";
        if (KeyClassItem == null)
            ClassItem = " ";
        if (ClassTitle == null)
            ClassTitle = " ";
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassContainer += " " + classes[KeyClassContainer];
        ClassItem += " " + classes[KeyClassItem];

        ClassTitle += " " + classes[KeyClassTitle];
        ClassDescription += " " + classes[KeyClassDescription];

        return base.UpdateStyleAsync(classes);
    }
}

public class CardTechnology : ComponentBaseCard<DataTechnology>
{
    public override TypeComponentCard Type => throw new NotImplementedException();
    public override void Build(DataTechnology db)
    {
        DataBuild = db;
    }
    public static CardTechnology Create(DataTechnology data)
    {
        var instance = new CardTechnology();
        instance.Build(data);
        return instance;
    }


}


//public class DataTechnologyImage
//{
//    public string ImageUrl { get; set; } = "";
//    public string AltText { get; set; } = "";
//    public string LabelTop { get; set; } = "";
//    public string LabelNumber { get; set; } = "";
//    public string LabelBottom { get; set; } = "";
//}


public class StylesTechnologyImageCard : StyleBaseComponentCard
{
    [Parameter] public string? ClassImage { get; set; }
    [Parameter] public string? ClassLabel { get; set; }
    [Parameter] public string? ClassText { get; set; }

    public static string KeyClassContainer = "classContainer";
    public static string KeyClassImage = "classImage";
    public static string KeyClassLabel = "classLabel";
    public static string KeyClassText = "classText";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyClassContainer, "relative" },
        { KeyClassImage, "w-full h-auto rounded-2xl" },
        { KeyClassLabel, "absolute -bottom-6 -right-6 bg-blue-600 p-4 rounded-xl shadow-xl" },
        { KeyClassText, "text-white text-center" }
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (KeyClassContainer == null)
            ClassContainer = " ";
        if (ClassImage == null)
            ClassImage = " ";
        if (ClassLabel == null)
            ClassLabel = " ";
        if (ClassText == null)
            ClassText = " ";
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassContainer += " " + classes[KeyClassContainer];
        ClassImage += " " + classes[KeyClassImage];
        ClassLabel += " " + classes[KeyClassLabel];
        ClassText += " " + classes[KeyClassText];

        return base.UpdateStyleAsync(classes);
    }
}

public class CardTechnologyImage : ComponentBaseCard<DataTechnologyImage>
{
    public override TypeComponentCard Type => throw new NotImplementedException();
    public override void Build(DataTechnologyImage db)
    {
        DataBuild = db;
    }
    public static CardTechnologyImage Create(DataTechnologyImage data)
    {
        var instance = new CardTechnologyImage();
        instance.Build(data);
        return instance;
    }


}

//public class MarketItem : ModulsBase
//{
//    public string IconClass { get; set; } = "";
  
//}
public class StylesCardMarketItem : StyleBaseComponentCard
{
    [Parameter] public string? ClassTitle { get; set; }
    [Parameter] public string? ClassDescription { get; set; }

    public static string KeyClassContainer = "classContainer";
    public static string KeyClassTitle = "classTitle";
    public static string KeyClassDescription = "classDescription";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyClassContainer, "bg-gray-700/50 p-4 rounded-lg" },
        { KeyClassTitle, "font-bold" },
        { KeyClassDescription, "text-gray-400 text-sm" }
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (KeyClassContainer == null)
            ClassContainer = " ";
        if (ClassTitle == null)
            ClassTitle = " ";

        if (ClassDescription == null)
            ClassDescription = " ";
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassContainer += " " + classes[KeyClassContainer];
        ClassTitle += " " + classes[KeyClassTitle];
        ClassDescription += " " + classes[KeyClassDescription];

        return base.UpdateStyleAsync(classes);
    }
}
public class CardMarketItem : ComponentBaseCard<DataTargetMarketItem>
{
    public override TypeComponentCard Type => throw new NotImplementedException();
    public override void Build(DataTargetMarketItem db)
    {
        DataBuild = db;
    }
    public static CardMarketItem Create(DataTargetMarketItem data)
    {
        var instance = new CardMarketItem();
        instance.Build(data);
        return instance;
    }


}
//public class DataGrowthAnalytics : ModulsBase
//{
   
//    public string GrowthRange { get; set; } = "";
//    public string GrowthAmount { get; set; } = "";
//    public int Progress { get; set; } = 0;
//}
public class StylesGrowthAnalyticsBox : StyleBaseComponentCard
{
    [Parameter] public string? ClassBox { get; set; }
    [Parameter] public string? ClassHeader { get; set; }
    [Parameter] public string? ClassProgress { get; set; }
    [Parameter] public string? ClassLabel { get; set; }

    public static string KeyClassBox = "classBox";
    public static string KeyClassHeader = "classHeader";
    public static string KeyClassProgress = "classProgress";
    public static string KeyClassLabel = "classLabel";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyClassBox, "bg-gray-700/50 p-6 rounded-lg" },
        { KeyClassHeader, "flex items-center justify-between mb-4" },
        { KeyClassProgress, "h-4 bg-gray-600 rounded-full mb-2" },
        { KeyClassLabel, "flex justify-between text-sm text-gray-400" }
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        ClassContainer ??= " ";
        ClassBox ??= " ";
        ClassHeader ??= " ";
        ClassProgress ??= " ";
        ClassLabel ??= " ";

        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassContainer += " " + classes[KeyClassBox];
        ClassBox += " " + classes[KeyClassBox];
        ClassHeader += " " + classes[KeyClassHeader];
        ClassProgress += " " + classes[KeyClassProgress];
        ClassLabel += " " + classes[KeyClassLabel];

        return base.UpdateStyleAsync(classes);
    }
}
public class CardGrowthAnalyticsBox : ComponentBaseCard<DataGrowthAnalytics>
{
    public static ICollection<string> NAMECLASSES => StylesGrowthAnalyticsBox.CLASSES.Keys.ToList();

    public override TypeComponentCard Type => throw new NotImplementedException();

    public override void Build(DataGrowthAnalytics db)
    {
        DataBuild = db;
    }

    public static CardGrowthAnalyticsBox Create(DataGrowthAnalytics data)
    {
        var instance = new CardGrowthAnalyticsBox();
        instance.Build(data);
        return instance;
    }
}

//public class DataTargetMarket : ModulsBase
//{
  
//    public List<DataTargetMarketItem> Items { get; set; } = new();
//    public DataGrowthAnalytics? IGrowth { get; set; }
//    public string TitleGrowth { get; set; } = "";
//    public string DescriptionGrowth { get; set; } = "";
//    public string GrowthLabel { get; set; } = "";
  
  
//}


public class StylesTargetMarketSection : StyleBaseComponentCard
{
    [Parameter] public string? ClassTitle { get; set; }
    [Parameter] public string? ClassDescription { get; set; }

    public static string KeyContainer = "classContainer";
    public static string KeyTitle = "classTitle";
    public static string KeyDescription = "classDescription";
    public static string KeyItem = "classItem";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyContainer, "mt-20 bg-gray-800/50 p-8 rounded-2xl" },
        { KeyTitle, "text-2xl font-bold mb-4" },
        { KeyDescription, "text-gray-400 mb-6" },
        { KeyClassItem, "grid grid-cols-2 gap-4" },
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (KeyClassContainer == null)
            ClassContainer = " ";

        if (KeyClassItem == null)
            ClassItem = " ";
        
        if (ClassTitle == null)
            ClassTitle = " ";
        if (ClassDescription == null)
            ClassDescription = " ";
        
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassContainer += " " + classes[KeyClassContainer];
        ClassItem += " " + classes[KeyClassItem];

        ClassTitle += " " + classes[KeyTitle];
        ClassDescription += " " + classes[KeyDescription];
     

        return base.UpdateStyleAsync(classes);
    }
}

public class CardAddTargetMarket : ComponentBaseCard<DataTargetMarket>
{
    public List<CardMarketItem> Items { get; set; } = new();
    public CardGrowthAnalyticsBox IGrowth { get; set; }

    public override TypeComponentCard Type => throw new NotImplementedException();

    public static ICollection<string> NAMECLASSES => StylesTechnologySection.CLASSES.Keys.ToList();

    public override void Build(DataTargetMarket db)
    {
        DataBuild = db;
        IGrowth = CardGrowthAnalyticsBox.Create(db.IGrowth);

        foreach (var item in db.Items)
        {
            var listUnifiedButtonModel = CardMarketItem.Create(item);
            Items.Add(listUnifiedButtonModel);
        }
    }

    public static CardAddTargetMarket Create(DataTargetMarket data)
    {
        var instance = new CardAddTargetMarket();
        instance.Build(data);
        return instance;
    }


}


//public class DataAddTechnology : ModulsBase
//{
 
//    public DataTechnologyImage ITechnol { get; set; }
//    public DataTargetMarket IMarket { get; set; }

//    public List<DataTechnology> Items { get; set; } = new();
//}
public class StylesTechnologySection : StyleBaseComponentCard
{
    [Parameter] public string? ClassName { get; set; }
    [Parameter] public string? ClassTitle { get; set; }
    [Parameter] public string? ClassDescription { get; set; }
    [Parameter] public string? ClassGrid { get; set; }
    [Parameter] public string? ClassSubTitle { get; set; }
    [Parameter] public string? ClassSubDescription { get; set; }

    public static string KeyClassContainer = "classContainer";
    public static string KeyClassItem = "classItem";
    public static string KeyClassName = "className";
    public static string KeyClassTitle = "classTitle";
    public static string KeyClassDescription = "classDescription";
    public static string KeyClassGrid = "classGrid";
    public static string KeyClassSubTitle = "classSubTitle";
    public static string KeyClassSubDescription = "classSubDescription";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyClassContainer, "py-20 px-4 sm:px-6 lg:px-8 bg-gray-900" },
        { KeyClassItem, "max-w-7xl mx-auto" },
        { KeyClassName, "text-3xl font-bold mb-4" },
        { KeyClassTitle, "text-center mb-16" },
        { KeyClassDescription, "text-gray-400 max-w-3xl mx-auto" },
        { KeyClassGrid, "grid grid-cols-1 md:grid-cols-2 gap-12 items-center" },
        { KeyClassSubTitle, "text-2xl font-bold mb-6" },
        { KeyClassSubDescription, "text-gray-400 mb-6" }
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (KeyClassContainer == null)
            ClassContainer = " ";

        if (KeyClassItem == null)
            ClassItem = " ";
        if (ClassName == null)
            ClassName = " ";
        if (ClassTitle == null)
            ClassTitle = " ";
        if (ClassDescription == null)
            ClassDescription = " ";
        if (ClassGrid == null)
            ClassGrid = " ";
        if (ClassSubTitle == null)
            ClassSubTitle = " ";
        if (ClassSubDescription == null)
            ClassSubDescription = " ";
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassContainer += " " + classes[KeyClassContainer];
        ClassItem += " " + classes[KeyClassItem];
        ClassName += " " + classes[KeyClassName];

        ClassTitle += " " + classes[KeyClassTitle];
        ClassDescription += " " + classes[KeyClassDescription];
        ClassGrid += " " + classes[KeyClassGrid];
        ClassSubTitle += " " + classes[KeyClassSubTitle];
        ClassSubDescription += " " + classes[KeyClassSubDescription];

        return base.UpdateStyleAsync(classes);
    }
}


public class CardAddTechnology : ComponentBaseCard<DataAddTechnology>
{
    public List<CardTechnology> Items { get; set; } = new();
    public CardTechnologyImage ITechnol { get; set; }
    public CardAddTargetMarket IMarket { get; set; }

    public override TypeComponentCard Type => throw new NotImplementedException();

    public static ICollection<string> NAMECLASSES => StylesTechnologySection.CLASSES.Keys.ToList();

    public override void Build(DataAddTechnology db)
    {
        DataBuild = db;
        ITechnol = CardTechnologyImage.Create(db.ITechnol);
        IMarket = CardAddTargetMarket.Create(db.IMarket);

        foreach (var item in db.Items)
        {
            var listUnifiedButtonModel = CardTechnology.Create(item);
            Items.Add(listUnifiedButtonModel);
        }
    }

    public static CardAddTechnology Create(DataAddTechnology data)
    {
        var instance = new CardAddTechnology();
        instance.Build(data);
        return instance;
    }

   
}















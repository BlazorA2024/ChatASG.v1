using ChatASG.Data.Templates.Base;
using Data.HeaderModels;
using Microsoft.AspNetCore.Components;

namespace Data.FeaturesSectionv;
public class DataFeatures : ModulsBase
{
    public string? Icon { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? IconColor { get; set; }
    public string? IconBackground { get; set; }
}
public class StylesFeaturesCard : StyleBaseComponentCard
{
    [Parameter] public string? ClassIcon { get; set; }

    [Parameter] public string? ClassTitle { get; set; }
    [Parameter] public string? ClassDescription { get; set; }
    [Parameter] public string? ClassCard { get; set; }

    public static string KeyClassIcon = "classIcon";
    public static string KeyClassTitle = "classTitle";
    public static string KeyClassDescription = "classDescription";
    public static string KeyClassCard = "classCard";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyClassContainer, StyleBaseComponentCard.KeyClassContainer },
        { KeyClassCard, "bg-gray-800/50 p-8 rounded-2xl card-hover" },
        { KeyClassIcon, "text-2xl" },
        { KeyClassTitle, "text-xl font-bold mb-3" },
        { KeyClassDescription, "text-gray-400" }
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (ClassCard == null)
            ClassCard = " ";
        if (ClassIcon == null)
            ClassIcon = " ";
        if (ClassTitle == null)
            ClassTitle = " ";
        if (ClassDescription == null)
            ClassDescription = " ";
        

        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);
        ClassCard += " " + classes[KeyClassCard];
        ClassIcon += " " + classes[KeyClassIcon];
        ClassTitle += " " + classes[KeyClassTitle];
        ClassDescription += " " + classes[KeyClassDescription];
        return base.UpdateStyleAsync(classes);
    }
}
public class CardFeaturesModul : ComponentBaseCard<DataFeatures>
{
    public override TypeComponentCard Type => throw new NotImplementedException(); // تحدد لاحقًا حسب النظام

    public static ICollection<string> NAMECLASSES => StylesFeaturesCard.CLASSES.Keys.ToList();

    public override void Build(DataFeatures data)
    {
        DataBuild = data;
    }

    public static CardFeaturesModul Create(DataFeatures data)
    {
        var instance = new CardFeaturesModul();
        instance.Build(data);
        return instance;
    }
}




public class DataAddFeatures : ModulsBase
{
  
   // public DataHeroImageStats? IStats { get; set; } 
    public List<DataFeatures> Items { get; set; }  = new List<DataFeatures>();
}
public class StylesCardAddFeatures : StyleBaseComponentCard
{
    [Parameter] public string? ClassName { get; set; }

    [Parameter] public string? ClassTitle { get; set; }
    [Parameter] public string? ClassDescription { get; set; }
    [Parameter] public string? ClassItems { get; set; }

    public static string KeyClassContainer = "classContainer";
    public static string KeyClassItem { get; set; } = "classItem";
    public static string KeyClassName = "className";

    public static string KeyClassTitle = "classTitle";
    public static string KeyClassDescription = "classDescription";
    public static string KeyClassItems = "classItems";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
            { KeyClassContainer, "py-20 px-4 sm:px-6 lg:px-8 bg-gray-900" },
            { KeyClassItem, "max-w-7xl mx-auto" },
            { KeyClassName, " text-3xl font-bold mb-4" },
            { KeyClassTitle, "text-center mb-16" },
            { KeyClassDescription, "text-gray-400 max-w-3xl mx-auto" },
            { KeyClassItems, "grid grid-cols-1 md:grid-cols-3 gap-8" }
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
        if (ClassItems == null)
            ClassItems = " ";
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);
        ClassContainer += " "+ classes[KeyClassContainer];
        ClassItem += " " + classes[KeyClassItem];
        ClassName += " " + classes[KeyClassName];

        ClassTitle += " " + classes[KeyClassTitle];
        ClassDescription += " " + classes[KeyClassDescription];
        ClassItems += " " + classes[KeyClassItems];
        return base.UpdateStyleAsync(classes);
    }
}

public class CardAddFeatures : ComponentBaseCard<DataAddFeatures>
{
    public List<CardFeaturesModul> Items { get; set; } = new List<CardFeaturesModul>();

    public override TypeComponentCard Type => throw new NotImplementedException();

    public static ICollection<string> NAMECLASSES => StylesCardAddFeatures.CLASSES.Keys.ToList();

    public override void Build(DataAddFeatures db)
    {
        DataBuild = db;
       // IStats = CardHeroImageStats.Create(db.IStats);

        foreach (var item in db.Items)
        {
            var listUnifiedButtonModel = CardFeaturesModul.Create(item);
            Items.Add(listUnifiedButtonModel);
        }
    }

    public static CardAddFeatures Create(DataAddFeatures data)
    {
        var instance = new CardAddFeatures();
        instance.Build(data);
        return instance;
    }

   
}





















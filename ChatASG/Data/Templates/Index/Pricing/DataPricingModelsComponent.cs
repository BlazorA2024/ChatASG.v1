using ChatASG.Data.Templates.Base;
using Data.ModulsPricing;
using Microsoft.AspNetCore.Components;

namespace Data.Pricing;

//public class DataPricingCard :ModulsBase
//{
//    public string? ClassCard { get; set; } 

//    public string Price { get; set; } = "";
//    public string Period { get; set; } = "";
//    public List<string> Features { get; set; } = new();
//    public List<string> DisabledFeatures { get; set; } = new();
//    public string ButtonText { get; set; } = "";
//    public string BadgeText { get; set; } = "";
//    public bool IsPopular { get; set; } = false;
//}
public class StylesPricingCard : StyleBaseComponentCard
{
    [Parameter] public string? ClassCardContainer { get; set; }
    [Parameter] public string? ClassTitle { get; set; }
    [Parameter] public string? ClassDescription { get; set; }
    [Parameter] public string? ClassPrice { get; set; }
    [Parameter] public string? ClassPeriod { get; set; }
    [Parameter] public string? ClassFeatureList { get; set; }
    [Parameter] public string? ClassFeatureItem { get; set; }
    [Parameter] public string? ClassFeatureItemDisabled { get; set; }
    [Parameter] public string? ClassFeatureIconAvailable { get; set; }
    [Parameter] public string? ClassFeatureIconUnavailable { get; set; }
    [Parameter] public string? ClassFeatureTextUnavailable { get; set; }
    [Parameter] public string? ClassButton { get; set; }
    [Parameter] public string? ClassBadge { get; set; }

    public static readonly Dictionary<string, string> CLASSES = new()
    {
        ["ClassCardContainer"] = "pricing-card glass-card p-8 rounded-2xl border border-gray-700 transition duration-300 hover:shadow-xl relative overflow-hidden",
        ["ClassTitle"] = "text-xl font-bold mb-3",
        ["ClassDescription"] = "text-gray-400 mb-6",
        ["ClassPrice"] = "text-4xl font-bold mb-6",
        ["ClassPeriod"] = "text-xl text-gray-400",
        ["ClassFeatureList"] = "space-y-4 mb-8",
        ["ClassFeatureItem"] = "flex items-start text-white",
        ["ClassFeatureItemDisabled"] = "flex items-start text-gray-500",
        ["ClassFeatureIconAvailable"] = "text-accent mr-3 mt-1",
        ["ClassFeatureIconUnavailable"] = "text-gray-600 mr-3 mt-1",
        ["ClassFeatureTextUnavailable"] = "text-gray-500",
        ["ClassButton"] = "w-full py-3 rounded-lg border border-accent text-accent font-medium hover:bg-accent hover:bg-opacity-10 transition",
        ["ClassBadge"] = "absolute top-0 right-0 py-1 px-4 bg-accent text-dark font-bold text-xs rotate-45 translate-x-9 translate-y-3"
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassCardContainer = classes["ClassCardContainer"];
        ClassTitle = classes["ClassTitle"];
        ClassDescription = classes["ClassDescription"];
        ClassPrice = classes["ClassPrice"];
        ClassPeriod = classes["ClassPeriod"];
        ClassFeatureList = classes["ClassFeatureList"];
        ClassFeatureItem = classes["ClassFeatureItem"];
        ClassFeatureItemDisabled = classes["ClassFeatureItemDisabled"];
        ClassFeatureIconAvailable = classes["ClassFeatureIconAvailable"];
        ClassFeatureIconUnavailable = classes["ClassFeatureIconUnavailable"];
        ClassFeatureTextUnavailable = classes["ClassFeatureTextUnavailable"];
        ClassButton = classes["ClassButton"];
        ClassBadge = classes["ClassBadge"];

        return base.UpdateStyleAsync(classes);
    }
}


public class CardPricing : ComponentBaseCard<DataPricingCard>
{
    public static ICollection<string> NAMECLASSES => StylesPricingCard.CLASSES.Keys.ToList();

    public override TypeComponentCard Type => throw new NotImplementedException();

    public override void Build(DataPricingCard db)
    {
        DataBuild = db;
    }

    public static CardPricing Create(DataPricingCard data)
    {
        var instance = new CardPricing();
        instance.Build(data);
        return instance;
    }
}

//public class DataPricingQuiz :ModulsBase
//{

//    public string? ButtonIconClass { get; set; }
//}
public class StylesPricingQuiz : StyleBaseComponentCard
{
    [Parameter] public string? ClassTitle { get; set; }
    [Parameter] public string? ClassDescription { get; set; }
    [Parameter] public string? ClassButton { get; set; }
    [Parameter] public string? ClassButtonIcon { get; set; }

    public static string KeyClassContainer = "classContainer";
    public static string KeyClassTitle = "classTitle";
    public static string KeyClassDescription = "classDescription";
    public static string KeyClassButton = "classButton";
    public static string KeyClassButtonIcon = "classButtonIcon";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyClassContainer, "max-w-2xl mx-auto mt-16 glass-card rounded-2xl p-6 text-center" },
        { KeyClassTitle, "font-bold text-lg mb-3" },
        { KeyClassDescription, "text-gray-400 mb-4" },
        { KeyClassButton, "text-accent font-medium flex items-center justify-center mx-auto" },
        { KeyClassButtonIcon, "fas fa-arrow-right ml-2" }
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (classes == null || IsIgnoredStyle) return Task.FromResult(false);

        ClassContainer = classes[KeyClassContainer];
        ClassTitle = classes[KeyClassTitle];
        ClassDescription = classes[KeyClassDescription];
        ClassButton = classes[KeyClassButton];
        ClassButtonIcon = classes[KeyClassButtonIcon];

        return base.UpdateStyleAsync(classes);
    }
}

public class CardPricingQuiz : ComponentBaseCard<DataPricingQuiz>
{
    public static ICollection<string> NAMECLASSES => StylesPricingQuiz.CLASSES.Keys.ToList();

    public override TypeComponentCard Type => throw new NotImplementedException();
    public override void Build(DataPricingQuiz db)
    {
        DataBuild = db;
    }
    public static CardPricingQuiz Create(DataPricingQuiz data)
    {
        var instance = new CardPricingQuiz();
        instance.Build(data);
        return instance;
    }


}
//public class DataAddPricing : ModulsBase
//{
//    public DataPricingQuiz Iquiz { get; set; }
//    public List<DataPricingCard> Items { get; set; } = new();
//}
public class StylesCardAddPricing : StyleBaseComponentCard
{
    [Parameter] public string? ClassName { get; set; }
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
            { KeyClassContainer, "py-20 px-4 sm:px-10 lg:px-20 xl:px-32 bg-gradient-to-b from-dark/60 to-primary/30" },
            { KeyClassItem, "max-w-4xl mx-auto text-center mb-16" },
            { KeyClassName, " text-3xl sm:text-4xl font-bold mb-6" },
            { KeyClassDescription, "text-lg text-gray-400" },
            { KeyClassItems, "grid md:grid-cols-3 gap-8 max-w-5xl mx-auto" }
    };
    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (KeyClassContainer == null)
            ClassContainer = " ";

        if (KeyClassItem == null)
            ClassItem = " ";
        if (ClassName == null)
            ClassName = " ";

        if (ClassDescription == null)
            ClassDescription = " ";
        if (ClassItems == null)
            ClassItems = " ";
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);
        ClassContainer += " " + classes[KeyClassContainer];
        ClassItem += " " + classes[KeyClassItem];
        ClassName += " " + classes[KeyClassName];

        ClassDescription += " " + classes[KeyClassDescription];
        ClassItems += " " + classes[KeyClassItems];
        return base.UpdateStyleAsync(classes);
    }
}

public class CardAddPricing : ComponentBaseCard<DataAddPricing>
{
    public List<CardPricing> Items { get; set; } = new();
    public CardPricingQuiz Iquiz { get; set; }

    public override TypeComponentCard Type => throw new NotImplementedException();

    public static ICollection<string> NAMECLASSES => StylesCardAddPricing.CLASSES.Keys.ToList();

    public override void Build(DataAddPricing db)
    {
        DataBuild = db;
        Iquiz = CardPricingQuiz.Create(db.Iquiz);

        foreach (var item in db.Items)
        {
            var listUnifiedButtonModel = CardPricing.Create(item);
            Items.Add(listUnifiedButtonModel);
        }
    }

    public static CardAddPricing Create(DataAddPricing data)
    {
        var instance = new CardAddPricing();
        instance.Build(data);
        return instance;
    }

   
}





















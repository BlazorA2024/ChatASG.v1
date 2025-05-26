using ChatASG.Data.Templates.Base;
using Data.HeaderModels;
using Microsoft.AspNetCore.Components;

namespace Data.Ourservices;

public class DataOurservice : ModulsBase
{

    public List<string> Features { get; set; } = new();
}



public class StylesSOurservices : StyleBaseComponentCard
{
    [Parameter] public string? ClassTitle { get; set; }
    [Parameter] public string? ClassDescription { get; set; }
    [Parameter] public string? ClassIframe { get; set; }
    [Parameter] public string? ClassUl { get; set; }

    public static string KeyClassContainer = "classContainer";
    public static string KeyClassTitle = "classTitle";
    public static string KeyClassDescription = "classDescription";
    public static string KeyClassIframe = "classIframe";
    public static string KeyClassItem = "classItem";
    public static string KeyClassUl = "classUl";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
    { KeyClassContainer, "bg-gray-900/50 p-8 rounded-2xl card-hover" },
    { KeyClassTitle, "text-xl font-bold mb-3" },
    { KeyClassDescription, "text-gray-400 mb-4" },
        { KeyClassIframe, "w-full border-none" },
        {KeyClassItem , "flex items-center" },
        {KeyClassUl,"text-gray-400 space-y-2" }
    };
    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (KeyClassContainer == null)
            ClassContainer = " ";
        if (ClassTitle == null)
            ClassTitle = " ";
        if (ClassDescription == null)
            ClassDescription = " ";
        if (ClassIframe == null)
            ClassIframe = " ";
        if (KeyClassItem == null)
            ClassItem = " ";
        if (ClassUl == null)
            ClassUl = " ";
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);
        ClassContainer += " " + classes[KeyClassContainer];
        ClassTitle += " " + classes[KeyClassTitle];
        ClassDescription += " " + classes[KeyClassDescription];
        ClassIframe += " " + classes[KeyClassIframe];
        ClassItem += " " + classes[KeyClassItem];
        ClassUl += " " + classes[KeyClassUl];




        return base.UpdateStyleAsync(classes);
    }
}

public class Ourservices : ComponentBaseCard<DataOurservice>
{
    public override TypeComponentCard Type => throw new NotImplementedException();
    public static ICollection<string> NAMECLASSES => StylesSOurservicesCard.CLASSES.Keys.ToList();

    public static Ourservices Create(DataOurservice data)
    {
        var instance = new Ourservices();
        instance.Build(data);
        return instance;
    }

    public override void Build(DataOurservice db)
    {
        DataBuild = db;
    }
}

public class DataOurservicesCard : ModulsBase
{
      public DataOurservice dataOurservice {  get; set; }
        public string IconBackground { get; set; } = "";
        public List<string> Features { get; set; } = new();
    }

   

public class StylesSOurservicesCard : StyleBaseComponentCard
{
    [Parameter] public string? ClassTitle { get; set; }
    [Parameter] public string? ClassDescription { get; set; }
    [Parameter] public string? ClassIframe { get; set; }

    public static string KeyClassContainer = "classContainer";
    public static string KeyClassItem = "classItem";
    public static string KeyClassTitle = "classTitle";
    public static string KeyClassDescription = "classDescription";
    public static string KeyClassIframe = "classIframe";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
    { KeyClassContainer, "bg-gray-900/50 p-8 rounded-2xl card-hover" },
        {KeyClassItem,"flex items-start" },
    { KeyClassTitle, "text-xl font-bold mb-3" },
    { KeyClassDescription, "text-gray-400 mb-4" },
        { KeyClassIframe, "w-full border-none" }
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
        if (ClassIframe == null)
            ClassIframe = " ";
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassContainer += " " + classes[KeyClassContainer];
        ClassItem += " " + classes[KeyClassItem];

        ClassTitle += " " + classes[KeyClassTitle];
        ClassDescription += " " + classes[KeyClassDescription];
        ClassIframe += " " + classes[KeyClassIframe];
       

        return base.UpdateStyleAsync(classes);
    }
}

public class CardOurservices : ComponentBaseCard<DataOurservicesCard>
{
    public override TypeComponentCard Type => throw new NotImplementedException();
    public static ICollection<string> NAMECLASSES => StylesSOurservicesCard.CLASSES.Keys.ToList();
    public Ourservices? dataOurservice { get; set; }

    public static CardOurservices Create(DataOurservicesCard data)
    {
        var instance = new CardOurservices();
        instance.Build(data);
        return instance;
    }

    public override void Build(DataOurservicesCard db)
    {
        DataBuild = db;
        dataOurservice =Ourservices.Create(db.dataOurservice);
    }
}

public class DataAddStudios : ModulsBase
{
    public List<DataOurservicesCard> Items { get; set; } = new();
}

public class StylesCardOurservices : StyleBaseComponentCard
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
            { KeyClassContainer, "py-20 px-4 sm:px-6 lg:px-8 bg-gray-800" },
            { KeyClassItem, "max-w-7xl mx-auto" },
            { KeyClassName, " text-3xl font-bold mb-4" },
            { KeyClassTitle, "text-center mb-16" },
            { KeyClassDescription, "text-gray-400 max-w-3xl mx-auto" },
            { KeyClassItems, "grid grid-cols-1 lg:grid-cols-2 gap-8" }
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

public class CardAddOurservices : ComponentBaseCard<DataAddStudios>
{
    public List<CardOurservices> Items { get; set; } = new();

    public override TypeComponentCard Type => throw new NotImplementedException();

    public static ICollection<string> NAMECLASSES => StylesCardOurservices.CLASSES.Keys.ToList();

    public override void Build(DataAddStudios db)
    {
        DataBuild = db;
       // IStats = CardHeroImageStats.Create(db.IStats);

        foreach (var item in db.Items)
        {
            var listUnifiedButtonModel = CardOurservices.Create(item);
            Items.Add(listUnifiedButtonModel);
        }
    }

    public static CardAddOurservices Create(DataAddStudios data)
    {
        var instance = new CardAddOurservices();
        instance.Build(data);
        return instance;
    }

   
}





















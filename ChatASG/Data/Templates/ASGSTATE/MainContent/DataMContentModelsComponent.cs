using ChatASG.Data.Templates.Base;
using Microsoft.AspNetCore.Components;

namespace Data.MainContent;
public class DataButton
{

    public string? Icon { get; set; }
    public string? ClassColor { get; set; }
    public string? Button { get; set; }
    public string ClassButton { get; set; } = "";

}
public class CardButton : ComponentBaseCard<DataButton>
{
    // public static ICollection<string> NAMECLASSES => StylesPricingCard.CLASSES.Keys.ToList();

    public override TypeComponentCard Type => throw new NotImplementedException();

    public override void Build(DataButton db)
    {
        DataBuild = db;
    }

    public static CardButton Create(DataButton data)
    {
        var instance = new CardButton();
        instance.Build(data);
        return instance;
    }
}
public class DataStatecards
{
    public string? Icon { get; set; }
    public string Title { get; set; }
    public string? ClassColor { get; set; }
    public string? Button { get; set; }
    public string ClassButton { get; set; } = "";

}
public class StylesCardStatecards : StyleBaseComponentCard
{
    [Parameter] public string? ClassTitle { get; set; }
    [Parameter] public string? ClassIcon { get; set; }
    [Parameter] public string? ClassIconrounded { get; set; }

    public static string KeyClassItem { get; set; } = "classItem";
    public static string KeyClassIconrounded = "classIconrounded";

    public static string KeyClassIcon = "classIcon";


    public static string KeyClassTitle = "classTitle";


    public static readonly new Dictionary<string, string> CLASSES = new()
        {
        { KeyClassItem, "space-y-3 max-h-64 overflow-y-auto pr-2" },
        { KeyClassTitle, "text-sm" },
         {KeyClassIconrounded, " text-center py-4 text-gray-500" },
        {KeyClassIcon, " mb-1" }
        };
    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {


        if (KeyClassItem == null)
            ClassItem = " ";
        if (ClassIconrounded == null)
            ClassIconrounded = " ";
        if (ClassIcon == null)
            ClassIcon = " ";
        if (ClassTitle == null)
            ClassTitle = " ";


        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassItem += " " + classes[KeyClassItem];
        ClassIconrounded += " " + classes[KeyClassIconrounded];

        ClassIcon += " " + classes[KeyClassIcon];

        ClassTitle += " " + classes[KeyClassTitle];

        return base.UpdateStyleAsync(classes);
    }
}
public class CardStatecards : ComponentBaseCard<DataStatecards>
{
     public static ICollection<string> NAMECLASSES => StylesCardStatecards.CLASSES.Keys.ToList();

    public override TypeComponentCard Type => throw new NotImplementedException();

    public override void Build(DataStatecards db)
    {
        DataBuild = db;
    }

    public static CardStatecards Create(DataStatecards data)
    {
        var instance = new CardStatecards();
        instance.Build(data);
        return instance;
    }
}
public class DataClearAll
{

    public string? Icon { get; set; }
    public string? ClassColor { get; set; }
    public string? Button { get; set; }
    public string ClassButton { get; set; } = "";
    public string Statefields { get; set; }
    public int StateCount { get; set; } = 0;


}
public class StylesCardClearAll : StyleBaseComponentCard
{
    [Parameter] public string? ClassCount { get; set; }
    [Parameter] public string? ClassIcon { get; set; }
    [Parameter] public string? Classbutton { get; set; }

    public static string KeyClassItem { get; set; } = "classItem";
    public static string KeyClassbutton = "classbutton";

    public static string KeyClassIcon = "classIcon";


    public static string KeyClassCount = "classCount";


    public static readonly new Dictionary<string, string> CLASSES = new()
        {
        { KeyClassItem, "pt-2 flex justify-between items-center" },
        { KeyClassCount, "text-xs text-gray-500" },
         {KeyClassbutton, " text-red-600 hover:text-red-800 text-sm transition flex items-center" },
        {KeyClassIcon, " mr-1" }
        };
    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {


        if (KeyClassItem == null)
            ClassItem = " ";
        if (Classbutton == null)
            Classbutton = " ";
        if (ClassIcon == null)
            ClassIcon = " ";
        if (ClassCount == null)
            ClassCount = " ";


        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassItem += " " + classes[KeyClassItem];
        Classbutton += " " + classes[KeyClassbutton];

        ClassIcon += " " + classes[KeyClassIcon];

        ClassCount += " " + classes[KeyClassCount];

        return base.UpdateStyleAsync(classes);
    }
}
public class CardClearAll : ComponentBaseCard<DataClearAll>
{
    public static ICollection<string> NAMECLASSES => StylesCardClearAll.CLASSES.Keys.ToList();

    public override TypeComponentCard Type => throw new NotImplementedException();

    public override void Build(DataClearAll db)
    {
        DataBuild = db;
    }

    public static CardClearAll Create(DataClearAll data)
    {
        var instance = new CardClearAll();
        instance.Build(data);
        return instance;
    }
}
public class DataStateField
    {
        public string Key { get; set; }
        public string DisplayName { get; set; }
    }
public class DataStateConfig
{
    public string Icon { get; set; } 
    public string Title { get; set; } 
    public string Tag { get; set; }
    public DataButton? IButton { get; set; }
    public DataStatecards Statecards { get; set; }
    public DataClearAll clearAll { get; set; }
    public List<DataStateField> AvailableFields { get; set; }
    public List<string> SelectedFields { get; set; } = new();
}
public class StylesCardStateField : StyleBaseComponentCard
{
    [Parameter] public string? ClassTitle { get; set; }

    [Parameter] public string? ClassSelect { get; set; }

    public static string KeyClassContainer = "classContainer";
    public static string KeyClassItem { get; set; } = "classItem";
    public static string KeyClassSelect = "classSelect";



    public static string KeyClassTitle = "classTitle";


    public static readonly new Dictionary<string, string> CLASSES = new()
        {
        { KeyClassContainer, " space-y-4" },
        { KeyClassItem, "flex items-center space-x-2" },
        { KeyClassTitle, " block text-sm font-medium text-gray-700 mb-1" },

         {KeyClassSelect, "flex-1 border border-gray-300 rounded-md px-3 py-2 focus:outline-none focus:ring-2 focus:ring-blue-500 text-sm" }
        };
    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (KeyClassContainer == null)
            ClassContainer = " ";

        if (KeyClassItem == null)
            ClassItem = " ";
        if (ClassSelect == null)
            ClassSelect = " ";
        
            if (ClassTitle == null)
            ClassTitle = " ";


        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassContainer += " " + classes[KeyClassContainer];
        ClassItem += " " + classes[KeyClassItem];
        ClassSelect += " " + classes[KeyClassSelect];


        ClassTitle += " " + classes[KeyClassTitle];
        return base.UpdateStyleAsync(classes);
    }
}


public class CardStateField : ComponentBaseCard<DataStateConfig>
{

    // public List<CardButton> Items { get; set; } = new();
    public CardButton? IButton { get; set; }
    public CardStatecards Statecards { get; set; }
    public CardClearAll clearAll { get; set; }

    public override TypeComponentCard Type => throw new NotImplementedException();

   public static ICollection<string> NAMECLASSES => StylesCardStateField.CLASSES.Keys.ToList();

    public override void Build(DataStateConfig db)
    {
        DataBuild = db;
        IButton= CardButton.Create(db.IButton);
        Statecards = CardStatecards.Create(db.Statecards);
        clearAll = CardClearAll.Create(db.clearAll);


    }

    public static CardStateField Create(DataStateConfig data)
    {
        var instance = new CardStateField();
        instance.Build(data);
        return instance;
    }


}



public class DataAddStateField : ModulsBase
{
    public string? Name { get; set; }

    public string Tag { get; set; } = "9 Fields";
    public DataStateConfig stateConfig { get; set; }

    // public List<DataButton> Items { get; set; } = new();
}
public class StylesCardAddStateField : StyleBaseComponentCard
{
    [Parameter] public string? ClassName { get; set; }
    [Parameter] public string? ClassTag { get; set; }
    [Parameter] public string? ClassItems { get; set; }
    [Parameter] public string? ClassIcon { get; set; }

    public static string KeyClassContainer = "classContainer";
    public static string KeyClassItem { get; set; } = "classItem";

    public static string KeyClassIcon = "classIcon";

    public static string KeyClassName = "className";

    public static string KeyClassTitle = "classTitle";
    public static string KeyClassTag = "classTag";
    public static string KeyClassItems = "classItems";

    public static readonly new Dictionary<string, string> CLASSES = new()
        {
        { KeyClassContainer, "lg:col-span-1 space-y-6" },
        { KeyClassItem, "card bg-white rounded-xl p-6" },
        { KeyClassName, "  text-xl font-semibold text-gray-800 flex items-center" },
        { KeyClassTag, " text-xs bg-blue-100 text-blue-800 px-2 py-1 rounded-full" },
        { KeyClassItems, "flex items-center justify-between mb-4" },
        {KeyClassIcon, " mr-2 text-blue-600" }
        };
    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (KeyClassContainer == null)
            ClassContainer = " ";

        if (KeyClassItem == null)
            ClassItem = " ";

        if (ClassIcon == null)
            ClassIcon = " ";
        if (ClassName == null)
            ClassName = " ";

        if (ClassTag == null)
            ClassTag = " ";
        if (ClassItems == null)
            ClassItems = " ";
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassContainer += " " + classes[KeyClassContainer];
        ClassItem += " " + classes[KeyClassItem];

        ClassIcon += " " + classes[KeyClassIcon];

        ClassName += " " + classes[KeyClassName];

        ClassTag += " " + classes[KeyClassTag];
        ClassItems += " " + classes[KeyClassItems];
        return base.UpdateStyleAsync(classes);
    }
}
public class CardAddStateField : ComponentBaseCard<DataAddStateField>
{

    // public List<CardButton> Items { get; set; } = new();
    public CardStateField stateConfig { get; set; }

    public override TypeComponentCard Type => throw new NotImplementedException();

    public static ICollection<string> NAMECLASSES => StylesCardAddStateField.CLASSES.Keys.ToList();

    public override void Build(DataAddStateField db)
    {
        DataBuild = db;
        stateConfig = CardStateField.Create(db.stateConfig);

        
    }

    public static CardAddStateField Create(DataAddStateField data)
    {
        var instance = new CardAddStateField();
        instance.Build(data);
        return instance;
    }

   
}





















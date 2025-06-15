using ChatASG.Data.Templates.Base;
using Microsoft.AspNetCore.Components;

namespace Data.AttackTechniques;
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
public class DataSelectedTechniques
{
    public string? Icon { get; set; }
    public string Title { get; set; }
    public string? ClassColor { get; set; }
    public string? Selected { get; set; }
    public string ClassButton { get; set; } = "";

}
public class StylesCardSelectedTechniques : StyleBaseComponentCard
{
    [Parameter] public string? ClassTitle { get; set; }
    [Parameter] public string? ClassIcon { get; set; }
    [Parameter] public string? ClassSelected { get; set; }

    public static string KeyClassItem { get; set; } = "classItem";
    public static string KeyClassSelected = "classSelected";

    public static string KeyClassIcon = "classIcon";


    public static string KeyClassTitle = "classTitle";


    public static readonly new Dictionary<string, string> CLASSES = new()
        {
       { KeyClassItem, "border rounded-md p-3 bg-gray-50 max-h-64 overflow-y-auto" },
        { KeyClassTitle, " text-sm font-medium text-gray-700 mb-2 flex items-center" },
         { KeyClassSelected, " text-center py-4 text-gray-500 text-sm" },
        { KeyClassIcon, " mr-1 text-gray-500" }
        };
    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {


        if (KeyClassItem == null)
            ClassItem = " ";
        if (ClassSelected == null)
            ClassSelected = " ";
        if (ClassIcon == null)
            ClassIcon = " ";
        if (ClassTitle == null)
            ClassTitle = " ";


        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassItem += " " + classes[KeyClassItem];
        ClassSelected += " " + classes[KeyClassSelected];

        ClassIcon += " " + classes[KeyClassIcon];

        ClassTitle += " " + classes[KeyClassTitle];

        return base.UpdateStyleAsync(classes);
    }
}
public class CardSelectedTechniques : ComponentBaseCard<DataSelectedTechniques>
{
     public static ICollection<string> NAMECLASSES => StylesCardSelectedTechniques.CLASSES.Keys.ToList();

    public override TypeComponentCard Type => throw new NotImplementedException();

    public override void Build(DataSelectedTechniques db)
    {
        DataBuild = db;
    }

    public static CardSelectedTechniques Create(DataSelectedTechniques data)
    {
        var instance = new CardSelectedTechniques();
        instance.Build(data);
        return instance;
    }
}

public class DataStateField
    {
        public string Key { get; set; }
        public string DisplayName { get; set; }
    }
public class DataTechnique
{
    public string Icon { get; set; } 
    public string Title { get; set; } 
    public string Tag { get; set; }
    public DataButton? IButton { get; set; }
    public DataSelectedTechniques Statecards { get; set; }
    public List<DataStateField> AvailableFields { get; set; }
    public List<string> SelectedFields { get; set; } = new();
}
public class StylesCardTechnique : StyleBaseComponentCard
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
        { KeyClassTitle, "block text-sm font-medium text-gray-700 mb-1" },

         {KeyClassSelect, "w-full border border-gray-300 rounded-md px-3 py-2 focus:outline-none focus:ring-2 focus:ring-blue-500 text-sm" }
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


public class CardTechnique : ComponentBaseCard<DataTechnique>
{

    // public List<CardButton> Items { get; set; } = new();
    public CardButton? IButton { get; set; }
    public CardSelectedTechniques Statecards { get; set; }

    public override TypeComponentCard Type => throw new NotImplementedException();

   public static ICollection<string> NAMECLASSES => StylesCardTechnique.CLASSES.Keys.ToList();

    public override void Build(DataTechnique db)
    {
        DataBuild = db;
        IButton= CardButton.Create(db.IButton);
        Statecards = CardSelectedTechniques.Create(db.Statecards);


    }

    public static CardTechnique Create(DataTechnique data)
    {
        var instance = new CardTechnique();
        instance.Build(data);
        return instance;
    }


}



public class DataAddAttack : ModulsBase
{
    public string? Name { get; set; }

    public string Tag { get; set; } = "9 Fields";
    public DataTechnique stateConfig { get; set; }

    // public List<DataButton> Items { get; set; } = new();
}
public class StylesCardAddAttack : StyleBaseComponentCard
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
        { KeyClassTag, " text-xs bg-red-100 text-red-800 px-2 py-1 rounded-full" },
        { KeyClassItems, "flex items-center justify-between mb-4" },
        {KeyClassIcon, " mr-2 text-red-600" }
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
public class CardAddAttack : ComponentBaseCard<DataAddAttack>
{

    // public List<CardButton> Items { get; set; } = new();
    public CardTechnique stateConfig { get; set; }

    public override TypeComponentCard Type => throw new NotImplementedException();

    public static ICollection<string> NAMECLASSES => StylesCardAddAttack.CLASSES.Keys.ToList();

    public override void Build(DataAddAttack db)
    {
        DataBuild = db;
        stateConfig = CardTechnique.Create(db.stateConfig);

        
    }

    public static CardAddAttack Create(DataAddAttack data)
    {
        var instance = new CardAddAttack();
        instance.Build(data);
        return instance;
    }

   
}





















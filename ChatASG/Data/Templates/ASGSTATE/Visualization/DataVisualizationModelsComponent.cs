using ChatASG.Data.Templates.Base;
using Data.AttackTechniques;
using Microsoft.AspNetCore.Components;

namespace Data.Visualization;
public class DataButton
{
   
    public string? Icon { get; set; }
    public string? ClassColor { get; set; }
    public string? Button { get; set; }
    public string ClassButton { get; set; } = "";
    public string? Datatab { get; set; }
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
public class DataContents
{
    public string? Icon { get; set; }
    public string Title { get; set; }
   

}
public class StylesCardContents : StyleBaseComponentCard
{
    [Parameter] public string? ClassTitle { get; set; }
    

    public static string KeyClassItem { get; set; } = "classItem";
  

    public static string KeyClassTitle = "classTitle";


    public static readonly new Dictionary<string, string> CLASSES = new()
        {
       { KeyClassItem, "tab-content active" },
        { KeyClassTitle, " graph-container bg-gray-50 rounded-lg p-4 h-64 flex items-center justify-center relative" },
        
        };
    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {


        if (KeyClassItem == null)
            ClassItem = " ";
       
        if (ClassTitle == null)
            ClassTitle = " ";


        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassItem += " " + classes[KeyClassItem];
       

        ClassTitle += " " + classes[KeyClassTitle];

        return base.UpdateStyleAsync(classes);
    }
}
public class CardContents : ComponentBaseCard<DataContents>
{
    public static ICollection<string> NAMECLASSES => StylesCardContents.CLASSES.Keys.ToList();

    public override TypeComponentCard Type => throw new NotImplementedException();

    public override void Build(DataContents db)
    {
        DataBuild = db;
    }

    public static CardContents Create(DataContents data)
    {
        var instance = new CardContents();
        instance.Build(data);
        return instance;
    }
}

public class DataAttack
{
    public string? Icon { get; set; }
    public string Title { get; set; }
    public string? ClassColor { get; set; }
    public string? Name { get; set; }

}
public class StylesCardAttack : StyleBaseComponentCard
{
    [Parameter] public string? ClassTitle { get; set; }
    [Parameter] public string? ClassIcon { get; set; }
    [Parameter] public string? ClassName { get; set; }
    public static string KeyClassContainer = "classContainer";

    public static string KeyClassItem { get; set; } = "classItem";
    public static string KeyClassName = "className";

    public static string KeyClassIcon = "classIcon";


    public static string KeyClassTitle = "classTitle";


    public static readonly new Dictionary<string, string> CLASSES = new()
        {
        {KeyClassContainer,"tab-content" },
       { KeyClassItem, "bg-gray-50 p-4 rounded-md h-64 overflow-y-auto" },
        { KeyClassTitle, " list-decimal pl-5 space-y-2" },
         { KeyClassName, "font-medium text-gray-700 mb-3 flex items-center" },
        { KeyClassIcon, " mr-2 text-gray-500" }
        };
    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (KeyClassContainer == null)
            ClassContainer = " ";

        if (KeyClassItem == null)
            ClassItem = " ";
        if (ClassName == null)
            ClassName = " ";
        if (ClassIcon == null)
            ClassIcon = " ";
        if (ClassTitle == null)
            ClassTitle = " ";


        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassContainer += " " + classes[KeyClassContainer];

        ClassItem += " " + classes[KeyClassItem];
        ClassName += " " + classes[KeyClassName];

        ClassIcon += " " + classes[KeyClassIcon];

        ClassTitle += " " + classes[KeyClassTitle];

        return base.UpdateStyleAsync(classes);
    }
}
public class CardAttack : ComponentBaseCard<DataAttack>
{
    public static ICollection<string> NAMECLASSES => StylesCardAttack.CLASSES.Keys.ToList();

    public override TypeComponentCard Type => throw new NotImplementedException();

    public override void Build(DataAttack db)
    {
        DataBuild = db;
    }

    public static CardAttack Create(DataAttack data)
    {
        var instance = new CardAttack();
        instance.Build(data);
        return instance;
    }
}
public class DataValidation
{
    public string? Name { get; set; }

    public string? Icon { get; set; }
    public string Title { get; set; }
    public string? Icons { get; set; }

    public string? Description { get; set; }

}
public class StylesCardValidation : StyleBaseComponentCard
{
    [Parameter] public string? ClassTitle { get; set; }
    [Parameter] public string? ClassIcon { get; set; }
    [Parameter] public string? ClassName { get; set; }
    [Parameter] public string? ClassDescription { get; set; }
    [Parameter] public string? ClassIcons { get; set; }

    public static string KeyClassContainer = "classContainer";

    public static string KeyClassItem { get; set; } = "classItem";
    public static string KeyClassName = "className";

    public static string KeyClassIcon = "classIcon";
    public static string KeyClassIcons = "classIcons";


    public static string KeyClassTitle = "classTitle";
    public static string KeyClassDescription = "classDescription";


    public static readonly new Dictionary<string, string> CLASSES = new()
        {
        {KeyClassContainer,"tab-content" },
       { KeyClassItem, "bg-gray-50 p-4 rounded-md h-64 overflow-y-auto" },
        { KeyClassTitle, "  text-sm" },
         { KeyClassName, "font-medium text-gray-700 mb-3 flex items-center" },
        { KeyClassIcon, "mr-2 text-gray-500" },
        {KeyClassDescription,"text-xs mt-1"},
        { KeyClassIcons, "text-2xl mb-2" },

        };
    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (KeyClassContainer == null)
            ClassContainer = " ";

        if (KeyClassItem == null)
            ClassItem = " ";
        if (ClassName == null)
            ClassName = " ";
        if (ClassIcon == null)
            ClassIcon = " ";
        if (ClassTitle == null)
            ClassTitle = " ";
        if (ClassDescription == null)
            ClassDescription = " ";
        if (ClassIcons == null)
            ClassIcons = " ";
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassContainer += " " + classes[KeyClassContainer];

        ClassItem += " " + classes[KeyClassItem];
        ClassName += " " + classes[KeyClassName];

        ClassIcon += " " + classes[KeyClassIcon];

        ClassTitle += " " + classes[KeyClassTitle];
        ClassDescription += " " + classes[KeyClassDescription];
        ClassIcons += " " + classes[KeyClassIcons];

        return base.UpdateStyleAsync(classes);
    }
}

public class CardValidation : ComponentBaseCard<DataValidation>
{
    public static ICollection<string> NAMECLASSES => StylesCardValidation.CLASSES.Keys.ToList();

    public override TypeComponentCard Type => throw new NotImplementedException();

    public override void Build(DataValidation db)
    {
        DataBuild = db;
    }

    public static CardValidation Create(DataValidation data)
    {
        var instance = new CardValidation();
        instance.Build(data);
        return instance;
    }
}

public class DataAddVisualization : ModulsBase
{
    public DataContents IContents { get; set; }
    public DataAttack IAttack { get; set; }
    public DataValidation IValidation    { get; set; }
   public List<DataButton> Items { get; set; } = new();
}
public class StylesCardAddVisualization : StyleBaseComponentCard
{
   

    public static string KeyClassContainer = "classContainer";
    public static string KeyClassItem { get; set; } = "classItem";
  

    public static readonly new Dictionary<string, string> CLASSES = new()
        {
        { KeyClassContainer, "card bg-white rounded-xl p-6" },
        { KeyClassItem, "flex items-center space-x-3" },
       
        };
    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (KeyClassContainer == null)
            ClassContainer = " ";

        if (KeyClassItem == null)
            ClassItem = " ";
       
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassContainer += " " + classes[KeyClassContainer];
        ClassItem += " " + classes[KeyClassItem];
       
        return base.UpdateStyleAsync(classes);
    }
}

public class CardAddVisualization : ComponentBaseCard<DataAddVisualization>
{
   
    public List<CardButton> Items { get; set; } = new();
    public CardContents IContents { get; set; }
    public CardAttack IAttack { get; set; }
    public CardValidation IValidation { get; set; }


    public override TypeComponentCard Type => throw new NotImplementedException();

    public static ICollection<string> NAMECLASSES => StylesCardAddVisualization.CLASSES.Keys.ToList();

    public override void Build(DataAddVisualization db)
    {
        DataBuild = db;
        IContents = CardContents.Create(db.IContents);
        IAttack = CardAttack.Create(db.IAttack);
        IValidation= CardValidation.Create(db.IValidation);

        foreach (var item in db.Items)
        {
            var listUnifiedButtonModel = CardButton.Create(item);
            Items.Add(listUnifiedButtonModel);
        }
    }

    public static CardAddVisualization Create(DataAddVisualization data)
    {
        var instance = new CardAddVisualization();
        instance.Build(data);
        return instance;
    }

   
}





















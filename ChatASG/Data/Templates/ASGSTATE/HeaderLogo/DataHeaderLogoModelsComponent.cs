using ChatASG.Data.Templates.Base;
using Microsoft.AspNetCore.Components;

namespace Data.ASGSTATE;
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


public class DataAddHeader : ModulsBase
{

   public List<DataButton> Items { get; set; } = new();
}
public class StylesCardAddHeader : StyleBaseComponentCard
{
    [Parameter] public string? ClassName { get; set; }
    [Parameter] public string? ClassDescription { get; set; }
    [Parameter] public string? ClassItems { get; set; }
    [Parameter] public string? ClassIcon { get; set; }
    [Parameter] public string? ClassIconrounded { get; set; }

    public static string KeyClassContainer = "classContainer";
    public static string KeyClassItem { get; set; } = "classItem";
    public static string KeyClassIconrounded = "classIconrounded";

    public static string KeyClassIcon = "classIcon";

    public static string KeyClassName = "className";

    //public static string KeyClassTitle = "classTitle";
    public static string KeyClassDescription = "classDescription";
    public static string KeyClassItems = "classItems";

    public static readonly new Dictionary<string, string> CLASSES = new()
        {
        { KeyClassContainer, " mb-8 flex items-center justify-between" },
        { KeyClassItem, "flex items-center space-x-3" },
        { KeyClassName, " text-3xl font-bold text-gray-800" },
        { KeyClassDescription, " text-gray-600" },
        { KeyClassItems, "flex items-center space-x-4" },
         {KeyClassIconrounded, "bg-blue-600 text-white p-2 rounded-lg" },
        {KeyClassIcon, "text-2xl" }
        };
    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (KeyClassContainer == null)
            ClassContainer = " ";

        if (KeyClassItem == null)
            ClassItem = " ";
        if (ClassIconrounded == null)
            ClassIconrounded = " ";
        if (ClassIcon == null)
            ClassIcon = " ";
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
        ClassIconrounded += " " + classes[KeyClassIconrounded];

        ClassIcon += " " + classes[KeyClassIcon];

        ClassName += " " + classes[KeyClassName];

        ClassDescription += " " + classes[KeyClassDescription];
        ClassItems += " " + classes[KeyClassItems];
        return base.UpdateStyleAsync(classes);
    }
}

public class CardAddHeader : ComponentBaseCard<DataAddHeader>
{
    public string? Name { get; set; }

    public string? Description { get; set; }
    public List<CardButton> Items { get; set; } = new();

    public override TypeComponentCard Type => throw new NotImplementedException();

    public static ICollection<string> NAMECLASSES => StylesCardAddHeader.CLASSES.Keys.ToList();

    public override void Build(DataAddHeader db)
    {
        DataBuild = db;
        // Iquiz = CardPricingQuiz.Create(db.Iquiz);

        foreach (var item in db.Items)
        {
            var listUnifiedButtonModel = CardButton.Create(item);
            Items.Add(listUnifiedButtonModel);
        }
    }

    public static CardAddHeader Create(DataAddHeader data)
    {
        var instance = new CardAddHeader();
        instance.Build(data);
        return instance;
    }

   
}





















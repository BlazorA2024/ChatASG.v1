using ChatASG.Data.Templates.Base;
using Microsoft.AspNetCore.Components;

namespace Data.ScenarioGeneration;
public class DataGeneration
{
   
    public string? Icon { get; set; }
    public string? ClassColor { get; set; }
    public string? Button { get; set; }
    public string ClassButton { get; set; } = "";

}
public class CardGeneration : ComponentBaseCard<DataGeneration>
{
   // public static ICollection<string> NAMECLASSES => StylesPricingCard.CLASSES.Keys.ToList();

    public override TypeComponentCard Type => throw new NotImplementedException();

    public override void Build(DataGeneration db)
    {
        DataBuild = db;
    }

    public static CardGeneration Create(DataGeneration data)
    {
        var instance = new CardGeneration();
        instance.Build(data);
        return instance;
    }
}

public class DataResults
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Title { get; set; }
    public string? Icon { get; set; }
    public string? ClassIcon { get; set; }
    public string? Icons { get; set; }
    public string ClassIcons { get; set; } = "";

}
public class CardResults : ComponentBaseCard<DataResults>
{
    // public static ICollection<string> NAMECLASSES => StylesPricingCard.CLASSES.Keys.ToList();

    public override TypeComponentCard Type => throw new NotImplementedException();

    public override void Build(DataResults db)
    {
        DataBuild = db;
    }

    public static CardResults Create(DataResults data)
    {
        var instance = new CardResults();
        instance.Build(data);
        return instance;
    }
}
public class DataAddScenario : ModulsBase
{
    public DataResults results { get; set; }
   public List<DataGeneration> Items { get; set; } = new();
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

public class CardAddScenario : ComponentBaseCard<DataAddScenario>
{
  
    public List<CardGeneration> Items { get; set; } = new();
    public CardResults results { get; set; }

    public override TypeComponentCard Type => throw new NotImplementedException();

    public static ICollection<string> NAMECLASSES => StylesCardAddHeader.CLASSES.Keys.ToList();

    public override void Build(DataAddScenario db)
    {
        DataBuild = db;
        results = CardResults.Create(db.results);

        foreach (var item in db.Items)
        {
            var listUnifiedButtonModel = CardGeneration.Create(item);
            Items.Add(listUnifiedButtonModel);
        }
    }

    public static CardAddScenario Create(DataAddScenario data)
    {
        var instance = new CardAddScenario();
        instance.Build(data);
        return instance;
    }

   
}





















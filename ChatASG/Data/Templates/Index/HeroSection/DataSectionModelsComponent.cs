using ChatASG.Data.Templates.Base;
using Data.HeaderModels;
using Microsoft.AspNetCore.Components;

namespace Data.Section;
public class DataButtons : ModulsBase
{
    
}

public class StylesButtonIcon : StyleBaseComponentCard
{
    [Parameter] public string? ClassButton { get; set; }
    [Parameter] public string? ClassIcon { get; set; }
    [Parameter] public string? ClassText { get; set; }

    public static string KeyClassButton = "classButton";
    public static string KeyClassIcon = "classIcon";
    public static string KeyClassText = "classText";

    public static readonly new Dictionary<string, string> CLASSES = new()
        {
            { KeyClassContainer, StyleBaseComponentCard.KeyClassContainer },
            { KeyClassButton, " bg-blue-600 hover:bg-blue-700 text-white px-6 py-3 rounded-md text-lg font-medium transition duration-300 flex items-center justify-center" },
            { KeyClassIcon, "mr-2" },
           // { KeyClassText, "text-xl font-semibold mb-4 text-purple-400" }
        };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (ClassButton == null)
            ClassButton = " ";
        if (ClassIcon == null)
            ClassIcon = " ";
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassButton += " " + classes[KeyClassButton];
        ClassIcon += " " + classes[KeyClassIcon];
        // ClassText ??= classes[KeyClassText];

        return base.UpdateStyleAsync(classes);
    }
}


public class CardButtonsModul : ComponentBaseCard<DataButtons>
{
    public override TypeComponentCard Type => throw new NotImplementedException();
    public static ICollection<string> NAMECLASSES => StylesButtonIcon.CLASSES.Keys.ToList();
    public override void Build(DataButtons db) => DataBuild = db;
    public static CardButtonsModul Create(DataButtons data)
    {
        var instance = new CardButtonsModul();
        instance.Build(data);
        return instance;
    }
}
public class DataHeroImageStats : ModulsBase
{

}
public class StylesHeroImageStats : StyleBaseComponentCard
{
    [Parameter] public string? ClassImage { get; set; }
    [Parameter] public string? ClassStats { get; set; }

    public static string KeyClassImage = "classImage";
    public static string KeyClassStats = "classStats";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyClassImage, "cyber-border rounded-2xl overflow-hidden" },
        { KeyClassStats, "absolute -bottom-6 -left-6 bg-blue-600 p-4 rounded-xl shadow-xl text-white text-center" }
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (ClassImage == null)
            ClassImage = " ";
        if (ClassStats == null)
            ClassStats = " ";
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);
        ClassImage +=" "+ classes[KeyClassImage];
        ClassStats +=" "+ classes[KeyClassStats];
        return base.UpdateStyleAsync(classes);
    }
}

public class CardHeroImageStats : ComponentBaseCard<DataHeroImageStats>
{
    public override TypeComponentCard Type => throw new NotImplementedException();

    public static ICollection<string> NAMECLASSES => StylesHeroImageStats.CLASSES.Keys.ToList();

    public override void Build(DataHeroImageStats db) => DataBuild = db;


    public static CardHeroImageStats Create(DataHeroImageStats data)
    {
        var instance = new CardHeroImageStats();
        instance.Build(data);
        return instance;
    }

   
}


public class DataHeroIntro : ModulsBase
{
  
    public DataHeroImageStats? IStats { get; set; } 
    public List<DataButtons> Items { get; set; } = new();
}
public class StylesHeroIntro : StyleBaseComponentCard
{
    [Parameter] public string? ClassTitle { get; set; }
    [Parameter] public string? ClassDescription { get; set; }
    [Parameter] public string? ClassButtons { get; set; }

    public static string KeyClassContainer = "classContainer";
    public static string KeyClassTitle = "classTitle";
    public static string KeyClassDescription = "classDescription";
    public static string KeyClassButtons = "classButtons";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyClassContainer, "grid grid-cols-1 md:grid-cols-2 gap-12 items-center" },
        { KeyClassTitle, "text-4xl md:text-5xl font-bold mb-6 leading-tight" },
        { KeyClassDescription, "text-lg text-gray-300 mb-8" },
        { KeyClassButtons, "flex flex-col sm:flex-row gap-4" }
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (KeyClassContainer == null)
            ClassContainer = " ";
        if (ClassTitle == null)
            ClassTitle = " ";
        if (ClassDescription == null)
            ClassDescription = " ";
        if (ClassButtons == null)
            ClassButtons = " ";
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);
        ClassContainer += " "+ classes[KeyClassContainer];
        ClassTitle += " " + classes[KeyClassTitle];
        ClassDescription += " " + classes[KeyClassDescription];
        ClassButtons += " " + classes[KeyClassButtons];
        return base.UpdateStyleAsync(classes);
    }
}

public class CardHeroIntro : ComponentBaseCard<DataHeroIntro>
{
    public List<CardButtonsModul> Items { get; set; } = new();
    public CardHeroImageStats? IStats { get; set; } 

    public override TypeComponentCard Type => throw new NotImplementedException();

    public static ICollection<string> NAMECLASSES => StylesHeroIntro.CLASSES.Keys.ToList();

    public override void Build(DataHeroIntro db)
    {
        DataBuild = db;
        IStats = CardHeroImageStats.Create(db.IStats);

        foreach (var item in db.Items)
        {
            var listUnifiedButtonModel = CardButtonsModul.Create(item);
            Items.Add(listUnifiedButtonModel);
        }
    }

    public static CardHeroIntro Create(DataHeroIntro data)
    {
        var instance = new CardHeroIntro();
        instance.Build(data);
        return instance;
    }

    //protected override async Task OnInitializedAsync()
    //{
    //    await UpdateStyleAsync(StylesHeroIntro.CLASSES);
    //    await base.OnInitializedAsync();
    //}
}















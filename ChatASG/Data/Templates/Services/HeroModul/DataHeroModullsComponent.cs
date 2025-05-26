using Data.HeaderModels;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ChatASG.Data.Templates.Base;

namespace Data.Hero;
public class DataIcon
{
    public string? Icon { get; set; }           // مثال: "fab fa-github"
    public string? Link { get; set; }           // مثال: "https://github.com/..."
    public string? IconColor { get; set; }      // مثال: "text-blue-500"
}
public class StylesSocialIcon : StyleBaseComponentCard
{
    [Parameter] public string? ClassIconContainer { get; set; }

    public static string KeyIconContainer = "classIconContainer";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyIconContainer, "text-2xl hover:opacity-80 transition-all" }
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (ClassIconContainer == null)
            ClassIconContainer = " ";
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);
        ClassIconContainer += " " + classes[KeyIconContainer];
        return base.UpdateStyleAsync(classes);
    }
}

public class CardIconModule : ComponentBaseCard<DataIcon>
{
    public override TypeComponentCard Type => throw new NotImplementedException();

    public static ICollection<string> NAMECLASSES => StylesSocialIcon.CLASSES.Keys.ToList();

    public override void Build(DataIcon data) => DataBuild = data;

    public static CardIconModule Create(DataIcon data)
    {
        var instance = new CardIconModule();
        instance.Build(data);
        return instance;
    }
}

public class DataSocialIcon
{
    public string? Title { get; set; }
    public string? Subtitle { get; set; }
    public string? Description { get; set; }
    public List<DataIcon> Items { get; set; } = new List<DataIcon>();
    public string? CallToActionText { get; set; }
    public string? CallToActionLink { get; set; }

}


    public class StylesCardSocialIcon : StyleBaseComponentCard
{
    [Parameter] public string? ClassSection { get; set; }
    [Parameter] public string? ClassTitle { get; set; }
    [Parameter] public string? ClassSubtitle { get; set; }
    [Parameter] public string? ClassDescription { get; set; }
    // [Parameter] public string? ClassSocialIcon { get; set; }
    [Parameter] public string? ClassCtaButton { get; set; }
    [Parameter] public string? ClassIconBlock { get; set; }

    public static string KeyClassSection = "classSection";
    public static string KeyClassTitle = "classTitle";
    public static string KeyClassSubtitle = "classSubtitle";
    public static string KeyClassDescription = "classDescription";
    public static string KeyClassSocialIcon = "classSocialIcon";
    public static string KeyClassCtaButton = "classCtaButton";
    public static string KeyClassIconBlock = "classIconBlock";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyClassContainer, "lg:w-1/2 mb-10 lg:mb-0" },
        { KeyClassSection, "relative py-20 px-6" },
        { KeyClassTitle, "text-5xl md:text-6xl font-bold mb-6" },
        { KeyClassSubtitle, "text-2xl md:text-3xl font-semibold mb-6 text-slate-300" },
        { KeyClassDescription, "text-lg text-slate-300 mb-8 leading-relaxed" },
        // { KeyClassSocialIcon, "social-icon text-2xl" },
        { KeyClassCtaButton, "bg-gradient-to-r from-blue-600 to-indigo-600 text-white px-6 py-3 rounded-full font-medium hover:shadow-lg transition-all hover:translate-y-[-2px] inline-flex items-center" },
        { KeyClassIconBlock, "text-center p-6" }
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (ClassSection == null)
            ClassSection = " ";
        if (ClassTitle == null)
            ClassTitle = " ";
        if (ClassSubtitle == null)
            ClassSubtitle = " ";
        if (ClassDescription == null)
            ClassDescription = " ";
        if (ClassCtaButton == null)
            ClassCtaButton = " ";
        if (ClassIconBlock == null)
            ClassIconBlock = " ";
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassSection +=" "+ classes[KeyClassSection];
        ClassTitle ??= classes[KeyClassTitle];
        ClassSubtitle += " " + classes[KeyClassSubtitle];
        ClassDescription += " " + classes[KeyClassDescription];
        // ClassSocialIcon ??= classes[KeyClassSocialIcon];
        ClassCtaButton += " " + classes[KeyClassCtaButton];
        ClassIconBlock += " " + classes[KeyClassIconBlock];

        return base.UpdateStyleAsync(classes);
    }
}
public class CardSocialIconModul : ComponentBaseCard<DataSocialIcon>
{
    public List<CardIconModule> Items { get; set; } = new();

    public override TypeComponentCard Type => throw new NotImplementedException();

    public static ICollection<string> NAMECLASSES => StylesHero.CLASSES.Keys.ToList();

    public override void Build(DataSocialIcon db)
    {
        DataBuild = db;
        Items = db.Items.Select(CardIconModule.Create).ToList();
    }

    public static CardSocialIconModul Create(DataSocialIcon data)
    {
        var instance = new CardSocialIconModul();
        instance.Build(data);
        return instance;
    }
}

public class DataHero
{
    public string? Title { get; set; }
    public string? Subtitle { get; set; }
    public string? Description { get; set; }
    public string? Email { get; set; }
    public string? GitHub { get; set; }
    public string? LinkedIn { get; set; }
    public string? Discord { get; set; }
    public string? Image { get; set; }

    public string? IconTitle { get; set; }
    public string? IconSubtitle { get; set; }
    public DataSocialIcon ISocial { get; set; } 

}
public class StylesHero : StyleBaseComponentCard
{
    [Parameter] public string? ClassSection { get; set; }
    [Parameter] public string? ClassTitle { get; set; }
    [Parameter] public string? ClassSubtitle { get; set; }
    [Parameter] public string? ClassDescription { get; set; }
    [Parameter] public string? ClassSocialIcon { get; set; }
    [Parameter] public string? ClassCtaButton { get; set; }
    [Parameter] public string? ClassIconBlock { get; set; }

    public static string KeyClassSection = "classSection";
    public static string KeyClassTitle = "classTitle";
    public static string KeyClassSubtitle = "classSubtitle";
    public static string KeyClassDescription = "classDescription";
    public static string KeyClassSocialIcon = "classSocialIcon";
    public static string KeyClassCtaButton = "classCtaButton";
    public static string KeyClassIconBlock = "classIconBlock";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyClassContainer, StyleBaseComponentCard.KeyClassContainer },
        { KeyClassSection, "relative py-20 px-6" },
        { KeyClassTitle, "text-5xl md:text-6xl font-bold mb-6" },
        { KeyClassSubtitle, "text-2xl md:text-3xl font-semibold mb-6 text-slate-300" },
        { KeyClassDescription, "text-lg text-slate-300 mb-8 leading-relaxed" },
        { KeyClassSocialIcon, "social-icon text-2xl" },
        { KeyClassCtaButton, "bg-gradient-to-r from-blue-600 to-indigo-600 text-white px-6 py-3 rounded-full font-medium hover:shadow-lg transition-all hover:translate-y-[-2px] inline-flex items-center" },
        { KeyClassIconBlock, "text-center p-6" }
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (ClassSection == null)
            ClassSection = " ";
        if (ClassTitle == null)
            ClassTitle = " ";
        if (ClassSubtitle == null)
            ClassSubtitle = " ";
        if (ClassDescription == null)
            ClassDescription = " ";
        if (ClassCtaButton == null)
            ClassSocialIcon = " ";
        if (ClassSocialIcon == null)
            ClassCtaButton = " ";
        if (ClassIconBlock == null)
            ClassIconBlock = " ";
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassSection += " " + classes[KeyClassSection];
        ClassTitle ??= classes[KeyClassTitle];
        ClassSubtitle += " " + classes[KeyClassSubtitle];
        ClassDescription += " " + classes[KeyClassDescription];
        ClassSocialIcon += " " + classes[KeyClassSocialIcon];
        ClassCtaButton += " " + classes[KeyClassCtaButton];
        ClassIconBlock += " " + classes[KeyClassIconBlock];

       
        ClassSocialIcon ??= classes[KeyClassSocialIcon];
      
        return base.UpdateStyleAsync(classes);
    }
}

public class CardHeroModule : ComponentBaseCard<DataHero>
{
    public CardSocialIconModul ISocial { get; set; } 

    public override TypeComponentCard Type => throw new NotImplementedException(); // اختر نوعك الخاص إن لزم
    public static ICollection<string> NAMECLASSES => StylesHero.CLASSES.Keys.ToList();
    public override void Build(DataHero db)
    {
        DataBuild = db;
        ISocial = CardSocialIconModul.Create(db.ISocial);
        
    }

    public static CardHeroModule Create(DataHero data)
    {
        var instance = new CardHeroModule();
        instance.Build(data);
        return instance;
    }
}

public class DataListToolsModul
{
    public string Label { get; set; } = "";
    public string? Icon { get; set; }
    public string? Link { get; set; }
    public string? Description { get; set; }
    public string Title { get; set; } = "";
    public string? IconColor { get; set; }
    public string ButtonLabel { get; set; }
    public string Model { get; set; }
}


public class ListUnifiedToolsModul : ComponentBaseCard<DataListToolsModul>
{
    public override TypeComponentCard Type => throw new NotImplementedException();

    public override void Build(DataListToolsModul db)
    {
        DataBuild = db;

    }


    public static ListUnifiedToolsModul Create(DataListToolsModul data)
    {

        var listUnifiedButtonModel = new ListUnifiedToolsModul();

        listUnifiedButtonModel.Build(data);
        return listUnifiedButtonModel;
    }
}


public class DataCardListToolsModul
{
    public string Title { get; set; } = "";
    public string? Icon { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; }
    public string? Link { get; set; }

    public List<DataListToolsModul> Items { get; set; } = new List<DataListToolsModul>();
}

public class CardListUnifiedToolsModul : ComponentBaseCard<DataCardListToolsModul>

{

    public List<ListUnifiedToolsModul> Items { get; set; } = new List<ListUnifiedToolsModul>();
    public override TypeComponentCard Type => throw new NotImplementedException();
    public override void Build(DataCardListToolsModul db)
    {
        DataBuild = db;
        foreach (var item in db.Items)
        {
            var listUnifiedButtonModel = ListUnifiedToolsModul.Create(item);
            Items.Add(listUnifiedButtonModel);
        }

    }

    public static CardListUnifiedToolsModul Create(DataCardListToolsModul data)
    {
        var cardListUnifiedButtonModel = new CardListUnifiedToolsModul();
        cardListUnifiedButtonModel.Build(data);
        return cardListUnifiedButtonModel;
    }

}


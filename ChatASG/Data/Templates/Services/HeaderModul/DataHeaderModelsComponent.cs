using ChatASG.Data.Templates.Base;
using Microsoft.AspNetCore.Components;

namespace Data.HeaderModels;


public class DataButtons
{
    public string? Buttons { get; set; }
    public string? Icon { get; set; }
    public string Title { get; set; } = "";

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
            { KeyClassButton, "text-sm text-purple-400 hover:text-purple-300 flex items-center" },
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

public class DataToggles
{
    public string? Name { get; set; }
    public string? Idtoggle { get; set; }

    public bool IsAdultModeEnabled { get; set; }
    public bool IsBlurNsfwEnabled { get; set; }
}

public class StylesTogglesIcon : StyleBaseComponentCard
{
    [Parameter] public string? ClassLabel { get; set; }
    [Parameter] public string? ClassCheckbox { get; set; }
     
    public static string KeyClassContainer = "classContainer";
    public static string KeyClassCheckbox = "classCheckbox";
    public static string KeyClassLabel = "classLabel";
    public static string KeyClassItem { get; set; } = "classItem";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyClassContainer,"text-sm text-gray-400 mr-2" },
        { KeyClassLabel, "toggle-label block overflow-hidden h-6 rounded-full bg-gray-300 cursor-pointer" },
        { KeyClassItem, "relative inline-block w-12 mr-4 align-middle select-none" },
        { KeyClassCheckbox, "toggle-checkbox absolute block w-6 h-6 rounded-full bg-white border-4 appearance-none cursor-pointer" }
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (KeyClassContainer == null)
            KeyClassContainer = " ";
        if (ClassLabel == null)
            ClassLabel = " ";
        if (ClassCheckbox == null)
            ClassCheckbox = " ";
        if (KeyClassItem == null)
            KeyClassItem = " ";
            if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassContainer += " " + classes[KeyClassContainer];
        ClassLabel += " " + classes[KeyClassLabel];
        ClassItem += " " + classes[KeyClassItem];
        ClassCheckbox += " " + classes[KeyClassCheckbox];

        return base.UpdateStyleAsync(classes);
    }
}
public class CardTogglesModul : ComponentBaseCard<DataToggles>
{
    public override TypeComponentCard Type => throw new NotImplementedException();
    public static ICollection<string> NAMECLASSES => StylesTogglesIcon.CLASSES.Keys.ToList();
    public override void Build(DataToggles data) => DataBuild = data;
    public static CardTogglesModul Create(DataToggles data)
    {
        var instance = new CardTogglesModul();
        instance.Build(data);
        return instance;
    }
}
public class DataSearchBar
{
    public string? Icon { get; set; }
    public string? SearchPlaceholder { get; set; }
    public string? ButtonLabel { get; set; } 
  //  public DataToggles Toggles { get; set; } = new();
    public List<DataToggles> Items { get; set; } = new List<DataToggles>();
    public DataButtons? IButtons { get; set; } 
}

public class StylesSearchBar : StyleBaseComponentCard
{
    [Parameter] public string? ClassButton { get; set; }
    [Parameter] public string? ClassIcon { get; set; }
    [Parameter] public string? Classinput { get; set; }
    public static string KeyClassContainer = "classContainer ";

    public static string KeyClassButton = "classButton";
    public static string KeyClassItem { get; set; } = "classItem";

    public static string KeyClassIcon = "classIcon";
    public static string KeyClassinput = "classinput";

          
    public static readonly new Dictionary<string, string> CLASSES = new()
        {
            { KeyClassContainer, "max-w-2xl mx-auto"},
            { KeyClassButton, "absolute right-2 top-2 gradient-bg text-white px-6 py-2 rounded-full hover:opacity-90 transition" },
            { KeyClassIcon, "" },
            {KeyClassItem, "relative" },
            { KeyClassinput, "w-full px-6 py-4 rounded-full bg-dark-800 border border-dark-700 focus:outline-none focus:ring-2 focus:ring-purple-500 text-white" }
        };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {

        if (KeyClassContainer == null)
            ClassContainer = " ";
        if (ClassButton == null)
            ClassButton = " ";
        if (ClassIcon == null)
            ClassIcon = " ";
        if (KeyClassItem == null)
            ClassItem = " "; 
        if (ClassIcon == null)
            ClassIcon = " ";
        if (Classinput == null)
            Classinput = " ";
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassContainer += " " + classes[KeyClassContainer];
        ClassButton += " " + classes[KeyClassButton];
        ClassIcon += " " + classes[KeyClassIcon];
        ClassItem += " " + classes[KeyClassItem];

        Classinput += " " + classes[KeyClassinput];

        return base.UpdateStyleAsync(classes);
    }
    //public static readonly new Dictionary<string, string> CLASSES = new()
    //{
    //    { KeyClassContainer, "max-w-2xl mx-auto" },
    //    // يمكنك إضافة مزيد من التنسيقات لاحقاً
    //};
}

public class CardSearchBarModul : ComponentBaseCard<DataSearchBar>
{
    public override TypeComponentCard Type => throw new NotImplementedException();
    public CardButtonsModul? IButtons { get; set; }
    public List<CardTogglesModul> Items { get; set; } = new List<CardTogglesModul>();
    public static ICollection<string> NAMECLASSES => StylesSearchBar.CLASSES.Keys.ToList();

    public override void Build(DataSearchBar db) { 
          DataBuild = db;
        IButtons = CardButtonsModul.Create(db.IButtons);
        foreach (var item in db.Items)
        {
            var listUnifiedButtonModel = CardTogglesModul.Create(item);
            Items.Add(listUnifiedButtonModel);
        }
    }
    public static CardSearchBarModul Create(DataSearchBar data)
    {
        var instance = new CardSearchBarModul();
        instance.Build(data);
        return instance;
    }
}


public class DataCardListHeaderModel
{
    public string Title { get; set; } = "";
    public string? Icon { get; set; }
    public string? Name { get; set; }
     public string? Description { get; set; }
    public string? SearchPlaceholder { get; set; }
     public string? ButtonLabel { get; set; }

    public string? Image { get; set; }
    public bool IsAdultModeEnabled { get; set; }     // تفعيل وضع البالغين
    public bool IsBlurNsfwEnabled { get; set; }
    public string? AdvancedFiltersText { get; set; }
    public DataSearchBar? ISearc { get; set; }

    //public List<DataListButton> Items { get; set; } = new List<DataListButton>();
}


public class StylesSHeaderModel : StyleBaseComponentCard
{
    [Parameter] public string? Classtext { get; set; }
    [Parameter] public string? Classh1 { get; set; }
    [Parameter] public string? Classspan { get; set; }
    [Parameter] public string? Classsp { get; set; }

    public static string KeyClassContainer = "classContainer ";

    public static string KeyClasstext = "classtext";
    public static string KeyClassItem { get; set; } = "classItem";

    public static string KeyClassh1 = "classh1";
    public static string KeyClassspan = "classspan";
    public static string KeyClasssp = "classsp";


    public static readonly new Dictionary<string, string> CLASSES = new()
        {
            { KeyClassContainer, "pt-24 pb-16 md:pt-32 md:pb-24 parallax-bg"},
            { KeyClasstext, "text-center" },
            { KeyClassh1, "text-4xl md:text-6xl font-bold mb-6" },
            {KeyClassItem, "max-w-7xl mx-auto px-4 sm:px-6 lg:px-8" },
            { KeyClassspan, "gradient-text" },
            { KeyClasssp, "text-xl md:text-2xl text-gray-300 max-w-3xl mx-auto mb-10" }

        };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (KeyClassContainer == null)
            ClassContainer = " ";
        if (Classtext == null)
            Classtext = " ";
        if (Classh1 == null)
            Classh1 = " ";
        if (KeyClassItem == null)
            ClassItem = " ";
        if (Classh1 == null)
            Classh1 = " ";
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);
        ClassContainer += " " + classes[KeyClassContainer];
        Classtext += " " + classes[KeyClasstext];
        Classh1 += " " + classes[KeyClassh1];
        ClassItem += " " + classes[KeyClassItem];
        Classspan += " " + classes[KeyClassspan];
        Classsp += " " + classes[KeyClasssp];


        return base.UpdateStyleAsync(classes);
    }
    //public static readonly new Dictionary<string, string> CLASSES = new()
    //{
    //    { KeyClassContainer, "max-w-2xl mx-auto" },
    //    // يمكنك إضافة مزيد من التنسيقات لاحقاً
    //};
}
public class CardListHeaderModel : ComponentBaseCard<DataCardListHeaderModel>

{
    public CardSearchBarModul? ISearc { get; set; }

    public static ICollection<string> NAMECLASSES => StylesSHeaderModel.CLASSES.Keys.ToList();

    // public List<ListUnifiedButtonModel> Items { get; set; } = new List<ListUnifiedButtonModel>();
    public override TypeComponentCard Type => throw new NotImplementedException();
    public override void Build(DataCardListHeaderModel db)
    {
        DataBuild = db;
        ISearc = CardSearchBarModul.Create(db.ISearc);
        //foreach (var item in db.Items)
        //{
        //    var listUnifiedButtonModel = ListUnifiedButtonModel.Create(item);
        //    Items.Add(listUnifiedButtonModel);
        //}

    }

    public static CardListHeaderModel Create(DataCardListHeaderModel data)
    {
        var cardListUnifiedButtonModel = new CardListHeaderModel();
        cardListUnifiedButtonModel.Build(data);
        return cardListUnifiedButtonModel;
    }

}


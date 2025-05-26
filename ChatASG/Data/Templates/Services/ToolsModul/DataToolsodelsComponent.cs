using ChatASG.Data.Templates.Base;
using Microsoft.AspNetCore.Components;

namespace Data.Tools;

public class DataToolCard
{
    public string? Icon { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Badge { get; set; }
    public string? ButtonText { get; set; }
}
public class StylesToolCard : StyleBaseComponentCard
{
    [Parameter] public string? ClassCard { get; set; }
    [Parameter] public string? ClassIconBox { get; set; }
    [Parameter] public string? ClassTitle { get; set; }
    [Parameter] public string? ClassDescription { get; set; }
    [Parameter] public string? ClassBadge { get; set; }
    [Parameter] public string? ClassButton { get; set; }

    public static string KeyCard = "classCard";
    public static string KeyIconBox = "classIconBox";
    public static string KeyTitle = "classTitle";
    public static string KeyDescription = "classDescription";
    public static string KeyBadge = "classBadge";
    public static string KeyButton = "classButton";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyClassContainer, StyleBaseComponentCard.KeyClassContainer },
        { KeyCard, "bg-dark-800 rounded-xl overflow-hidden shadow-lg card-hover animate-card card-delay-1" },
        { KeyIconBox, "w-12 h-12 rounded-lg gradient-bg flex items-center justify-center text-white mr-4" },
        { KeyTitle, "text-xl font-semibold text-white" },
        { KeyDescription, "text-gray-400 mb-6" },
        { KeyBadge, "text-sm text-purple-400" },
        { KeyButton, "px-4 py-2 rounded-lg gradient-bg text-white hover:opacity-90 transition text-sm" }
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (ClassCard == null)
            ClassCard = " ";
        if (ClassIconBox == null) ClassIconBox = " ";
        if (ClassTitle == null) ClassTitle = " ";
        if (ClassBadge == null) ClassBadge = " ";
        if(ClassDescription == null)
            ClassDescription = " ";
        if (ClassButton == null) ClassButton = " ";
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassCard +=" "+ classes[KeyCard];
        ClassIconBox += " " + classes[KeyIconBox];
        ClassTitle += " " + classes[KeyTitle];
        ClassDescription += " " + classes[KeyDescription];
        ClassBadge += " " + classes[KeyBadge];
        ClassButton += " " + classes[KeyButton];

        return base.UpdateStyleAsync(classes);
    }
}
public class CardToolModule : ComponentBaseCard<DataToolCard>
{
    public override TypeComponentCard Type => throw new NotImplementedException();
    public static ICollection<string> NAMECLASSES => StylesToolCard.CLASSES.Keys.ToList();
    public override void Build(DataToolCard data) => DataBuild = data;
    public static CardToolModule Create(DataToolCard data)
    {
        var instance = new CardToolModule();
        instance.Build(data);
        return instance;
    }
}

//public class DataListToolsModul
//{
//    public string Label { get; set; } = "";
//    public string? Icon { get; set; }
//    public string? Link { get; set; }
//    public string? Description { get; set; }
//    public string Title { get; set; } = "";
//    public string? Color { get; set; }
//    public string ButtonLabel { get; set; }
//    public string Model { get; set; }
//}


//public class ListUnifiedToolsModul : ComponentBaseCard<DataListToolsModul>
//{
//    public override TypeComponentCard Type => throw new NotImplementedException();

//    public override void Build(DataListToolsModul db)
//    {
//        DataBuild = db;

//    }


//    public static ListUnifiedToolsModul Create(DataListToolsModul data)
//    {

//        var listUnifiedButtonModel = new ListUnifiedToolsModul();

//        listUnifiedButtonModel.Build(data);
//        return listUnifiedButtonModel;
//    }
//}


public class DataCardListToolsModul
{
    public string Button { get; set; } = "";
    public string? Icon { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public List<DataToolCard> Items { get; set; } = new List<DataToolCard>();

   // public List<DataListToolsModul> Items { get; set; } = new List<DataListToolsModul>();
}

public class StylesToolsModul : StyleBaseComponentCard
{
    [Parameter] public string? ClassButton { get; set; }
    [Parameter] public string? ClassIcon { get; set; }
    [Parameter] public string? ClassText { get; set; }
    public static string KeyClassContainer = "classContainer ";


       
    public static string KeyClassButton = "classButton";
    public static string KeyClassIcon = "classIcon";
    public static string KeyClassText = "classText";

    public static readonly new Dictionary<string, string> CLASSES = new()
        {
            { KeyClassContainer, "grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-3 xl:grid-cols-4 gap-6" },
            { KeyClassButton, "px-6 py-3 rounded-full gradient-bg text-white hover:opacity-90 transition font-medium" },
            { KeyClassIcon, "mr-2" },
            { KeyClassText, "text-center mt-12" }
        };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (KeyClassContainer == null)
            ClassContainer = " ";
        if (ClassButton == null)
            ClassButton = " ";
        if (ClassIcon == null)
            ClassIcon = " ";
        if (ClassText == null)
            ClassText = " ";
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);


        ClassContainer += " " + classes[KeyClassContainer];
        ClassButton += " " + classes[KeyClassButton];
        ClassIcon += " " + classes[KeyClassIcon];
         ClassText += " " + classes[KeyClassText];

        return base.UpdateStyleAsync(classes);
    }
}

public class CardListUnifiedToolsModul : ComponentBaseCard<DataCardListToolsModul>

{
    public List<CardToolModule> Items { get; set; } = new List<CardToolModule>();

   // public List<ListUnifiedToolsModul> Items { get; set; } = new List<ListUnifiedToolsModul>();
    public override TypeComponentCard Type => throw new NotImplementedException();
    public override void Build(DataCardListToolsModul db)
    {
        DataBuild = db;
        foreach (var item in db.Items)
        {
            var listUnifiedButtonModel = CardToolModule.Create(item);
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


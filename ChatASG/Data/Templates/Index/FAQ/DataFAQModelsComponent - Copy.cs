using ChatASG.Data.Templates.Base;
using Microsoft.AspNetCore.Components;

namespace Data.FAQn;
public class DataFaq
{
    public string Question { get; set; } = string.Empty;
    public string Answer { get; set; } = string.Empty;
    public List<string>? BulletPoints { get; set; } // Optional
    public bool HasIconList { get; set; } = false;   // Use icons if true
}
public class StylesFaqCard : StyleBaseComponentCard
{
    [Parameter] public string? ClassHeader { get; set; }
    [Parameter] public string? ClassContent { get; set; }
    [Parameter] public string? ClassIcon { get; set; }
    [Parameter] public string? ClassBulletList { get; set; }
    [Parameter] public string? ClassBulletItem { get; set; }

    public static string KeyContainer = "container";
    public static string KeyHeader = "header";
    public static string KeyContent = "content";
    public static string KeyIcon = "icon";
    public static string KeyBulletList = "list";
    public static string KeyBulletItem = "item";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyContainer, "accordion glass-card rounded-xl p-6" },
        { KeyHeader, "accordion-header w-full flex justify-between items-center text-left" },
        { KeyContent, "accordion-content " },
        { KeyIcon, "fas fa-chevron-down text-accent transition-transform duration-300" },
        { KeyBulletList, "grid sm:grid-cols-2 gap-2 text-gray-400" },
        { KeyBulletItem, "flex items-center" }
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (ClassContainer == null)
            ClassContainer = " ";
        if(ClassHeader == null)
            ClassHeader = " ";
        if(ClassContent == null)
            ClassContent = " ";
        if(ClassBulletList == null)
            ClassBulletList = " ";
        if(ClassBulletItem == null)
            ClassBulletItem = " ";
        if(ClassBulletItem == null)
            ClassBulletItem = " ";
        if(ClassBulletList == null)
            ClassBulletList = " ";
        if(ClassBulletItem == null)
            ClassBulletItem = " ";

        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);
        ClassContainer += " " + classes[KeyContainer];
        ClassHeader += " " + classes[KeyHeader];
        ClassContent += " " + classes[KeyContent];
        ClassIcon += " " + classes[KeyIcon];
        ClassBulletList += " " + classes[KeyBulletList];
        ClassBulletItem += " " + classes[KeyBulletItem];
        return base.UpdateStyleAsync(classes);
    }
}


public class CardFAQ : ComponentBaseCard<DataFaq>
{
    public static ICollection<string> NAMECLASSES => StylesFaqCard.CLASSES.Keys.ToList();

    public override TypeComponentCard Type => throw new NotImplementedException();

    public override void Build(DataFaq db)
    {
        DataBuild = db;
    }

    public static CardFAQ Create(DataFaq data)
    {
        var instance = new CardFAQ();
        instance.Build(data);
        return instance;
    }
}


public class DataStillFAQ : ModulsBase
{
  
}
public class StylesCardStillFAQ : StyleBaseComponentCard
{
    [Parameter] public string? ClassTitle { get; set; }
    [Parameter] public string? ClassDescription { get; set; }
    [Parameter] public string? ClassButton { get; set; }

    public static string KeyClassContainer = "classContainer";
    public static string KeyClassTitle = "classTitle";
    public static string KeyClassDescription = "classDescription";
    public static string KeyClassButton = "classButton";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyClassContainer, "text-center mt-16" },
        { KeyClassTitle, "text-xl font-bold mb-4" },
        { KeyClassDescription, "text-gray-400 mb-6" },
        { KeyClassButton, "px-6 py-3 bg-gradient-to-r from-accent to-accent2 text-dark font-bold rounded-lg hover:opacity-90 transition" },
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (KeyClassContainer == null)
            ClassContainer = " ";
        if (ClassTitle == null)
            ClassTitle = " ";
        if (ClassDescription == null)
            ClassDescription = " ";
        if (ClassButton == null)
            ClassButton = " ";


        if (classes == null || IsIgnoredStyle) return Task.FromResult(false);

        ClassContainer = classes[KeyClassContainer];
        ClassTitle = classes[KeyClassTitle];
        ClassDescription = classes[KeyClassDescription];
        ClassButton = classes[KeyClassButton];

        return base.UpdateStyleAsync(classes);
    }
}

public class CardStillFAQ : ComponentBaseCard<DataStillFAQ>
{
    public static ICollection<string> NAMECLASSES => StylesCardStillFAQ.CLASSES.Keys.ToList();

    public override TypeComponentCard Type => throw new NotImplementedException();
    public override void Build(DataStillFAQ db)
    {
        DataBuild = db;
    }
    public static CardStillFAQ Create(DataStillFAQ data)
    {
        var instance = new CardStillFAQ();
        instance.Build(data);
        return instance;
    }


}
public class DataAddFAQ : ModulsBase
{
  public DataStillFAQ? IstillFAQ { get; set; }
    public List<DataFaq> Items { get; set; } = new();
}
public class StylesCardAddFAQ : StyleBaseComponentCard
{
    [Parameter] public string? ClassName { get; set; }
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
            { KeyClassContainer, "py-20 px-4 sm:px-10 lg:px-20 xl:px-32" },
            { KeyClassItem, "max-w-4xl mx-auto" },
            { KeyClassName, " text-3xl sm:text-4xl font-bold mb-6" },
            { KeyClassDescription, "text-lg text-gray-400" },
            { KeyClassItems, "space-y-4" }
    };
    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (KeyClassContainer == null)
            ClassContainer = " ";

        if (KeyClassItem == null)
            ClassItem = " ";
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
        ClassName += " " + classes[KeyClassName];

        ClassDescription += " " + classes[KeyClassDescription];
        ClassItems += " " + classes[KeyClassItems];
        return base.UpdateStyleAsync(classes);
    }
}

public class CardAddFAQ : ComponentBaseCard<DataAddFAQ>
{
    public CardStillFAQ? IstillFAQ { get; set; }

    public List<CardFAQ> Items { get; set; } = new();

    public override TypeComponentCard Type => throw new NotImplementedException();

    public static ICollection<string> NAMECLASSES => StylesCardAddFAQ.CLASSES.Keys.ToList();

    public override void Build(DataAddFAQ db)
    {
        DataBuild = db;
        IstillFAQ = CardStillFAQ.Create(db.IstillFAQ);

        foreach (var item in db.Items)
        {
            var listUnifiedButtonModel = CardFAQ.Create(item);
            Items.Add(listUnifiedButtonModel);
        }
    }

    public static CardAddFAQ Create(DataAddFAQ data)
    {
        var instance = new CardAddFAQ();
        instance.Build(data);
        return instance;
    }

   
}





















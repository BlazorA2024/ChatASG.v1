
using ChatASG.Data.Templates.Base;
using Data.FooterSectio;
using Microsoft.AspNetCore.Components;

namespace Data.FooterSection;



public class StylesCardFooterBrandInfo : StyleBaseComponentCard
{
    [Parameter] public string? ClassName { get; set; }
    [Parameter] public string? ClassDescription { get; set; }
    [Parameter] public string? ClassIcon { get; set; }
    public static string KeyClassContainer = "ClassContainer";

    public static string KeyClassName = "className";
    public static string KeyDescription = "description";
    public static string KeyClassIcon = "classIcon";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyClassContainer, "flex items-center mb-4" },
      { KeyClassName, "text-xl font-bold text-white" },
        { KeyDescription, "text-gray-400" },
        { KeyClassIcon, " text-2xl text-blue-500 mr-2" },

    };
    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (KeyClassContainer == null)
            ClassContainer = " ";
        if (ClassName == null)
            ClassName = " ";
        if (ClassDescription == null)
            ClassDescription = " ";
        if (ClassIcon == null)
            ClassIcon = " ";
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassContainer += " " + classes[KeyClassContainer];

        ClassName += " " + classes[KeyClassName];
        ClassDescription += " " + classes[KeyDescription];
        ClassIcon += " " + classes[KeyClassIcon];


        return base.UpdateStyleAsync(classes);
    }
}

public class CardFooterBrandInfo : ComponentBaseCard<DataFooterBrandInfo>
{
    public override TypeComponentCard Type => throw new NotImplementedException();
    public static ICollection<string> NAMECLASSES => StylesCardFooterBrandInfo.CLASSES.Keys.ToList();

    public static CardFooterBrandInfo Create(DataFooterBrandInfo data)
    {
        var instance = new CardFooterBrandInfo();
        instance.Build(data);
        return instance;
    }

    public override void Build(DataFooterBrandInfo db)
    {
        DataBuild = db;
    }
}



public class StylesCardFooterNewsletter : StyleBaseComponentCard
{
    [Parameter] public string? ClassName { get; set; }

    [Parameter] public string? ClassTitle { get; set; }

    [Parameter] public string? ClassLabel { get; set; }
    [Parameter] public string? ClassIcon { get; set; }
    [Parameter] public string? ClassSubmitButton { get; set; }
    public static string KeyLabel = "label";
    public static string KeyClassContainer = "ClassContainer";
    public static string KeyTitle = "title";

    public static string KeyClassName = "className";
    public static string KeyDescription = "description";
    public static string KeyClassIcon = "classIcon";
    public static string KeyClassSubmitButton = "classSubmitButton";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyClassContainer, "flex items-center mb-4" },
      { KeyClassName, "text-lg font-bold text-white mb-4" },
        { KeyTitle, "text-gray-400 mb-4" },
        { KeyLabel, "bg-gray-700 text-white px-4 py-2 rounded-r-lg focus:outline-none w-full" },
        { KeyClassIcon, " text-2xl text-blue-500 mr-2" },
                { KeyClassSubmitButton, "bg-blue-600 hover:bg-blue-700 text-white px-4 py-2 rounded-l-lg transition duration-300" },

    };
    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (KeyClassContainer == null)
            ClassContainer = " ";
        if (ClassName == null)
            ClassName = " ";
        if (ClassTitle == null)
            ClassTitle = " ";
        if (ClassLabel == null)
            ClassLabel = " ";
        if (ClassIcon == null)
            ClassIcon = " ";
        if (ClassSubmitButton == null)
            ClassSubmitButton = " ";
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassContainer += " " + classes[KeyClassContainer];

        ClassName += " " + classes[KeyClassName];
        ClassTitle += " " + classes[KeyTitle];
        ClassLabel += " " + classes[KeyLabel];

        ClassIcon += " " + classes[KeyClassIcon];
        ClassSubmitButton += " " + classes[KeyClassSubmitButton];


        return base.UpdateStyleAsync(classes);
    }
}

public class CardFooterNewsletter : ComponentBaseCard<DataFooterNewsletter>
{
    public override TypeComponentCard Type => throw new NotImplementedException();
    public static ICollection<string> NAMECLASSES => StylesCardFooterNewsletter.CLASSES.Keys.ToList();

    public static CardFooterNewsletter Create(DataFooterNewsletter data)
    {
        var instance = new CardFooterNewsletter();
        instance.Build(data);
        return instance;
    }

    public override void Build(DataFooterNewsletter db)
    {
        DataBuild = db;
    }
}

public class StylesCardContactInfo : StyleBaseComponentCard
{
    [Parameter] public string? ClassIconBox { get; set; }
    [Parameter] public string? ClassTextInfo { get; set; }
    [Parameter] public string? ClassTitle { get; set; }

    public static string KeyIconBox = "iconBox";
    public static string KeyTextInfo = "textInfo";
    public static string KeyTitle = "title";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyIconBox, "p-3 rounded-lg mr-4" },
        { KeyTextInfo, "text-gray-400" },
        { KeyTitle, "font-bold mb-1" },

    };
    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (ClassIconBox == null)
            ClassIconBox = " ";
        if (ClassTextInfo == null)
            ClassTextInfo = " ";
        if (ClassTitle == null)
            ClassTitle = " ";
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);
        ClassIconBox += " " + classes[KeyIconBox];
        ClassTextInfo += " " + classes[KeyTextInfo];
        ClassTitle += " " + classes[KeyTitle];


        return base.UpdateStyleAsync(classes);
    }
}
public class StylesCardFooterLinkSection : StyleBaseComponentCard
{
    [Parameter] public string? ClassTitle { get; set; }
    [Parameter] public string? ClassUl { get; set; }
    [Parameter] public string? ClassLink { get; set; }



    public static string KeyClassTitle = "classTitle";
    public static string KeyClassUl = "classUl";
    public static string KeyClassLink = "classLink";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyClassTitle, "text-lg font-bold text-white mb-4" },
        { KeyClassUl, " space-y-2" },

        { KeyClassLink, "text-gray-400 hover:text-white transition duration-300" },
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (ClassUl == null)
            ClassUl = " ";

        if (ClassLink == null)
            ClassLink = " ";


        if (ClassTitle == null)
            ClassTitle = " ";

        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassUl += " " + classes[KeyClassUl];
        ClassLink += " " + classes[KeyClassLink];
        ClassTitle += " " + classes[KeyClassTitle];

        return base.UpdateStyleAsync(classes);
    }

}
public class CardFooterLinkSection : ComponentBaseCard<DataFooterLinkSection>
{
    public override TypeComponentCard Type => throw new NotImplementedException();
    public static ICollection<string> NAMECLASSES => StylesCardFooterLinkSection.CLASSES.Keys.ToList();

    public static CardFooterLinkSection Create(DataFooterLinkSection data)
    {
        var instance = new CardFooterLinkSection();
        instance.Build(data);
        return instance;
    }

    public override void Build(DataFooterLinkSection db)
    {
        DataBuild = db;
    }
}

public class StylesCardFooterBottom : StyleBaseComponentCard
{
    [Parameter] public string? ClassLink { get; set; }

    [Parameter] public string? ClassTitle { get; set; }

    public static string KeyClassItem { get; set; } = "classItem";
    public static string KeyClassContainer = "classContainer";
    public static string KeyClassLink = "classLink";

    public static string KeyClassTitle = "classTitle";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyClassContainer, "border-t border-gray-800 mt-12 pt-8 flex flex-col md:flex-row justify-between items-center" },
        { KeyClassTitle, "text-gray-400 text-sm mb-4 md:mb-0" },
        { KeyClassItem, "flex space-x-6 space-x-reverse" },

        { KeyClassLink, "text-gray-400 hover:text-white text-sm transition duration-300" },
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (KeyClassItem == null)
            ClassItem = " ";
        if (ClassContainer == null)
            ClassContainer = " ";
        if (ClassLink == null)
            ClassLink = " ";


        if (ClassTitle == null)
            ClassTitle = " ";

        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassItem += " " + classes[KeyClassItem];
        ClassContainer += " " + classes[KeyClassContainer];
        ClassLink += " " + classes[KeyClassLink];
        ClassTitle += " " + classes[KeyClassTitle];

        return base.UpdateStyleAsync(classes);
    }

}
public class CardFooterBottom : ComponentBaseCard<DataFooterBottom>
{
    public override TypeComponentCard Type => throw new NotImplementedException();
    public static ICollection<string> NAMECLASSES => StylesCardFooterBottom.CLASSES.Keys.ToList();

    public static CardFooterBottom Create(DataFooterBottom data)
    {
        var instance = new CardFooterBottom();
        instance.Build(data);
        return instance;
    }

    public override void Build(DataFooterBottom db)
    {
        DataBuild = db;
    }
}

public class StylesFooter : StyleBaseComponentCard
{
    [Parameter] public string? ClassFooter { get; set; }
    [Parameter] public string? ClassLink { get; set; }
  
    [Parameter] public string? ClassBottom { get; set; }

    public static string KeyClassFooter = "classFooter";
    public static string KeyClassContainer = "classContainer";
    public static string KeyClassLink = "classLink";
    public static string KeyClassSubmitButton = "classSubmitButton";

    public static string KeyClassBottom = "classBottom";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyClassFooter, "bg-gray-900/80 border-t border-gray-800 py-12 px-4 sm:px-6 lg:px-8" },
        { KeyClassContainer, "max-w-7xl mx-auto" },
        { KeyClassLink, "text-gray-400 hover:text-white transition duration-300" },
        { KeyClassSubmitButton, "bg-blue-600 hover:bg-blue-700 text-white px-4 py-2 rounded-l-lg transition duration-300" },
        { KeyClassBottom, "border-t border-gray-800 mt-12 pt-8 flex flex-col md:flex-row justify-between items-center" }
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (ClassFooter == null)
            ClassFooter = " ";
        if (ClassContainer == null)
            ClassContainer = " ";
        if (ClassLink == null)
            ClassLink = " ";
      
      
        if (ClassBottom == null)
            ClassBottom = " ";

        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassFooter += " " + classes[KeyClassFooter];
        ClassContainer += " " + classes[KeyClassContainer];
        ClassLink += " " + classes[KeyClassLink];
        ClassBottom += " " + classes[KeyClassBottom];

        return base.UpdateStyleAsync(classes);
    }

}


public class CardAddFooter : ComponentBaseCard<DataAddFooter>
{
    public static ICollection<string> NAMECLASSES => StylesFooter.CLASSES.Keys.ToList();
    public CardFooterBrandInfo  Iinfo { get; set; }
    public List<CardFooterLinkSection> LinkSections { get; set; } = new();

    public CardFooterNewsletter INewsletter { get; set; }
    public CardFooterBottom PolicyLinks { get; set; }

    public override TypeComponentCard Type => throw new NotImplementedException();

    public override void Build(DataAddFooter db)
    {
        DataBuild = db;
        Iinfo = CardFooterBrandInfo.Create(db.Iinfo);
        PolicyLinks = CardFooterBottom.Create(db.PolicyLinks);

        INewsletter = CardFooterNewsletter.Create(db.INewsletter);

        foreach (var item in db.LinkSections)
        {
            var LinkSection = CardFooterLinkSection.Create(item);
            LinkSections.Add(LinkSection);


        }
       
    }
    public static CardAddFooter Create(DataAddFooter data)
        {
            var instance = new CardAddFooter();
            instance.Build(data);
            return instance;
        }
    }












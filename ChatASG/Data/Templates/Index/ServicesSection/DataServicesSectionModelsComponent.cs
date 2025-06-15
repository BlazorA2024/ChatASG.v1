using ChatASG.Data.Templates.Base;
using Data.HeaderModels;
using Data.ServicesSectionModels;
using Microsoft.AspNetCore.Components;

namespace Data.ServicesSection;
//<!-- Explore of Studios -->
//<!-- 3 استكشاف الاستوديوهات    -->
public class StylesStudiosCard : StyleBaseComponentCard
{
    [Parameter] public string? ClassTitle { get; set; }
    [Parameter] public string? ClassDescription { get; set; }
    [Parameter] public string? ClassIframe { get; set; }

    public static string KeyClassContainer = "classContainer";
    public static string KeyClassTitle = "classTitle";
    public static string KeyClassDescription = "classDescription";
    public static string KeyClassIframe = "classIframe";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyClassContainer, "rounded-xl overflow-hidden shadow-md hover:shadow-xl transition-shadow duration-300" },
        { KeyClassTitle, "text-xl font-semibold mb-2 text-blue-600" },
        { KeyClassDescription, "text-sm text-gray-600 mb-3" },
        { KeyClassIframe, "w-full border-none" }
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (KeyClassContainer == null)
            ClassContainer = " ";
        if (ClassTitle == null)
            ClassTitle = " ";
        if (ClassDescription == null)
            ClassDescription = " ";
        if (ClassIframe == null)
            ClassIframe = " ";
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);
        ClassContainer += " " + classes[KeyClassContainer];
        ClassTitle += " " + classes[KeyClassTitle];
        ClassDescription += " " + classes[KeyClassDescription];
        ClassIframe += " " + classes[KeyClassIframe];



        return base.UpdateStyleAsync(classes);
    }
}

public class CardStudios : ComponentBaseCard<DataStudios>
{
    public override TypeComponentCard Type => throw new NotImplementedException();

    public static CardStudios Create(DataStudios data)
    {
        var instance = new CardStudios();
        instance.Build(data);
        return instance;
    }

    public override void Build(DataStudios db)
    {
        DataBuild = db;
    }
}



public class StylesCardAddStudios : StyleBaseComponentCard
{
    [Parameter] public string? ClassName { get; set; }


    public static string KeyClassItem { get; set; } = "classItem";
    public static string KeyClassName = "className";


    public static readonly new Dictionary<string, string> CLASSES = new()
    {
             { KeyClassItem, "grid grid-cols-1 md:grid-cols-2 gap-6 p-2" },
            { KeyClassName, "text-3xl font-bold text-center mb-8" },
           
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        

        if (KeyClassItem == null)
            ClassItem = " ";
        if (ClassName == null)
            ClassName = " ";
       
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);
        ClassItem += " " + classes[KeyClassItem];
        ClassName += " " + classes[KeyClassName];

      
        return base.UpdateStyleAsync(classes);
    }
}

public class CardAddStudios : ComponentBaseCard<DataAddStudios>
{
    public List<CardStudios> Items { get; set; } = new();

    public override TypeComponentCard Type => throw new NotImplementedException();

    public static ICollection<string> NAMECLASSES => StylesCardAddStudios.CLASSES.Keys.ToList();

    public override void Build(DataAddStudios db)
    {
        DataBuild = db;
       // IStats = CardHeroImageStats.Create(db.IStats);

        foreach (var item in db.Items)
        {
            var listUnifiedButtonModel = CardStudios.Create(item);
            Items.Add(listUnifiedButtonModel);
        }
    }

    public static CardAddStudios Create(DataAddStudios data)
    {
        var instance = new CardAddStudios();
        instance.Build(data);
        return instance;
    }

}





















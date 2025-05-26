using ChatASG.Data.Templates.Base;
using Data.Ourservices;
using Data.Section;
using Microsoft.AspNetCore.Components;
using static MudBlazor.CategoryTypes;

namespace Data.ContactSection;




public class StylesCardform : StyleBaseComponentCard
{
    [Parameter] public string? ClassForm { get; set; }
    [Parameter] public string? ClassInput { get; set; }
    [Parameter] public string? ClassLabel { get; set; }
    [Parameter] public string? ClassButton { get; set; }

    public static string KeyForm = "form";
    public static string KeyInput = "input";
    public static string KeyLabel = "label";
    public static string KeyButton = "button";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
    { KeyForm, "space-y-6" },
        { KeyInput, "w-full bg-gray-700 border border-gray-600 rounded-lg px-4 py-3 focus:outline-none focus:ring-2 focus:ring-blue-500 text-white" },
        { KeyLabel, "block text-sm font-medium text-gray-300 mb-2" },
        { KeyButton, "w-full bg-blue-600 hover:bg-blue-700 text-white px-6 py-3 rounded-lg text-lg font-medium transition duration-300" },

    };
    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (ClassForm == null)
            ClassForm = " ";
        if (ClassInput == null)
            ClassInput = " ";
        if (ClassLabel == null)
            ClassLabel = " ";
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);
        ClassForm += " " + classes[KeyForm];
        ClassInput += " " + classes[KeyInput];
        ClassLabel += " " + classes[KeyLabel];
        ClassButton += " " + classes[KeyButton];


        return base.UpdateStyleAsync(classes);
    }
}

public class Cardform : ComponentBaseCard<Dataform>
{
    public override TypeComponentCard Type => throw new NotImplementedException();
    public static ICollection<string> NAMECLASSES => StylesCardform.CLASSES.Keys.ToList();

    public static Cardform Create(Dataform data)
    {
        var instance = new Cardform();
        instance.Build(data);
        return instance;
    }

    public override void Build(Dataform db)
    {
        DataBuild = db;
    }
}
public class StylesCardContactInfo : StyleBaseComponentCard
{
    [Parameter] public string? ClassIconBox { get; set; }
    [Parameter] public string? ClassTextInfo { get; set; }
    [Parameter] public string? ClassTitle { get; set; }
    public static string KeyClassContainer = "classContainer";

    public static string KeyIconBox = "iconBox";
    public static string KeyTextInfo = "textInfo";
    public static string KeyTitle = "title";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {

         { KeyClassContainer, "flex items-start" },
        { KeyIconBox, "p-3 rounded-lg mr-4" },
        { KeyTextInfo, "text-gray-400" },
        { KeyTitle, "font-bold mb-1" },

    };
    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (KeyClassContainer == null)
            ClassContainer = " ";
        if (ClassIconBox == null)
            ClassIconBox = " ";
        if (ClassTextInfo == null)
            ClassTextInfo = " ";
        if (ClassTitle == null)
            ClassTitle = " ";
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassContainer += " " + classes[KeyClassContainer];
        ClassIconBox += " " + classes[KeyIconBox];
        ClassTextInfo += " " + classes[KeyTextInfo];
        ClassTitle += " " + classes[KeyTitle];


        return base.UpdateStyleAsync(classes);
    }
}
public class CardContactInfo : ComponentBaseCard<ContactInfo>
{
    public override TypeComponentCard Type => throw new NotImplementedException();
    public static ICollection<string> NAMECLASSES => StylesCardContactInfo.CLASSES.Keys.ToList();

    public static CardContactInfo Create(ContactInfo data)
    {
        var instance = new CardContactInfo();
        instance.Build(data);
        return instance;
    }

    public override void Build(ContactInfo db)
    {
        DataBuild = db;
    }
}
public class StylesContactCard2 : StyleBaseComponentCard
{
    [Parameter] public string? ClassSection { get; set; }
    [Parameter] public string? ClassTitle { get; set; }
    [Parameter] public string? ClassDescription { get; set; }
    
    [Parameter] public string? ClassLabel { get; set; }
    [Parameter] public string? ClassContactBox { get; set; }
   

    public static string KeySection = "section";
    public static string KeyClassContainer = "classContainer";
    public static string KeyTitle = "title";
    public static string KeyDescription = "description";
    
    public static string KeyLabel = "label";
    public static string KeyContactBox = "contactBox";
   

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeySection, "py-20 px-4 sm:px-6 lg:px-8 bg-gray-800" },
        { KeyClassContainer, "max-w-7xl mx-auto" },
        { KeyTitle, "text-xl font-bold mb-6" },
        { KeyDescription, "text-gray-400 max-w-3xl mx-auto" },      
        { KeyLabel, "font-bold mb-4" },
        { KeyContactBox, "bg-gray-900/50 p-8 rounded-2xl h-full" },
        
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        ClassSection ??= "";
        ClassContainer ??= "";
        ClassTitle ??= "";
        ClassDescription ??= "";
        
        ClassLabel ??= "";
        ClassContactBox ??= "";
       

        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassSection += " " + classes[KeySection];
        ClassContainer += " " + classes[KeyClassContainer];
        ClassTitle += " " + classes[KeyTitle];
        ClassDescription += " " + classes[KeyDescription];
        ClassLabel += " " + classes[KeyLabel];

        ClassContactBox += " " + classes[KeyContactBox];
       

        return base.UpdateStyleAsync(classes);
    }
}
public class CardContact2 : ComponentBaseCard<ContactData2>
{
    public static ICollection<string> NAMECLASSES => StylesContactCard2.CLASSES.Keys.ToList();
    public Cardform Iform { get; set; }
    public List<CardContactInfo> Info { get; set; } = new();

    public override TypeComponentCard Type => throw new NotImplementedException();

    public override void Build(ContactData2 db)
    {
        DataBuild = db;
        Iform = Cardform.Create(db.Iform);
        foreach (var item in db.Info)
        {
            var listUnifiedButtonModel = CardContactInfo.Create(item);
            Info.Add(listUnifiedButtonModel);


        }
     
    }
        public static CardContact2 Create(ContactData2 data)
        {
            var instance = new CardContact2();
            instance.Build(data);
            return instance;
        }
    }


public class StylesContactCard : StyleBaseComponentCard
{
    [Parameter] public string? ClassSection { get; set; }
    [Parameter] public string? ClassTitle { get; set; }
    [Parameter] public string? ClassDescription { get; set; }

    [Parameter] public string? ClassContactBox { get; set; }
    

    public static string KeySection = "section";
    public static string KeyContainer = "container";
    public static string KeyTitle = "title";
    public static string KeyDescription = "description";
    
    public static string KeyContactBox = "contactBox";
    

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeySection, "py-20 px-4 sm:px-6 lg:px-8 bg-gray-800" },
        { KeyContainer, "max-w-7xl mx-auto" },
        { KeyTitle, "text-3xl font-bold mb-4" },
        { KeyDescription, "text-gray-400 max-w-3xl mx-auto" },
        
        { KeyContactBox, "bg-gray-900/50 p-8 rounded-2xl h-full" },
        
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        ClassSection ??= "";
        ClassContainer ??= "";
        ClassTitle ??= "";
        ClassDescription ??= "";
        
        ClassContactBox ??= "";
       

        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassSection += " " + classes[KeySection];
        ClassContainer += " " + classes[KeyContainer];
        ClassTitle += " " + classes[KeyTitle];
        ClassDescription += " " + classes[KeyDescription];
        
        ClassContactBox += " " + classes[KeyContactBox];
        

        return base.UpdateStyleAsync(classes);
    }
}
public class CardContact : ComponentBaseCard<ContactData>
{
    public static ICollection<string> NAMECLASSES => StylesContactCard.CLASSES.Keys.ToList();
    public Cardform Iform { get; set; }
    public List<CardContactInfo> Info { get; set; } = new();
    public CardContact2 contact2 { get; set; }

    public override TypeComponentCard Type => throw new NotImplementedException();

    public override void Build(ContactData db)
    {
        DataBuild = db;

    contact2 = CardContact2.Create(db.contact2);
        Iform = Cardform.Create(db.Iform);
        foreach (var item in db.Info)
        {
            var listUnifiedButtonModel = CardContactInfo.Create(item);
            Info.Add(listUnifiedButtonModel);


        }
       
    }
    public static CardContact Create(ContactData data)
    {
        var instance = new CardContact();
        instance.Build(data);
        return instance;
    }
}














using Data.Hero;
using Microsoft.AspNetCore.Components;
using ChatASG.Data.Templates.Base;

namespace Data.Experience;
public class DataSkills
{

}


public class DataUnifiedExperienceDetails
{
    public string Label { get; set; } = "";
    public string? Icon { get; set; }
    public string? Link { get; set; }
    public string? Color { get; set; }
    public string? Description { get; set; }
    

}
public class StylesExperienceFeatureItem : StyleBaseComponentCard
{
    public static string KeyClassItem = "classItem";
    public static string KeyClassIcon = "classIcon";
    public static string KeyClassText = "classText";

    [Parameter] public string? ClassIcon { get; set; }
    [Parameter] public string? ClassText { get; set; }

    public static readonly Dictionary<string, string> CLASSES = new()
    {
        { KeyClassItem, "flex items-start" },
        { KeyClassIcon, "mr-3 mt-1 text-blue-400" },
        { KeyClassText, "" } // فارغة افتراضياً، يمكن تعديلها لاحقاً
    };

    public virtual Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (KeyClassItem == null)
            ClassItem = " ";
        if (ClassIcon == null)
            ClassIcon = " ";
        if (ClassText == null)
            ClassText = " ";
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassItem += " " + classes[KeyClassItem];
        ClassIcon += " " + classes[KeyClassIcon];
        ClassText += " " + classes[KeyClassText];

        return base.UpdateStyleAsync(classes);
    }
}


public class CardExperienceFeatureModul : ComponentBaseCard<DataUnifiedExperienceDetails>
{
    public static ICollection<string> NAMECLASSES => StylesExperienceFeatureItem.CLASSES.Keys.ToList();


    public override TypeComponentCard Type => throw new NotImplementedException();

    public override void Build(DataUnifiedExperienceDetails db)
    {
        DataBuild = db;

    }


    public static CardExperienceFeatureModul Create(DataUnifiedExperienceDetails data)
    {
        var unifiedButtonModel = new CardExperienceFeatureModul();
        unifiedButtonModel.Build(data);
        return unifiedButtonModel;
    }
}


public class DataExperienceDetail
{
    public string Label { get; set; } = "";
    public string? Icon { get; set; }
    public string? Link { get; set; }
    public string? Description { get; set; }
    public string Title { get; set; } = "";
    public string? IconColor { get; set; }
    public string Company { get; set; } = "";
    public string Period { get; set; } = "";
    public string Position { get; set; } = "";

    public List<DataUnifiedExperienceDetails> Items { get; set; } = new List<DataUnifiedExperienceDetails>();

}
public class StylesExperienceItem : StyleBaseComponentCard
{
    public static string KeyClassWrapper = "classWrapper";
    public static string KeyClassMarker = "classMarker";
    public static string KeyClassContainer = "classContainer";
    public static string KeyClassHeader = "classHeader";
    public static string KeyClassCompany = "classCompany";
    public static string KeyClassPeriod = "classPeriod";
    public static string KeyClassPosition = "classPosition";
    public static string KeyClassDetails = "classDetails";

    [Parameter] public string? ClassWrapper { get; set; }
    [Parameter] public string? ClassMarker { get; set; }
    [Parameter] public string? ClassHeader { get; set; }
    [Parameter] public string? ClassCompany { get; set; }
    [Parameter] public string? ClassPeriod { get; set; }
    [Parameter] public string? ClassPosition { get; set; }
    [Parameter] public string? ClassDetails { get; set; }

    public static readonly new Dictionary<string, string> CLASSES = new()
        {
        [KeyClassWrapper] = "relative pl-10 mb-12 timeline-item",
        [KeyClassMarker] = "absolute left-0 top-1 w-4 h-4 rounded-full bg-blue-500 border-4 border-slate-900",
        [KeyClassContainer] = "bg-slate-800/50 border border-slate-700 rounded-xl p-6 glow-effect",
        [KeyClassHeader] = "flex flex-col md:flex-row md:items-center md:justify-between mb-4",
        [KeyClassCompany] = "text-xl font-bold",
        [KeyClassPeriod] = "text-sm bg-blue-900/30 text-blue-300 px-3 py-1 rounded-full",
        [KeyClassPosition] = "text-lg text-blue-300 mb-4",
        [KeyClassDetails] = "space-y-4"
    };

    public virtual Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (ClassWrapper == null)
            ClassWrapper = " ";
        if (ClassMarker == null)
            ClassMarker = " ";
        if (KeyClassContainer == null)
            ClassContainer = " ";
        if (ClassHeader == null)
            ClassHeader = " ";
        if (ClassCompany == null)
            ClassCompany = " ";
        if (ClassPeriod == null)
            ClassPeriod = " ";
        if (ClassPosition == null)
            ClassPosition = " ";
        if (ClassDetails == null)
            ClassDetails = " ";

        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);


        ClassWrapper += " " + classes[KeyClassWrapper];
        ClassMarker += " " + classes[KeyClassMarker];
        ClassContainer += " " + classes[KeyClassContainer];
        ClassHeader += " " + classes[KeyClassHeader];
        ClassCompany += " " + classes[KeyClassCompany];
        ClassPeriod += " " + classes[KeyClassPeriod];
        ClassPosition += " " + classes[KeyClassPosition];
        ClassDetails += " " + classes[KeyClassDetails];

        return base.UpdateStyleAsync(classes);
    }
}


public class CardExperienceDetailModul : ComponentBaseCard<DataExperienceDetail>
{
    public static ICollection<string> NAMECLASSES => StylesExperienceItem.CLASSES.Keys.ToList();

    public List<CardExperienceFeatureModul> Items { get; set; } = new List<CardExperienceFeatureModul>();

    public override TypeComponentCard Type => throw new NotImplementedException();

    public override void Build(DataExperienceDetail db)
    {
        DataBuild = db;
        foreach (var item in db.Items)
        {
            var unifiedButtonModel = CardExperienceFeatureModul.Create(item);
            Items.Add(unifiedButtonModel);
        }

    }


    public static CardExperienceDetailModul Create(DataExperienceDetail data)
    {

        var listUnifiedButtonModel = new CardExperienceDetailModul();

        listUnifiedButtonModel.Build(data);
        return listUnifiedButtonModel;
    }
}


    
public class DataCardListExperienceDetailsModel
{
    public string Title { get; set; } = "";
    public string? Icon { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; }
    public string? Link { get; set; }
   
    public List<DataExperienceDetail> Items { get; set; } = new List<DataExperienceDetail>();
}

public class StylesExperienceListModel : StyleBaseComponentCard
{
    public static string KeyClassSection = "classSection";
    public static string KeyClassTitle = "classTitle";
    public static string KeyClassTitleText = "classTitleText";
    public static string KeyClassItemsContainer = "classItemsContainer";

    [Parameter] public string? ClassSection { get; set; }
    [Parameter] public string? ClassTitle { get; set; }
    [Parameter] public string? ClassTitleText { get; set; }
    [Parameter] public string? ClassItemsContainer { get; set; }

    public static readonly Dictionary<string, string> CLASSES = new()
    {
        [KeyClassSection] = "py-16 px-6",
        [KeyClassContainer] = "container mx-auto",
        [KeyClassTitle] = "text-3xl font-bold mb-12 text-center section-title",
        [KeyClassTitleText] = "gradient-text",
        [KeyClassItemsContainer] = "max-w-3xl mx-auto"
    };

    public virtual Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
      
        if (ClassSection == null)
            ClassSection = " ";
        if (KeyClassContainer == null)
            ClassContainer = " ";
        if (ClassTitle == null)
            ClassTitle = " ";
        if (ClassTitleText == null)
            ClassTitleText = " ";
        if (ClassItemsContainer == null)
      

        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);
        ClassSection += " " + classes[KeyClassSection];
        ClassContainer += " " + classes[KeyClassContainer];
        ClassTitle += " " + classes[KeyClassTitle];
        ClassTitleText += " " + classes[KeyClassTitleText];
        ClassItemsContainer += " " + classes[KeyClassItemsContainer];

        return base.UpdateStyleAsync(classes);
    }
}

public class     CardListUnifiedExperienceDetailsModel : ComponentBaseCard<DataCardListExperienceDetailsModel>

{
    public static ICollection<string> NAMECLASSES => StylesExperienceListModel.CLASSES.Keys.ToList();

    public List<CardExperienceDetailModul> Items { get; set; } = new List<CardExperienceDetailModul>();
    public override TypeComponentCard Type => throw new NotImplementedException();
    public override void Build(DataCardListExperienceDetailsModel db)
    {
        DataBuild = db;
        foreach (var item in db.Items)
        {
            var listUnifiedButtonModel = CardExperienceDetailModul.Create(item);
            Items.Add(listUnifiedButtonModel);
        }

    }

    public static     CardListUnifiedExperienceDetailsModel Create(DataCardListExperienceDetailsModel data)
    {
        var cardListUnifiedButtonModel = new     CardListUnifiedExperienceDetailsModel();
        cardListUnifiedButtonModel.Build(data);
        return cardListUnifiedButtonModel;
    }

}


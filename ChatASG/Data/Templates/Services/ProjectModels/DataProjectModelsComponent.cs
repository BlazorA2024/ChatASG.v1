using Data.HeaderModels;
using Microsoft.AspNetCore.Components;
using static MudBlazor.CategoryTypes;
using ChatASG.Data.Templates.Base;

namespace Data.Projects;
public class DataCardProject
{
    public string? Title { get; set; }
    public string? Icon { get; set; }
    public string? IconColor { get; set; }
    public List<string> Tags { get; set; } = new();
    public string? Link { get; set; }
}
public class StyleCardProject : StyleBaseComponentCard
{    [Parameter] public string? ClassTag { get; set; }
    [Parameter] public string? ClassLink { get; set; }

    public static string KeyClassContainer = "classContainer";
    public static string KeyClassTag = "classTag";
    public static string KeyClassLink = "classLink";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyClassContainer, "md:w-1/3 bg-slate-800 p-6 flex items-center justify-center" },
        { KeyClassTag, "bg-slate-700 px-2 py-1 rounded-full text-xs" },
        { KeyClassLink, "inline-block mt-4 text-blue-400 hover:text-blue-300" }
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (KeyClassContainer == null)
            ClassContainer = " ";
        if (ClassTag == null)
            ClassTag = " ";
        if (ClassLink == null)
            ClassLink = " ";
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);
        ClassContainer += "  " + classes[KeyClassContainer];
        ClassTag += " " + classes[KeyClassTag];
        ClassLink +=" "+ classes[KeyClassLink];


        return base.UpdateStyleAsync(classes);
    }
}

public class CardProjectModule : ComponentBaseCard<DataCardProject>
{
    public static ICollection<string> NAMECLASSES => StyleCardProject.CLASSES.Keys.ToList();

    public override TypeComponentCard Type => throw new NotImplementedException();

  
   

    public override void Build(DataCardProject db)
    {
        DataBuild = db;
        //foreach (var item in db.Items)
        //{
        //    var listUnifiedButtonModel = ListUnifiedProjectModul.Create(item);
        //    Items.Add(listUnifiedButtonModel);
        //}

    }

    public static CardProjectModule Create(DataCardProject data)
    {
        var instance = new CardProjectModule();
        instance.Build(data);
        return instance;
    }


}

public class DataProjectDetail
{
    public string? Icon { get; set; }
    public string? Description { get; set; }
    public string Headline { get; set; }
    public List<string> Features { get; set; } = new();
    public List<string> Skills { get; set; } = new();
}


public class StyleCardProjectDetail : StyleBaseComponentCard
{
    [Parameter] public string? ClassTitle { get; set; }
    [Parameter] public string? ClassDescription { get; set; }
    [Parameter] public string? ClassFeatureItem { get; set; }
    [Parameter] public string? ClassFeatureIcon { get; set; }
    [Parameter] public string? ClassSkillTag { get; set; }

    public static string KeyClassContainer = "classContainer";
    public static string KeyClassTitle = "classTitle";
    public static string KeyClassDescription = "classDescription";
    public static string KeyClassFeatureItem = "classFeatureItem";
    public static string KeyClassFeatureIcon = "classFeatureIcon";
    public static string KeyClassSkillTag = "classSkillTag";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyClassContainer, "md:w-2/3 p-8" },
        { KeyClassTitle, "text-2xl font-bold mb-4" },
        { KeyClassDescription, "text-slate-300 mb-4" },
        { KeyClassFeatureItem, "flex items-start" },
        { KeyClassFeatureIcon, "fas fa-check mr-2 mt-1 text-green-400" },
        { KeyClassSkillTag, "bg-slate-800/70 border border-slate-700 px-3 py-1 rounded-full text-xs" }
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (KeyClassContainer == null)
            ClassContainer = " ";
        if (ClassTitle == null)
            ClassTitle = " ";
        if (ClassDescription == null)
            ClassDescription = " ";
        if (ClassFeatureItem == null)
            ClassFeatureItem = " ";
        if (ClassFeatureIcon == null)
            ClassFeatureIcon = " ";
        if (ClassSkillTag == null)
            ClassSkillTag = "  ";

        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassContainer += "  " + classes[KeyClassContainer];
        ClassTitle += " " + classes[KeyClassTitle];
        ClassDescription += " " + classes[KeyClassDescription];

        ClassFeatureItem += " " + classes[KeyClassFeatureItem];
        ClassFeatureIcon += " " + classes[KeyClassFeatureIcon];
        ClassSkillTag += " " + classes[KeyClassSkillTag];

        return base.UpdateStyleAsync(classes);
    }
}

public class ListProjectDetail : ComponentBaseCard<DataProjectDetail>
{
    public override TypeComponentCard Type => throw new NotImplementedException();
    public static ICollection<string> NAMECLASSES => StyleCardProjectDetail.CLASSES.Keys.ToList();

    public override void Build(DataProjectDetail db)
    {
        DataBuild = db;
       // IProject = CardProjectModule.Create(db.IProject);

    }


    public static ListProjectDetail Create(DataProjectDetail data)
    {

        var listUnifiedButtonModel = new ListProjectDetail();

        listUnifiedButtonModel.Build(data);
        return listUnifiedButtonModel;
    }
}



public class DataListProjectModul
{
    public string Label { get; set; } = "";
    public string? Icon { get; set; }
    public string? Link { get; set; }
    public string? Description { get; set; }
    public string Title { get; set; } = "";
    public string? IconColor { get; set; }
    public string Headline { get; set; }
    public DataCardProject IProject { get; set; }
    public DataProjectDetail IDetail { get; set; }

    //public List<string> Tags { get; set; } = new();
    //public List<string> Features { get; set; } = new();
    //public List<string> Skills { get; set; } = new();
}



public class ListUnifiedProjectModul : ComponentBaseCard<DataListProjectModul>
{
    public override TypeComponentCard Type => throw new NotImplementedException();
    public CardProjectModule IProject { get; set; }
    public ListProjectDetail IDetail { get; set; }


    public override void Build(DataListProjectModul db)
    {
        DataBuild = db;
        IProject = CardProjectModule.Create(db.IProject);
        IDetail = ListProjectDetail.Create(db.IDetail);


    }


    public static ListUnifiedProjectModul Create(DataListProjectModul data)
    {

        var listUnifiedButtonModel = new ListUnifiedProjectModul();

        listUnifiedButtonModel.Build(data);
        return listUnifiedButtonModel;
    }
}


public class DataCardListProjectModul
{
    public string Title { get; set; } = "";
    public string? Icon { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; }
    public string? Link { get; set; }

    public List<DataListProjectModul> Items { get; set; } = new List<DataListProjectModul>();
}

public class CardListUnifiedProjectModul : ComponentBaseCard<DataCardListProjectModul>

{

    public List<ListUnifiedProjectModul> Items { get; set; } = new List<ListUnifiedProjectModul>();
    public override TypeComponentCard Type => throw new NotImplementedException();
    public override void Build(DataCardListProjectModul db)
    {
        DataBuild = db;
        foreach (var item in db.Items)
        {
            var listUnifiedButtonModel = ListUnifiedProjectModul.Create(item);
            Items.Add(listUnifiedButtonModel);
        }

    }

    public static     CardListUnifiedProjectModul Create(DataCardListProjectModul data)
    {
        var cardListUnifiedButtonModel = new     CardListUnifiedProjectModul();
        cardListUnifiedButtonModel.Build(data);
        return cardListUnifiedButtonModel;
    }

}


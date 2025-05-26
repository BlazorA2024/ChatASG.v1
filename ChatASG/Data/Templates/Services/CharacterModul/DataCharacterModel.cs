
//using dApp.Spectral;
//using dApp.Spectral.Model;
//using dApp.Spectral.Styles;
//using LAHJA.Data.UI.Components.Base;
//using Microsoft.AspNetCore.Components;

//namespace Data.CharacterModels;

//public class DataButtons
//{
//    public string? Buttons { get; set; }
//    public string? Icon { get; set; }
//    public string Title { get; set; } = "";

//}


//public class StylesButtonIcon : StyleBaseComponentCard
//{
//    [Parameter] public string? ClassButton { get; set; }
//    [Parameter] public string? ClassIcon { get; set; }
//    [Parameter] public string? ClassText { get; set; }

//    public static string KeyClassButton = "classButton";
//    public static string KeyClassIcon = "classIcon";
//    public static string KeyClassText = "classText";

//    public static readonly new Dictionary<string, string> CLASSES = new()
//        {
//            { KeyClassContainer, StyleBaseComponentCard.KeyClassContainer },
//            { KeyClassButton, "w-full mt-4 p-3 rounded-lg border-2 border-dashed border-dark-600 hover:border-purple-500 text-gray-400 hover:text-purple-400 transition flex items-center justify-center" },
//            { KeyClassIcon, "mr-2" },
//           // { KeyClassText, "text-xl font-semibold mb-4 text-purple-400" }
//        };

//    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
//    {
//        if (ClassButton == null)
//            ClassButton = " ";
//        if (ClassIcon == null)
//            ClassIcon = " ";
//        if (classes == null || IsIgnoredStyle)
//            return Task.FromResult(false);

//        ClassButton += classes[KeyClassButton];
//        ClassIcon += classes[KeyClassIcon];
//        // ClassText ??= classes[KeyClassText];

//        return base.UpdateStyleAsync(classes);
//    }
//}


//public class CardButtonsModul : ComponentBaseCard<DataButtons>
//{
//    public override TypeComponentCard Type => throw new NotImplementedException();
//    public static ICollection<string> NAMECLASSES => StylesButtonIcon.CLASSES.Keys.ToList();
//    public override void Build(DataButtons db) => DataBuild = db;
//    public static CardButtonsModul Create(DataButtons data)
//    {
//        var instance = new CardButtonsModul();
//        instance.Build(data);
//        return instance;
//    }
//}


//public class DataListProjectModul
//{
//    public string? Name { get; set; }

//    public string? Icon { get; set; }
//    public string? Link { get; set; }
//    public string? Description { get; set; }
//    public string Title { get; set; } = "";
//    public string? IconColor { get; set; }
//    public string? Image { get; set; }
//    public bool IsSelected { get; set; } = false;

//}


//public class StylesProjectCard : StyleBaseComponentCard
//{
//    [Parameter] public string? ClassImage { get; set; }
//    [Parameter] public string? ClassTitle { get; set; }
//    [Parameter] public string? ClassDescription { get; set; }

//    public static string KeyClassContainer = "classContainer";
//    public static string KeyClassImage = "classImage";
//    public static string KeyClassTitle = "classTitle";
//    public static string KeyClassDescription = "classDescription";

//    public static readonly new Dictionary<string, string> CLASSES = new()
//    {
//        { KeyClassContainer, "flex items-center p-3 rounded-lg bg-dark-800 hover:bg-dark-600 cursor-pointer transition" },
//        { KeyClassImage, "w-12 h-12 rounded-full object-cover mr-3" },
//        { KeyClassTitle, "font-medium text-white" },
//        { KeyClassDescription, "text-sm text-gray-400" }
//    };

//    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
//    {
//        ClassContainer = classes.GetValueOrDefault(KeyClassContainer, "");
//        ClassImage = classes.GetValueOrDefault(KeyClassImage, "");
//        ClassTitle = classes.GetValueOrDefault(KeyClassTitle, "");
//        ClassDescription = classes.GetValueOrDefault(KeyClassDescription, "");

//        return base.UpdateStyleAsync(classes);
//    }
//}




//public class ProjectCardModul : ComponentBaseCard<DataListProjectModul>
//{
//    public override TypeComponentCard Type => throw new NotImplementedException();
//    public static ICollection<string> NAMECLASSES => StylesProjectCard.CLASSES.Keys.ToList();

//    public override void Build(DataListProjectModul db)
//    {
//        DataBuild = db;

//    }


//    public static ProjectCardModul Create(DataListProjectModul data)
//    {

//        var listUnifiedButtonModel = new ProjectCardModul();

//        listUnifiedButtonModel.Build(data);
//        return listUnifiedButtonModel;
//    }
//}

//public class DataCardListProjectModul
//{
//    public string Title { get; set; } = "";
//    public string? Icon { get; set; }
//    public string? Name { get; set; }
//    public string? Description { get; set; }

//    public string? Link { get; set; }
//    public DataButtons? IButtons { get; set; }

//    public List<DataListProjectModul> Items { get; set; } = new List<DataListProjectModul>();
//}

//public class StylesCardListProjectModul : StyleBaseComponentCard
//{
//    [Parameter] public string? ClassTitle { get; set; }
//    [Parameter] public string? ClassSpace { get; set; }

//    public static string KeyClassContainer = "classContainer";
//    public static string KeyClassItem = "classItem";
//    public static string KeyClassTitle = "classTitle";
//    public static string KeyClassSpace = "classDescription";

//    public static readonly new Dictionary<string, string> CLASSES = new()
//    {
//        { KeyClassContainer, "lg:w-1/4" },
//        { KeyClassItem, " bg-dark-700 rounded-xl p-6 sticky top-24" },
//        { KeyClassTitle, "text-xl font-semibold text-white mb-4" },
//        { KeyClassSpace, "space-y-3" }
//    };

//    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
//    {
//        if (ClassContainer == null)
//            ClassContainer = " ";
//        if (ClassItem == null)
//            ClassItem = " ";

//        if (ClassTitle == null)
//            ClassTitle = " ";
//        if (ClassSpace == null)
//            ClassSpace = " ";
//        if (classes == null || IsIgnoredStyle)
//            return Task.FromResult(false);

//        ClassContainer += classes[KeyClassContainer];
//        ClassItem += classes[KeyClassItem];
//        ClassTitle += classes[KeyClassTitle];
//        ClassSpace += classes[KeyClassSpace];
//        // ClassText ??= classes[KeyClassText];



//        return base.UpdateStyleAsync(classes);
//    }
//}
//public class CardListProjectModul : ComponentBaseCard<DataCardListProjectModul>

//{
//    public CardButtonsModul IButtons { get; set; }
//    public List<ProjectCardModul> Items { get; set; } = new List<ProjectCardModul>();
//    public override TypeComponentCard Type => throw new NotImplementedException();
//    public static ICollection<string> NAMECLASSES => StylesCardListProjectModul.CLASSES.Keys.ToList();

//    public override void Build(DataCardListProjectModul db)
//    {
//        DataBuild = db;
//        IButtons = CardButtonsModul.Create(db.IButtons);
//        foreach (var item in db.Items)
//        {
//            var listUnifiedButtonModel = ProjectCardModul.Create(item);
//            Items.Add(listUnifiedButtonModel);
//        }

//    }

//    public static CardListProjectModul Create(DataCardListProjectModul data)
//    {
//        var cardListUnifiedButtonModel = new CardListProjectModul();
//        cardListUnifiedButtonModel.Build(data);
//        return cardListUnifiedButtonModel;
//    }
//}
//public class DataCardAddProjectModul
//{
//    public string Title { get; set; } = "";
//    public string? Icon { get; set; }
//    public string? Name { get; set; }
//    public string? Description { get; set; }

//    public string? Link { get; set; }
//    public DataCardListProjectModul? ICharact { get; set; }

//}


//public class CardListAddProjectModul : ComponentBaseCard<DataCardAddProjectModul>

//{
//    public CardListProjectModul ICharact { get; set; }
//    public override TypeComponentCard Type => throw new NotImplementedException();

//    public override void Build(DataCardAddProjectModul db)
//    {
//        DataBuild = db;
//        ICharact = CardListProjectModul.Create(db.ICharact);
       

//    }

//    public static CardListAddProjectModul Create(DataCardAddProjectModul data)
//    {
//        var cardListUnifiedButtonModel = new CardListAddProjectModul();
//        cardListUnifiedButtonModel.Build(data);
//        return cardListUnifiedButtonModel;
//    }
//}




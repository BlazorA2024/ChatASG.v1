using ChatASG.Data.Templates.Base;
using Microsoft.AspNetCore.Components;

namespace Data.Operation;



public class DataOperation
{
    public string? Icon { get; set; }
    public string Title { get; set; }
    public string? ClassColor { get; set; }
    public string? Name { get; set; }
    public string? Button { get; set; }
    public string? Icons { get; set; }

    public string ClassButton { get; set; } = "";

}
public class StylesCardOperation : StyleBaseComponentCard
{
    [Parameter] public string? ClassButton { get; set; }
    [Parameter] public string? ClassIcon { get; set; }
    [Parameter] public string? ClassName { get; set; }
    [Parameter] public string? ClassIcons { get; set; }

    public static string KeyClassContainer = "classContainer";

    public static string KeyClassName = "className";

    public static string KeyClassIcon = "classIcon";
    public static string KeyClassIcons = "classIcons";


    public static string KeyClassButton = "classButton";


    public static readonly new Dictionary<string, string> CLASSES = new()
        {
        {KeyClassContainer,"flex items-center justify-between mb-4" },
        { KeyClassButton, "text-gray-500 hover:text-gray-700 text-sm" },
         { KeyClassName, "text-xl font-semibold text-gray-800 flex items-center" },
        { KeyClassIcon, " mr-2 text-blue-600" },
        {KeyClassIcons,"mr-1"}
        };
    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (KeyClassContainer == null)
            ClassContainer = " ";

        
        if (ClassName == null)
            ClassName = " ";
        if (ClassIcon == null)
            ClassIcon = " ";
        if (ClassButton == null)
            ClassButton = " ";
        if (ClassIcons == null)
            ClassIcons = " ";

        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassContainer += " " + classes[KeyClassContainer];

        ClassName += " " + classes[KeyClassName];

        ClassIcon += " " + classes[KeyClassIcon];

        ClassButton += " " + classes[KeyClassButton];
        ClassIcons += " " + classes[KeyClassIcons];

        return base.UpdateStyleAsync(classes);
    }
}
public class CardOperation : ComponentBaseCard<DataOperation>
{
    public static ICollection<string> NAMECLASSES => StylesCardOperation.CLASSES.Keys.ToList();

    public override TypeComponentCard Type => throw new NotImplementedException();

    public override void Build(DataOperation db)
    {
        DataBuild = db;
    }

    public static CardOperation Create(DataOperation data)
    {
        var instance = new CardOperation();
        instance.Build(data);
        return instance;
    }
}



public class DataSystem
{
    public string? Name { get; set; }

    public string? Icon { get; set; }
    public string? YSTEM { get; set; }
    public string? Icons { get; set; }
    public DateTime Timestamp { get; set; }
    public string? Description { get; set; }

}
public class StylesCardSyste : StyleBaseComponentCard
{
    [Parameter] public string? ClassTitle { get; set; }
    [Parameter] public string? ClassName { get; set; }

    public static string KeyClassContainer = "classContainer";

    public static string KeyClassItem { get; set; } = "classItem";
    public static string KeyClassName = "className";



    public static string KeyClassTitle = "classTitle";


    public static readonly new Dictionary<string, string> CLASSES = new()      {
        {KeyClassContainer,"space-y-2 text-sm max-h-64 overflow-y-auto pr-2" },
        { KeyClassItem, "log-entry bg-gray-50 px-3 py-2 rounded" },
        { KeyClassTitle, " text-xs text-gray-500 mt-1 ml-4" },
         { KeyClassName, "flex items-start" }


        };
    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (KeyClassContainer == null)
            ClassContainer = " ";

        if (KeyClassItem == null)
            ClassItem = " ";
        if (ClassName == null)
            ClassName = " ";

        if (ClassTitle == null)
            ClassTitle = " ";

        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassContainer += " " + classes[KeyClassContainer];

        ClassItem += " " + classes[KeyClassItem];
        ClassName += " " + classes[KeyClassName];



        ClassTitle += " " + classes[KeyClassTitle];


        return base.UpdateStyleAsync(classes);
    }
}

public class CardSystem : ComponentBaseCard<DataSystem>
{
    public static ICollection<string> NAMECLASSES => StylesCardSyste.CLASSES.Keys.ToList();

    public override TypeComponentCard Type => throw new NotImplementedException();

    public override void Build(DataSystem db)
    {
        DataBuild = db;
    }

    public static CardSystem Create(DataSystem data)
    {
        var instance = new CardSystem();
        instance.Build(data);
        return instance;
    }
}

public class DataAddOperation : ModulsBase
{
    public DataOperation IOperation { get; set; }
    public DataSystem Isystem { get; set; }
}
public class StylesCardAddOperation : StyleBaseComponentCard
{
   

    public static string KeyClassContainer = "classContainer";
    public static string KeyClassItem { get; set; } = "classItem";
  
    //public static string KeyClassTitle = "classTitle";
    public static string KeyClassDescription = "classDescription";
    public static string KeyClassItems = "classItems";

    public static readonly new Dictionary<string, string> CLASSES = new()
        {
        { KeyClassContainer, " card bg-white rounded-xl p-6 " },
        { KeyClassItem, "flex items-center space-x-3" },
      
        };
    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (KeyClassContainer == null)
            ClassContainer = " ";

        if (KeyClassItem == null)
            ClassItem = " ";
       
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassContainer += " " + classes[KeyClassContainer];
        ClassItem += " " + classes[KeyClassItem];
    
        return base.UpdateStyleAsync(classes);
    }
}

public class CardAddOperation : ComponentBaseCard<DataAddOperation>
{
   
    public CardOperation IOperation { get; set; }
    public CardSystem Isystem { get; set; }


    public override TypeComponentCard Type => throw new NotImplementedException();

    public static ICollection<string> NAMECLASSES => StylesCardAddOperation.CLASSES.Keys.ToList();

    public override void Build(DataAddOperation db)
    {
        DataBuild = db;
        // IContents = CardContents.Create(db.IContents);
        IOperation = CardOperation.Create(db.IOperation);
        Isystem = CardSystem.Create(db.Isystem);

      
    }

    public static CardAddOperation Create(DataAddOperation data)
    {
        var instance = new CardAddOperation();
        instance.Build(data);
        return instance;
    }

   
}





















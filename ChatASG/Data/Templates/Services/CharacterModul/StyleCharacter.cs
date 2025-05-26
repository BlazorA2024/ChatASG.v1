using ChatASG.Data.Templates.Base;
using Microsoft.AspNetCore.Components;

namespace Data.CharacteStyle;
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
        { KeyClassButton, "w-full mt-4 p-3 rounded-lg border-2 border-dashed border-dark-600 hover:border-purple-500 text-gray-400 hover:text-purple-400 transition flex items-center justify-center" },
        { KeyClassIcon, "mr-2" },
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if(ClassButton == null)
        ClassButton ??= " ";
        if(ClassIcon == null)
        ClassIcon ??= " ";

        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassButton +=" " + classes[KeyClassButton];
        ClassIcon +=" " +classes[KeyClassIcon];

        return base.UpdateStyleAsync(classes);
    }
}

public class StylesProjectCard : StyleBaseComponentCard
{
    [Parameter] public string? ClassImage { get; set; }
    [Parameter] public string? ClassTitle { get; set; }
    [Parameter] public string? ClassDescription { get; set; }

    public static string KeyClassContainer = "classContainer";
    public static string KeyClassImage = "classImage";
    public static string KeyClassTitle = "classTitle";
    public static string KeyClassDescription = "classDescription";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyClassContainer, "flex items-center p-3 rounded-lg bg-dark-800 hover:bg-dark-600 cursor-pointer transition" },
        { KeyClassImage, "w-12 h-12 rounded-full object-cover mr-3" },
        { KeyClassTitle, "font-medium text-white" },
        { KeyClassDescription, "text-sm text-gray-400" }
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {

        if (KeyClassContainer == null)
            ClassContainer = " ";
        if (ClassImage == null)
            ClassImage ??= " ";
        if (ClassTitle == null)
            ClassTitle ??= " ";
        if (ClassDescription == null)
            ClassDescription ??= " ";
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);
    
        ClassContainer += " " + classes[KeyClassContainer];
        ClassImage += " " + classes[KeyClassImage];
        ClassTitle += " " + classes[KeyClassTitle];
        ClassDescription += " " + classes[KeyClassDescription];
        return base.UpdateStyleAsync(classes);
    }
}

public class StylesCardListProjectModul : StyleBaseComponentCard
{
    [Parameter] public string? ClassTitle { get; set; }
    [Parameter] public string? ClassSpace { get; set; }

    public static string KeyClassContainer = "classContainer";
    public static string KeyClassItem = "classItem";
    public static string KeyClassTitle = "classTitle";
    public static string KeyClassSpace = "classDescription";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyClassContainer, "lg:w-1/4" },
        { KeyClassItem, " bg-dark-700 rounded-xl p-6 sticky top-24" },
        { KeyClassTitle, "text-xl font-semibold text-white mb-4" },
        { KeyClassSpace, "space-y-3" }
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if(KeyClassContainer == null)
        ClassContainer = " ";
        if(KeyClassItem == null)
        ClassItem = " ";
        if(ClassTitle == null)
        ClassTitle = " ";
        if(ClassSpace == null)
        ClassSpace = " ";

        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassContainer +=" "+ classes[KeyClassContainer];
        ClassItem += " " + classes[KeyClassItem];
        ClassTitle += " " + classes[KeyClassTitle];
        ClassSpace += " " + classes[KeyClassSpace];

        return base.UpdateStyleAsync(classes);
    }
}





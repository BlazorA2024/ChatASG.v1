using ChatASG.Data.Templates.Base;
using Microsoft.AspNetCore.Components;

namespace Data.StyleModul;

public class StyleCardListUnifiedButtonModel : StyleBaseComponentCard
{
    [Parameter] public string? ClassHeaderContainer { get; set; }
    [Parameter] public string? ClassTitle { get; set; }
    [Parameter] public string? ClassDescription { get; set; }
    [Parameter] public string? ClassNameHighlight { get; set; }
    public static string KeyClassContainer = "classContainer";

   // public static string KeyClassHeaderContainer = "classHeaderContainer";
     public static string KeyClassTitle = "classTitle";
    public static string KeyClassDescription = "classDescription";
    public static string KeyClassNameHighlight = "classNameHighlight";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyClassContainer, " text-center mb-12" },
       // { KeyClassContainer, "text-center mb-12" },
        { KeyClassTitle, "text-3xl md:text-4xl font-bold mb-4" },
        { KeyClassDescription, "text-lg text-gray-400 max-w-2xl mx-auto" },
        { KeyClassNameHighlight, "gradient-text" }
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (ClassContainer == null)
            ClassContainer = " ";
      

        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassContainer +="  "+classes[KeyClassContainer];
        ClassTitle ??= classes[KeyClassTitle];
        ClassDescription ??= classes[KeyClassDescription];
        ClassNameHighlight ??= classes[KeyClassNameHighlight];

        
        return base.UpdateStyleAsync(classes);
    }

}
    public class StyleListUnifiedButtonModel : StyleBaseComponentCard
    {
        [Parameter] public string? ClassTitle { get; set; }
        [Parameter] public string? ClassItemsContainer { get; set; }

        public static string KeyClassTitle = "classTitle";
        public static string KeyClassItemsContainer = "classItemsContainer";

        public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyClassContainer, "mb-8" }, // inherits base container
        { KeyClassTitle, "text-lg font-medium text-gray-300 mb-3" },
        { KeyClassItemsContainer, "flex flex-wrap gap-3" }
    };

        public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
        {
        if (KeyClassContainer == null)
            KeyClassContainer = "mb-8";

        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassContainer += classes[KeyClassContainer];
        ClassTitle ??= classes[KeyClassTitle];
        ClassItemsContainer ??= classes[KeyClassItemsContainer];


            return base.UpdateStyleAsync(classes);
        }
    }

public class StyleUnifiedButtonModel : StyleBaseComponentCard
{
    [Parameter] public string? ClassButton { get; set; }
    [Parameter] public string? ClassIcon { get; set; }
    [Parameter] public string? ClassPrimary { get; set; }
    [Parameter] public string? ClassSecondary { get; set; }
    [Parameter] public string? ClassActive { get; set; }

    public static string KeyClassButton = "classButton";
    public static string KeyClassIcon = "classIcon";
    public static string KeyClassPrimary = "classPrimary";
    public static string KeyClassSecondary = "classSecondary";
    public static string KeyClassActive = "classActive";

    public static readonly new Dictionary<string, string> CLASSES = new()
    {
        { KeyClassContainer, StyleBaseComponentCard.KeyClassContainer }, // optional if needed
        { KeyClassButton, "px-4 py-2 rounded-full transition" },
        { KeyClassIcon, "mr-2" },
        { KeyClassPrimary, "gradient-bg text-white hover:opacity-90" },
        { KeyClassSecondary, "bg-dark-800 text-gray-300 hover:bg-dark-700 hover:text-white" },
        { KeyClassActive, "active-model" }
    };

    public override Task<bool> UpdateStyleAsync(Dictionary<string, string> classes)
    {
        if (classes == null || IsIgnoredStyle)
            return Task.FromResult(false);

        ClassButton = classes[KeyClassButton];
        ClassIcon = classes[KeyClassIcon];
        ClassPrimary = classes[KeyClassPrimary];
        ClassSecondary = classes[KeyClassSecondary];
        ClassActive = classes[KeyClassActive];

        return base.UpdateStyleAsync(classes);
    }
}





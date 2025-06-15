using ChatASG.Data.Templates.Base;
using Data.DataSignUpForm;
using Data.Welcome;
using Microsoft.AspNetCore.Components;

namespace Data.SignUpForm;

public class CardSignUpModel : ComponentBaseCard<SignUpModel>
{
   // public static ICollection<string> NAMECLASSES => StylesFaqCard.CLASSES.Keys.ToList();

    public override TypeComponentCard Type => throw new NotImplementedException();


    public override void Build(SignUpModel db)
    {
        DataBuild = db;
    }

    public static CardSignUpModel Create(SignUpModel data)
    {
        var instance = new CardSignUpModel();
        instance.Build(data);
        return instance;
    }
}

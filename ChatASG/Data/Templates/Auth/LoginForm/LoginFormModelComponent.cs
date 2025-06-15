using ChatASG.Data.Templates.Base;
using Data.DataLoginForm;
using Data.Welcome;
using Microsoft.AspNetCore.Components;

namespace Data.LoginForm;

public class CardLoginModel : ComponentBaseCard<LoginModel>
{
   // public static ICollection<string> NAMECLASSES => StylesFaqCard.CLASSES.Keys.ToList();

    public override TypeComponentCard Type => throw new NotImplementedException();


    public override void Build(LoginModel db)
    {
        DataBuild = db;
    }

    public static CardLoginModel Create(LoginModel data)
    {
        var instance = new CardLoginModel();
        instance.Build(data);
        return instance;
    }
}

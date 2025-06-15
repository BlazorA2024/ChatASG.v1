using ChatASG.Data.Templates.Base;
using Data.AddAuth;
using Data.LeftSide;
using Data.LoginForm;
using Data.SignUpForm;
using Data.Welcome;
using Microsoft.AspNetCore.Components;

namespace Data.AddAuth;

public class CardAddAuth : ComponentBaseCard<DataAddAuth>
{
    // public static ICollection<string> NAMECLASSES => StylesFaqCard.CLASSES.Keys.ToList();
    public CardLeftSide? DataLeftSide { get; set; }
    public CardSignUpModel? IsignUp { get; set; }
    public CardLoginModel? login { get; set; }

    public override TypeComponentCard Type => throw new NotImplementedException();


    public override void Build(DataAddAuth db)
    {
        DataBuild = db;
        DataLeftSide = CardLeftSide.Create(db.DataLeftSide);
        IsignUp = CardSignUpModel.Create(db.IsignUp);
        login = CardLoginModel.Create(db.login);


    }

    public static CardAddAuth Create(DataAddAuth data)
    {
        var instance = new CardAddAuth();
        instance.Build(data);
        return instance;
    }
}

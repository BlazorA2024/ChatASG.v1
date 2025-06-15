using ChatASG.Data.Templates.Base;
using Data.Welcome;
using Microsoft.AspNetCore.Components;

namespace Data.LeftSide;

public class CardLeftSide : ComponentBaseCard<DataLeftSideModel>
{
   // public static ICollection<string> NAMECLASSES => StylesFaqCard.CLASSES.Keys.ToList();

    public override TypeComponentCard Type => throw new NotImplementedException();


    public override void Build(DataLeftSideModel db)
    {
        DataBuild = db;
    }

    public static CardLeftSide Create(DataLeftSideModel data)
    {
        var instance = new CardLeftSide();
        instance.Build(data);
        return instance;
    }
}

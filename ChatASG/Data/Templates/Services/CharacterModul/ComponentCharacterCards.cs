using Data.Character.Model;
using Data.CharacteStyle;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ChatASG.Data.Templates.Base;
namespace Data.CharacterModels;
public class CardButtonsModul : ComponentBaseCard<DataButtons>
{
    public override TypeComponentCard Type => throw new NotImplementedException();
    public static ICollection<string> NAMECLASSES => StylesButtonIcon.CLASSES.Keys.ToList();
    public override void Build(DataButtons db) => DataBuild = db;

    public static CardButtonsModul Create(DataButtons data)
    {
        var instance = new CardButtonsModul();
        instance.Build(data);
        return instance;
    }
}

public class ProjectCardModul : ComponentBaseCard<DataListProjectModul>
{
    public override TypeComponentCard Type => throw new NotImplementedException();
    public static ICollection<string> NAMECLASSES => StylesProjectCard.CLASSES.Keys.ToList();

    public override void Build(DataListProjectModul db) => DataBuild = db;

    public static ProjectCardModul Create(DataListProjectModul data)
    {
        var listUnifiedButtonModel = new ProjectCardModul();
        listUnifiedButtonModel.Build(data);
        return listUnifiedButtonModel;
    }
}

public class CardListProjectModul : ComponentBaseCard<DataCardListProjectModul>
{
    public CardButtonsModul IButtons { get; set; }
    public List<ProjectCardModul> Items { get; set; } = new();

    public override TypeComponentCard Type => throw new NotImplementedException();
    public static ICollection<string> NAMECLASSES => StylesCardListProjectModul.CLASSES.Keys.ToList();

    public override void Build(DataCardListProjectModul db)
    {
        DataBuild = db;
        IButtons = CardButtonsModul.Create(db.IButtons);
        foreach (var item in db.Items)
        {
            Items.Add(ProjectCardModul.Create(item));
        }
    }

    public static CardListProjectModul Create(DataCardListProjectModul data)
    {
        var cardListUnifiedButtonModel = new CardListProjectModul();
        cardListUnifiedButtonModel.Build(data);
        return cardListUnifiedButtonModel;
    }
}

public class CardListAddProjectModul : ComponentBaseCard<DataCardAddProjectModul>
{
    public CardListProjectModul ICharact { get; set; }

    public override TypeComponentCard Type => throw new NotImplementedException();

    public override void Build(DataCardAddProjectModul db)
    {
        DataBuild = db;
        ICharact = CardListProjectModul.Create(db.ICharact);
    }

    public static CardListAddProjectModul Create(DataCardAddProjectModul data)
    {
        var cardListUnifiedButtonModel = new CardListAddProjectModul();
        cardListUnifiedButtonModel.Build(data);
        return cardListUnifiedButtonModel;
    }
}

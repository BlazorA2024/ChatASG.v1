using ChatASG.Data.Templates.Base;

public class DataAddContact 
{

    public string? Title { get; set; }

    public string? Description { get; set; }
    public Dataform? Iform { get; set; }
    public DataCardContactSection? ISection { get; set; }

    public List<ContactInfo> Info { get; set; } = new();

    //public List<SocialLink> Socials { get; set; } = new();
}

public class DataCardContactSection 
{
    public string? Title { get; set; }
    public string? Label { get; set; }

    public List<ContactInfo> Info { get; set; } = new();

    public List<DataSocialLink> Socials { get; set; } = new();
}
public class Dataform
{
    public string? NameLabel { get; set; } 
    public string? EmailLabel { get; set; } 
    public string? SubjectLabel { get; set; } 
    public string? MessageLabel { get; set; } 
    public string? SubmitButtonText { get; set; }
}
public class ContactInfo 
{
    public string? Icon { get; set; }

    public string? Title { get; set; }
    public string? Text { get; set; }
    public string? Bg { get; set; }
  
}

public class DataSocialLink
{
    public string? Icon { get; set; } 
    public string? Url { get; set; } 
    public string? BgColor { get; set; } 
}

using ChatASG.Data.Templates.Base;

public class ContactData : ModulsBase
{

  
    public Dataform? Iform { get; set; }
    public ContactData2? contact2 { get; set; }

    public List<ContactInfo> Info { get; set; } = new();

    public List<SocialLink> Socials { get; set; } = new();
}
public class ContactData2 : ModulsBase
{
   
    public Dataform? Iform { get; set; }
    public List<ContactInfo> Info { get; set; } = new();

    public List<SocialLink> Socials { get; set; } = new();
}
public class Dataform
{
    public string NameLabel { get; set; } = "الاسم";
    public string EmailLabel { get; set; } = "البريد الإلكتروني";
    public string SubjectLabel { get; set; } = "الموضوع";
    public string MessageLabel { get; set; } = "الرسالة";
    public string SubmitButtonText { get; set; } = "إرسال الرسالة";
}
public class ContactInfo : ModulsBase
{
   
    public string? Text { get; set; }
    public string? Bg { get; set; }
  
}

public class SocialLink
{
    public string Icon { get; set; } = string.Empty; // e.g. "fab fa-twitter"
    public string Url { get; set; } = "#";
    public string BgColor { get; set; } = "bg-gray-700 hover:bg-blue-600";
}

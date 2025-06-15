using ChatASG.Data.Templates.Base;
using Microsoft.AspNetCore.Components;

namespace Data.DataSignUpForm;
public class SignUpModel
{
    public string FullName { get; set; } = "";

    public string Email { get; set; } = "";
    public string Password { get; set; } = "";
    public string ConfirmPassword { get; set; } = "";
    public bool AcceptTerms { get; set; }
    public Dataform? Dataform { get; set; }
}
public class Dataform
{
    public string? NameLabel { get; set; } = "Full Name";
    public string? EmailLabel { get; set; }
    public string? PasswordLabel { get; set; }
    public string? ConfirmPasswordLabel { get; set; }
    public string? SubmitCreateAccount { get; set; }
}

public class DataSignUpFor
{
    public string? Name { get; set; }
    public string? IconClass { get; set; }
    public string? Title { get; set; } 
    public string? Subtitle { get; set; } 
    public string? Quote { get; set; } 
}














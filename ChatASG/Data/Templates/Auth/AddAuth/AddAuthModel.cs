using ChatASG.Data.Templates.Base;
using Data.DataLoginForm;
using Data.DataSignUpForm;
using Data.Welcome;
using Microsoft.AspNetCore.Components;

namespace Data.AddAuth;
public class DataAddAuth
{
     
    public DataLeftSideModel? DataLeftSide { get; set; }
    public List<DataButtons>? IButtons { get; set; }
    public SignUpModel IsignUp { get; set; }
    public LoginModel? login { get; set; }

}

public class DataButtons
{

    public string? Button { get; set; }

}














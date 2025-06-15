using ChatASG.Data.Templates.Base;
using Microsoft.AspNetCore.Components;

namespace Data.DataLoginForm;
public class LoginModel
{
    public string Email { get; set; } = "";
    public string Password { get; set; } = "";
    public bool RememberMe { get; set; }
    public DataLoginFormLabels? ILabels { get; set; }
}
public class DataLoginFormLabels
{
    public string? Title { get; set; } = "Login to your account";
    public string? EmailOrUsernameLabel { get; set; } = "Email or Username";
    public string? EmailOrUsernamePlaceholder { get; set; } = "Enter your email or username";
    public string? PasswordLabel { get; set; } = "Password";
    public string? PasswordPlaceholder { get; set; } = "Enter your password";
    public string? RememberMe { get; set; } = "Remember me";
    public string? ForgotPassword { get; set; } = "Forgot password?";
    public string? LoginButton { get; set; } = "Login";
    public string? OrContinueWith { get; set; } = "Or continue with";
    public string? Google { get; set; } = "Google";
    public string? Facebook { get; set; } = "Facebook";
}


using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TamplateSample.Pages;

public class SwitchPage : PageModel
{
    public void OnGet()
    {
        Role = "User";
        UserAge = 19;
        UserScore = 80;
    }

    public string Role { get; set; }
    public int UserAge { get; set; }
    public int UserScore { get; set; }
    public UserRole SecondRole { get; set; }
    
    public enum  UserRole
    {
        Guest,
        User,
        Admin
    }
}
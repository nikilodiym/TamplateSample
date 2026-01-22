using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TamplateSample.Pages;

public class SimpleData : PageModel
{
    public int UserAge { get; set; }
    public string UserName { get; set; }
    public bool IsAdmin { get; set; }
    public DateOnly CurrentDate { get; set; }
    public DateTime TimeStamp { get; set; }
    public List<string> Skills { get; set; }
    public UserProfile Profile { get; set; }
    
    public void OnGet()
    {
        UserAge =  10;
        UserName = "John";
        IsAdmin = true;
        TimeStamp = DateTime.Now;
        Skills = new List<string>
        {
            "C#",
            "Java",
            "PostgreSQL"
        };
        Profile = new UserProfile
        {
            Email = "sample@test.com",
            Phone = "111",
        };
    }
    //DTO
    public class UserProfile
    {
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
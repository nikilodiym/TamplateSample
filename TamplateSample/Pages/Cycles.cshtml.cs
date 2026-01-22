using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TamplateSample.Pages;

public class Cycles : PageModel
{
    public void OnGet()
    {
        
    }

    public List<string> Colors { get; set; } = new()
    {
        "Red",
        "Orange",
        "Yellow"
    };
}
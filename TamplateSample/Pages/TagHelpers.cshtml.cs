using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TamplateSample.Pages;

public class TagHelpers : PageModel
{
    public List<SelectListItem> Roles { get; set; }
    [BindProperty]
    public string SelectedRole { get; set; }

    public void OnGet()
    {
        Roles = new()
        {
            new ("User", "USER"),
            new ("Admin1", "ADMIN")
        };
        SelectedRole = "Admin";
    }
}
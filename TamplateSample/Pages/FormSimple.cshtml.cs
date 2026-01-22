using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TamplateSample.Pages;

public class FormSimple : PageModel
{
    public void OnGet()
    {
        UserAge += 2;
    }

    public void OnPost()
    {
        UserAge += 1;
    }
    [BindProperty]
    public string UserName { get; set; }
    [BindProperty]
    public int UserAge { get; set; }
}
using System.Collections;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TamplateSample.ViewModels;

namespace TamplateSample.Pages;

public class Partial : PageModel
{
    public void OnGet()
    {
        Products = new List<ProdactViewModel>
        {
            new ProdactViewModel{Name="Ноутбук", Price = 10000, IsStock = true},
            new ProdactViewModel{Name="Смартфон", Price = 9000, IsStock = false}
        };
    }

    public List<ProdactViewModel> Products { get; set; }
}
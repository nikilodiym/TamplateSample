using Microsoft.AspNetCore.Mvc;

namespace TamplateSample.ViewModels;

public class ProdactViewModel
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool IsStock { get; set; }
}
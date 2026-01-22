using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TamplateSample.Pages;

public class ComplexForm : PageModel
{
    [BindProperty]
    public OrderCreateDto Order { get; set; }
    public List<PaymentType> PaymentTypes { get; set; }
    
    public void OnGet()
    {
        PaymentTypes = Enum.GetValues(typeof(PaymentType)).Cast<PaymentType>().ToList();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            PaymentTypes = Enum.GetValues(typeof(PaymentType)).Cast<PaymentType>().ToList();
            return Page();
        }
        
        //!!!
        
        return RedirectToPage("ComplexForm");
    }
    
    public enum PaymentType
    {
        Cash = 1,
        Card = 2,
        Transfer = 3
    }
    
    public class OrderCreateDto
    {
        [Required(ErrorMessage = "Введіть ім'я клієнта")]
        [StringLength(3)]
        [MinLength(2)]
        public string CustomerName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Range (1, 100)]
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public PaymentType PaymentType { get; set; }
        public string DeliveryMethod { get; set; }
        public bool IsGift  { get; set; }
        public string Comment { get; set; }
    }
}
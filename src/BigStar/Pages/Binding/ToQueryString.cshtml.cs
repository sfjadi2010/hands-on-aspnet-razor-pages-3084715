using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BigStar.Pages.Binding
{
    public class ToQueryStringModel : PageModel
    {
        public string CardName {get; set;} = String.Empty;
        public decimal? OriginalPrice { get; set; }
        public void OnGet()
        {
        }
    }
}

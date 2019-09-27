using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages.Settings
{
    public class AccountModel : PageModel
    {
        public AccountModel() 
        {
        }

        public IActionResult OnGet()
        {
            return Page();
        }
    }
}
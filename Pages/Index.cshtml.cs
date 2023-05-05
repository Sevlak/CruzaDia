using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CruzaDia.Pages
{
    public class Index : PageModel
    {
        public string Message = "";
        
        public void OnGet()
        {
            Message = "Hi";
        }
    }
}


using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OWASP.Broken.Access.Control.Before.Pages.Admin
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            BuildDashboard();
        }

        private void BuildDashboard()
        {
        }
    }
}
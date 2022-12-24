using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OWASP.Broken.Access.Control.After.Pages.Admin
{
    [Authorize(Roles = "Admin")]
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
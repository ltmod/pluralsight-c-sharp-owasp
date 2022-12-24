using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OWASP.Logging.Web.Before.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogInformation("This is a test.  This is only a test.");
        }
    }
}
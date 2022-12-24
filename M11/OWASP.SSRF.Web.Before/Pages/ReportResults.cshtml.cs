using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OWASP.SSRF.Web.Before.Pages
{
    public class ReportResultsModel : PageModel
    {
        private readonly IConfiguration _config;

        public ReportResultsModel(IConfiguration config)
        {
            _config = config;
        }

        public string Output { get; set; } = string.Empty;

        public string BaseUrl { get; set; } = string.Empty;

        public void OnGet(string reportUrl)
        {
            BaseUrl = $"{Request.Scheme}://{Request.Host}{Request.PathBase}";

            if (string.IsNullOrEmpty(reportUrl))
            {
                return;
            }

            using var client = new HttpClient();
            using var response = client.GetAsync(reportUrl).Result;
            using var content = response.Content;
            Output = content.ReadAsStringAsync().Result;
        }
    }
}
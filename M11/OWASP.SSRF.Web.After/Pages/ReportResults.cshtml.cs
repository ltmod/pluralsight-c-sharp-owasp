using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OWASP.SSRF.Web.After.Pages
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
            if (string.IsNullOrEmpty(reportUrl))
            {
                return;
            }

            BaseUrl = $"{Request.Scheme}://{Request.Host}{Request.PathBase}";

            var list = new List<string>
            {
                $"{BaseUrl}/reports/sales.html",
                $"{BaseUrl}/reports/users.html"
            };

            var item = list.FirstOrDefault(x => x.Equals(reportUrl.ToLower()));
            if (item == null)
            {
                Output = "Bad Request";
                return;
            }

            using var client = new HttpClient();
            using var response = client.GetAsync(reportUrl).Result;
            using var content = response.Content;
            Output = content.ReadAsStringAsync().Result;
        }
    }
}
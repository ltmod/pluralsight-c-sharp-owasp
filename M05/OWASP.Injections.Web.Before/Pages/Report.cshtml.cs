using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OWASP.Injections.Web.Before.Pages
{
    public class ReportModel : PageModel
    {
        private readonly IConfiguration _config;

        public ReportModel(IConfiguration config)
        {
            _config = config;
        }

        public string Output { get; set; } = string.Empty;

        public void OnGet()
        {
        }

        public void OnPost(string reports)
        {
            var filePath = Directory.GetCurrentDirectory() + @"\ReportExe\OWASP.Injections.Report.exe";

            var externalProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/C " + filePath + " -" + reports,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            var output = "";
            externalProcess.Start();
            while (!externalProcess.StandardOutput.EndOfStream)
            {
                output += externalProcess.StandardOutput.ReadLine();
            }

            Output = output;
        }
    }
}
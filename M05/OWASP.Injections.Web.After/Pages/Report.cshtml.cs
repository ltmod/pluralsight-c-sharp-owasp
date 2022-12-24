using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OWASP.Injections.Web.After.Pages
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

        public void OnPost(int reports)
        {
            var filePath = Directory.GetCurrentDirectory() + @"\ReportExe\OWASP.Injections.Report.exe";

            var reportSwitch = "";

            switch (reports)
            {
                case 1:
                    reportSwitch = "sales";
                    break;
                case 2:
                    reportSwitch = "users";
                    break;
                case 3:
                    reportSwitch = "inventory";
                    break;
            }

            if (reportSwitch.Length == 0)
            {
                Output = "Bad request.";
                return;
            }

            var externalProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/C " + filePath + " -" + reportSwitch,
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
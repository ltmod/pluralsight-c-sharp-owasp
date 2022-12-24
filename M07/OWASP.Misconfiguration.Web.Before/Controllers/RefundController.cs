using Microsoft.AspNetCore.Mvc;
using OWASP.Misconfiguration.Web.Before.Repository;

namespace OWASP.Misconfiguration.Web.Before.Controllers
{
    public class RefundController : Controller
    {
        public IActionResult Index()
        {
            var refunds = new Refunds();

            return View(refunds);
        }

        [HttpPost]
        public IActionResult Index(decimal amount, string email)
        {
            var refunds = new Refunds();
            refunds.CurrentBalance -= amount;
            refunds.RefundList.Insert(0, new Refunds.Refund
            {
                RefundAmount = amount,
                Email = email
            });

            return View(refunds);
        }
    }
}
using System.Text;
using System.Xml;
using Microsoft.AspNetCore.Mvc;

namespace OWASP.Misconfiguration.Web.After.Controllers;

public class LoadProductController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(IFormFile fileUpload)
    {
        if (fileUpload.Length > 0)
        {
            using (var ms = new MemoryStream())
            {
                fileUpload.CopyTo(ms);
                var fileBytes = ms.ToArray();
                var xml = Encoding.UTF8.GetString(fileBytes, 0, fileBytes.Length);

                var xmlDoc = new XmlDocument
                {
                    XmlResolver = new CustomUrlResolver()
                };

                xmlDoc.LoadXml(xml);

                var productList = xmlDoc.SelectNodes("products");
                var data = "";
                ViewBag.Data = "";

                foreach (XmlNode productNode in productList)
                {
                    var products = productNode.SelectNodes("product");
                    foreach (XmlNode product in products)
                    {
                        if (product != null)
                        {
                            data += "Id: " + product.Attributes["id"].Value + "<br>";
                            data += "Title: " + product["title"].InnerText + "<br>";
                            data += "Desc: " + product["description"].InnerText + "<br>";
                            data += "Picture: " + product["picture"].InnerText + "<br>";
                            data += "Price: " + product["price"].InnerText + "<br>";
                            data += "<hr>";
                        }
                    }
                }

                ViewBag.Data = data;
            }
        }

        return View();
    }

    internal class CustomUrlResolver: XmlUrlResolver
    {
        public override Uri ResolveUri(Uri? baseUri, string? relativeUri)
        {
            var uri = new Uri(relativeUri);

            return !uri.LocalPath.ToUpper().StartsWith("C:\\MARKETING") ?
                new Uri("file://c:/marketing/notfound.txt") : base.ResolveUri(baseUri, relativeUri);
        }
    }
}
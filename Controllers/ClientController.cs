using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace BakerApp.Controllers
{
    public class ClientController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}
using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            HelloViewModel helloC = new HelloViewModel() {Name = "Alpha", Age = 220 };
            return View(helloC);
        }
    }
}

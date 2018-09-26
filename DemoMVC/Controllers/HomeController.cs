using DemoMVC.filters;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    [CustomAuthentication]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }        
    }
}
using MVCPartialView.Models;
using System.Web.Mvc;

namespace MVCPartialView.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var employee = new Employee();
            employee.Personal = new EmployeePersonal();
            return View(employee);
        }

        [HttpPost]
        public ActionResult Summary(Employee employee)
        {
            return View(employee);
        }
    }
}
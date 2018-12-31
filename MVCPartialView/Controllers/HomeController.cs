using MVCPartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPartialView.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var employee = new Employee();
            return View(employee);
        }

        public PartialViewResult PersonalDetails(EmployeePersonal employeePersonal)
        {
            return PartialView("_personal", employeePersonal);
        }

        public PartialViewResult AddressDetails(EmployeeAddress employeeAddress)
        {
            return PartialView("_address", employeeAddress);
        }

        public PartialViewResult CompanyDetails(EmployeeCompany employeeCompany)
        {
            return PartialView("_company", employeeCompany);
        }

        public ActionResult Summary(Employee employee)        {
            
            return View(employee);
        }
    }
}
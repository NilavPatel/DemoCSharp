using PerformaceTestEF.Data;
using PerformaceTestEF.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace PerformaceTestEF.Controllers
{
    [RoutePrefix("api/Employees")]
    public class EmployeesController : ApiController
    {
        [HttpGet]
        [Route("GetEmployees")]
        public IEnumerable<EmployeeViewModel> GetEmployees()
        {
            using (var db = new DemoEntities())
            {
                var employees = db.Employees.ToList().Select(e => new EmployeeViewModel
                {
                    Address = e.Address,
                    DepartmentID = e.DepartmentID,
                    DepartmentName = e.Department.Name,
                    EmployeeID = e.EmployeeID,
                    Name = e.Name
                }).ToList();
                return employees;
            }
        }

        [HttpGet]
        [Route("InsertEmployees/{number}")]
        public bool InsertEmployees(int number)
        {
            using (var db = new DemoEntities())
            {
                for (var i = 1; i <= number; i++)
                {
                    var employee = new Employee
                    {
                        Address = "test address",
                        DepartmentID = 1,
                        Name = "nilav" + i
                    };
                    db.Employees.Add(employee);
                }
                return db.SaveChanges() > 0;
            }
        }
    }
}
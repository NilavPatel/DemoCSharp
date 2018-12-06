using DemoWCF.Abstract;
using System.Collections.Generic;
using System.Linq;
using DemoWCF.Models;
using DemoWCF.Data;

namespace DemoWCF.Concrete
{
    public class EmployeeService : IEmployeeService
    {
        /// <summary>
        /// Get all Employee details
        /// </summary>
        /// <returns></returns>
        public IEnumerable<EmployeeDTO> GetEmployees()
        {
            using (var db = new DemoEntities())
            {
                var employees = db.Employees.AsNoTracking().Select(e => new EmployeeDTO
                {
                    Address = e.Address,
                    Department = e.Department.Name,
                    DepartmentID = e.DepartmentID,
                    EmployeeID = e.EmployeeID,
                    Name = e.Name
                }).ToList();
                return employees;
            }
        }

        /// <summary>
        /// Get Employee details by Employee id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public EmployeeDTO GetEmployeeById(long id)
        {
            using (var db = new DemoEntities())
            {
                var employee = db.Employees.AsNoTracking()
                    .Where(e => e.EmployeeID == id)
                    .Select(e => new EmployeeDTO
                    {
                        Address = e.Address,
                        Department = e.Department.Name,
                        DepartmentID = e.DepartmentID,
                        EmployeeID = e.EmployeeID,
                        Name = e.Name
                    }).FirstOrDefault();
                return employee;
            }
        }

        /// <summary>
        /// Insert new Employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>employee id</returns>
        public long InsertEmployee(EmployeeDTO employee)
        {
            using (var db = new DemoEntities())
            {
                var emp = new Employee()
                {
                    Address = employee.Address,
                    DepartmentID = employee.DepartmentID,
                    Name = employee.Name
                };
                // returns inserted data object
                var insertedData = db.Employees.Add(emp);
                // employee id will be generated after data save in DB.
                db.SaveChanges();
                return insertedData.EmployeeID;
            }
        }

        /// <summary>
        /// Update Employee details
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public bool UpdateEmployee(EmployeeDTO employee)
        {
            using (var db = new DemoEntities())
            {
                var existingEmployee = db.Employees.Find(employee.EmployeeID);
                if (employee == null)
                {
                    return true;
                }
                existingEmployee.Address = employee.Address;
                existingEmployee.DepartmentID = employee.DepartmentID;
                existingEmployee.Name = employee.Name;
                var result = db.SaveChanges();
                return result > 0;
            }
        }

        /// <summary>
        /// Delete Employee details
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteEmployee(long id)
        {
            using (var db = new DemoEntities())
            {
                var employee = db.Employees.Find(id);
                if (employee == null)
                {
                    return true;
                }
                db.Employees.Remove(employee);
                db.SaveChanges();
                return true;
            }
        }
    }
}
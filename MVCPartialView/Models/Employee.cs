using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPartialView.Models
{
    public class Employee
    {
        public Employee() {             
        }

        public EmployeePersonal Personal { get; set; }

        public EmployeeAddress Address { get; set; }

        public EmployeeCompany Company { get; set; }
    }
}
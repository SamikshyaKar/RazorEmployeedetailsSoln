using System;

namespace RazorEmployeedetails.Models
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }

        public string EmpEmail { get; set; }

        public string EmpPhoto { get; set; }
        public string EmpPlace { get; set; }

        public EmpDepartment? EmpDeprt { get; set; }
    }
}

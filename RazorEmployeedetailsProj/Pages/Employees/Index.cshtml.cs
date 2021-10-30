using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorEmployeedetails.Models;
using RazorEmployeedetails.Services;

namespace RazorEmployeedetailsProj.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly IEmpDetailRepo empDetailRepo;

        public IndexModel(IEmpDetailRepo empDetailRepo)
        {
            this.empDetailRepo = empDetailRepo;
        }

        public IEnumerable<Employee> EmpIndexprt { get; private set; }

        public void OnGet()
        {
            EmpIndexprt = empDetailRepo.GetallEmployeedetails();
        }
    }
}

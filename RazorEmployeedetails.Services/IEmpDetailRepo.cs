using RazorEmployeedetails.Models;
using System;
using System.Collections.Generic;

namespace RazorEmployeedetails.Services
{
    public interface IEmpDetailRepo
    {
        IEnumerable<Employee> GetallEmployeedetails();

    }
}

using RazorEmployeedetails.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorEmployeedetails.Services
{
    public class IEmpDetailRepoImplnt : IEmpDetailRepo
    {

        private List<Employee> _employeelist;

        public IEmpDetailRepoImplnt()
        {
            _employeelist = new List<Employee>()
            {
                new Employee() {EmpID=1,EmpName="Samu",EmpDeprt=EmpDepartment.IT,EmpPlace="BLR",EmpEmail="samu@gmail.com",EmpPhoto="red.jpg"},
                 new Employee() {EmpID=1,EmpName="Dhamu",EmpDeprt=EmpDepartment.IT,EmpPlace="BLR",EmpEmail="dhamu@gmail.com",EmpPhoto="blue.jpg"},
                  new Employee() {EmpID=1,EmpName="Amu",EmpDeprt=EmpDepartment.IT,EmpPlace="BLR",EmpEmail="Amu@gmail.com",EmpPhoto="multi.jpg"},
                   new Employee() {EmpID=1,EmpName="Ramu",EmpDeprt=EmpDepartment.IT,EmpPlace="BLR",EmpEmail="Ramu@gmail.com",EmpPhoto="beauty.jpg"}

            };
        }
        
        
        
        
        
        private readonly IEmpDetailRepo empDetailRepo;

        public IEmpDetailRepoImplnt(IEmpDetailRepo empDetailRepo)
        {
            this.empDetailRepo = empDetailRepo;
        }
        public IEnumerable<Employee> GetallEmployeedetails()
        {
            return _employeelist;
        }
    }
}

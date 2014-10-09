using Repository.Abstract;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class EmployeeController : Controller
    {
        IGenericRepository<Employee> repository;
        public EmployeeController(IGenericRepository<Employee> employeeRepos)
        {
            this.repository = employeeRepos;
        }
        // GET: Employee
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }

        //public PartialViewResult GetPeopleData(string selectedRole = "All")
        //{
        //    IEnumerable<Employee> data = employeeData;
        //    if (selectedRole != "All")
        //    {
        //        Role selected = (Role)Enum.Parse(typeof(Role), selectedRole);
        //        data = personData.Where(p => p.Role == selected);
        //    }
        //    return PartialView(data);
        //}

        //public ActionResult GetPeople(string selectedRole = "All")
        //{
        //    return View((object)selectedRole);
        //}
    }
}
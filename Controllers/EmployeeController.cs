using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly MVC_DBEntities1 _dbContext;
        // GET: Employee

        public EmployeeController()
        {
            _dbContext = new MVC_DBEntities1();
        }
        public ActionResult Index(int departmentId)
        {

            List<Employee>listEmployee=_dbContext .Employees.Where(e=>e.DepartmentId == departmentId).ToList();
            return View(listEmployee);
        }
        public ActionResult Details(int id) {    
         Employee employee=_dbContext.Employees.Where(e=>e.EmployeeId==id).FirstOrDefault();
         return View(employee);
        }
    }
}
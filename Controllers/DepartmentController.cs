using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly MVC_DBEntities1 _dbContext;
         public DepartmentController()
        {
            _dbContext = new MVC_DBEntities1();
        }

        // GET: Department
        public ActionResult Index()
        {
            List<Department> listDepartment=_dbContext.Departments.ToList();
            return View(listDepartment);
        }
    }
}
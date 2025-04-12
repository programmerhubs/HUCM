using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HUCM_App.Models;
using HUCM_App.Repositry;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HUCM_App.Controllers
{
    public class DesignationController : Controller
    {
        private readonly IRoleRepositry roleRepositry;
        public DesignationController(IRoleRepositry role)
        {
            roleRepositry = role;
        }
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            ViewData["Title"] = "Designation Manager";

            var result =await roleRepositry.GetRoleAsync();
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> AddNew(string name)
        {
            EmpRole role = new EmpRole()
            {
                RoleName = name
            };
            int msg = await roleRepositry.AddRoleAsync(role);
           return RedirectToAction("Index");
        }
    }
}


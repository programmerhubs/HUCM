using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HUCM_App.Models;
using HUCM_App.Repositry;
using Microsoft.AspNetCore.Mvc;
namespace HUCM_App.Controllers
{
    public class DesignationController : Controller
    {
        private readonly IRoleRepositry roleRepositry;
        public DesignationController(IRoleRepositry role)
        {
            roleRepositry = role;
        }
        public async Task<IActionResult> Index()
        {
            ViewData["Title"] = "Designation Manager";

            var result = await roleRepositry.GetRoleAsync();
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> AddNew(string name)
        {
            EmpRole role = new EmpRole()
            {
                RoleName = name,
                IsActive=true
            };
            int msg = await roleRepositry.AddRoleAsync(role);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int roleid, string name)
        {
            EmpRole role = new EmpRole()
            {
                RoleName = name
            };
          int msg=await  roleRepositry.UpdateRoleAsync(role, roleid);
            return RedirectToAction("Index");

        }
        [HttpPost]
        public async Task<IActionResult> Delete(int RoleId)
        {
            int msg = await roleRepositry.DeleteRoleAsync(RoleId);
            return RedirectToAction("Index");
        }
    }
}
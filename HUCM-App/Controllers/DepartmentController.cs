using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HUCM_App.Models;
using HUCM_App.Repositry;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HUCM_App.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepositry _repo;
        public DepartmentController(IDepartmentRepositry departmentRepositry)
        {
            this._repo = departmentRepositry;
        }
        public async  Task<IActionResult> Index()
        {
            ViewData["Title"] = "Department Manager";
            var result=await  _repo.GetDepartmentAsync();
            messageset();
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> AddDepartment(string DepartmentName)
        {
            Department department = new Department()
            {
                DepartmentName = DepartmentName,
                CreatedDate=DateTime.Today.ToString(),
            };
            int result = await _repo.AddDepartmentAsync(department);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> EditDepartment(string DepartmentName,int id)
        {
            Department department = new Department()
            {
                DepartmentName = DepartmentName,
                CreatedDate = DateTime.Today.ToString(),
            };
            int result = await _repo.UpdateDepartmentAsync(department,id);
            if(result==1)
            {
                TempData["Success"] = "Department Updated Successfully";
            }
            else
            {
                TempData["Error"] = "Due to Some Technical Issue or may be data is not correct format";
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            int msg = await _repo.DeleteDepartmentAsync(id);
            TempData["Success"] = "Department Deleted Successfully";
            return RedirectToAction("Index");
        }
        private void messageset()
        {
            if (TempData["Success"] == null || string.IsNullOrEmpty(TempData["Success"].ToString()))
            {
                TempData["Success"] = "Data Loaded Successfully";
            }
        }
    }
}


using System;
using HUCM_App.DbContextfile;
using HUCM_App.Models;
using HUCM_App.Repositry;
using Microsoft.EntityFrameworkCore;

namespace HUCM_App.Services
{
	public class DepartmentService: IDepartmentRepositry
	{
		private ApplicationDbContext _db;
		public DepartmentService( ApplicationDbContext dbContext)
		{
			_db = dbContext;
		}

        public async  Task<int> AddDepartmentAsync(Department department)
        {
            
            int retval = 0;
            try
            {
                var IsExist = _db.Departmentstbl.Any(x => x.DepartmentName == department.DepartmentName && x.IsActive == true);
                if(!IsExist)
                {
                    department.IsActive = true;
                    department.CreatedDate = DateTime.Now.ToString();
                   await _db.Departmentstbl.AddAsync(department);
                   await  _db.SaveChangesAsync();
                    retval = 1;
                }
               

            }
            catch(Exception ex)
            {
                retval = -1;
            }
            return retval;
        }

        public async Task<int> DeleteDepartmentAsync(int DepartId)
        {
            int retval = 0;
            try
            {
                var IsExist = _db.Departmentstbl.Any(x => x.DeptId == DepartId && x.IsActive == true);
                if (IsExist)
                {
                    var Deaprtments = _db.Departmentstbl.First(x => x.DeptId == DepartId && x.IsActive == true);

                    Deaprtments.IsActive = false;
                    Deaprtments.IsDeleted = true;
                    Deaprtments.ModifiedDate = DateTime.Today.ToString();
                    await _db.SaveChangesAsync();
                    retval = 1;
                }


            }
            catch (Exception ex)
            {
                retval = -1;
            }
            return retval;
        }

        public async Task<IEnumerable<Department>> GetDepartmentAsync()
        {
            try
            {
                return await _db.Departmentstbl.Where(x=>x.IsActive==true).OrderBy(x=>x.CreatedDate).ToListAsync();
            }
            catch (Exception ex)
            {
               
                return Enumerable.Empty<Department>();
            }
        }

        public async Task<Department> GetDepartmentByIdAsync(int departId)
        {
            try
            {
                return await _db.Departmentstbl.FirstOrDefaultAsync(x => x.DeptId == departId);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<int> UpdateDepartmentAsync(Department department, int DepartId)
        {
            int retval = 0;
            try
            {
                var IsExist = _db.Departmentstbl.Any(x => x.DeptId == DepartId && x.IsActive == true);
                if (IsExist)
                {
                    var Deaprtments = _db.Departmentstbl.First(x => x.DeptId == DepartId && x.IsActive == true);

                    
                    Deaprtments.ModifiedDate = DateTime.Today.ToString();
                    Deaprtments.ModifiedBy = department.ModifiedBy;
                    Deaprtments.DepartmentName = department.DepartmentName;
                   
                    await _db.SaveChangesAsync();
                    retval = 1;
                }


            }
            catch (Exception ex)
            {
                retval = -1;
            }
            return retval;
        }
    }
}


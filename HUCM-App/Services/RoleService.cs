using System;
using HUCM_App.DbContextfile;
using HUCM_App.Models;
using HUCM_App.Repositry;
using Microsoft.EntityFrameworkCore;

namespace HUCM_App.Services
{
	public class RoleService :IRoleRepositry
	{
		private readonly ApplicationDbContext _db;
		public RoleService(ApplicationDbContext db)
		{
			_db = db;
		}

        public async Task<int> AddRoleAsync(EmpRole role)
        {
            int retval = 0;
            try
            {
                var IsExist = _db.EmpRolesTbl.Any(x => x.RoleName == role.RoleName && x.IsActive == true);
                if (!IsExist)
                {
                    await _db.EmpRolesTbl.AddAsync(role);
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

        public async Task<int> DeleteRoleAsync(int roleId)
        {
            int retval = 0;
            try
            {
                var IsExist = _db.EmpRolesTbl.Any(x => x.RoleId == roleId && x.IsActive == true);
                if (IsExist)
                {
                    var Deaprtments = _db.EmpRolesTbl.First(x => x.RoleId == roleId && x.IsActive == true);

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

        public async Task<IEnumerable<EmpRole>> GetRoleAsync()
        {
            try
            {
                return await _db.EmpRolesTbl.ToListAsync();
            }
            catch
            {
                return Enumerable.Empty<EmpRole>();
            }
        }

        public async Task<EmpRole> GetRoleByIdAsync(int roleId)
        {
            try
            {
                return await _db.EmpRolesTbl.FirstOrDefaultAsync(x => x.RoleId == roleId);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> UpdateRoleAsync(EmpRole empRole, int roleId)
        {
            int retval = 0;
            try
            {
                var IsExist = _db.EmpRolesTbl.Any(x => x.RoleId == roleId && x.IsActive == true);
                if (IsExist)
                {
                    var Deaprtments = _db.EmpRolesTbl.First(x => x.RoleId == roleId && x.IsActive == true);


                    Deaprtments.ModifiedDate = DateTime.Today.ToString();
                    Deaprtments.RoleName = empRole.RoleName;
                    Deaprtments.ModifiedBy = empRole.ModifiedBy;
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


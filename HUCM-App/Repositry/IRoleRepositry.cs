using System;
using HUCM_App.Models;

namespace HUCM_App.Repositry
{
	public interface IRoleRepositry
	{
        Task<int> AddRoleAsync(EmpRole role);
        Task<int> DeleteRoleAsync(int roleId);
        Task<int> UpdateRoleAsync(EmpRole empRole, int roleId);
        Task<IEnumerable<EmpRole>> GetRoleAsync();
        Task<EmpRole> GetRoleByIdAsync(int roleId);
    }
}


using System;
using HUCM_App.Models;

namespace HUCM_App.Repositry
{
	public interface IDepartmentRepositry
	{
		Task<int> AddDepartmentAsync(Department department);
		Task<int> DeleteDepartmentAsync(int DepartId);
		Task<int> UpdateDepartmentAsync(Department department,int DepartId);
		Task<IEnumerable<Department>> GetDepartmentAsync();
        Task<Department> GetDepartmentByIdAsync(int departId);

    }
}


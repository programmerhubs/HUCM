using System;
using HUCM_App.Models;

namespace HUCM_App.Repositry
{
	public interface IEmployeeRespository
	{
		Task<int> NewEmployeeAsync(Employee employee);
		Task<int> UpdateAsync(Employee employee,int EmployeeId);
		Task<int> DeleteAsync(int EmployeeId);
		Task<IEnumerable<Employee>> GetAllEmployeeAsync();
		Task<Employee> GetEmployeebyIdAsync(int EmployeeId);
	}
}


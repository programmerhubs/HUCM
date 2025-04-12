using System;
using HUCM_App.DbContextfile;
using HUCM_App.Models;
using HUCM_App.Repositry;
using Microsoft.EntityFrameworkCore;

namespace HUCM_App.Services
{
	public class EmployeeService:IEmployeeRespository
	{
        private readonly ApplicationDbContext _db;
		public EmployeeService(ApplicationDbContext db)
		{
            this._db = db;
		}

        public async Task<int> DeleteAsync(int EmployeeId)
        {
            int retval = 0;
            try
            {
                var IsExist = _db.Employeestbl.Any(x => x.EmployeeId == EmployeeId && x.IsActive == true);
                if (IsExist)
                {
                    var employee = _db.Employeestbl.First(x => x.EmployeeId == EmployeeId && x.IsActive == true);

                    employee.IsActive = false;
                    employee.IsDeleted = true;
                    employee.ModifiedDate = DateTime.Today.ToString();
                    await _db.SaveChangesAsync();
                    retval = 1;
                }
            }
            catch(Exception ex)
            {

            }
            return retval;
            }
        public async Task<IEnumerable<Employee>> GetAllEmployeeAsync()
        {
            try
            {
                return await _db.Employeestbl.ToListAsync();
            }
            catch
            {
                return Enumerable.Empty<Employee>();
            }
        }

        public async Task<Employee> GetEmployeebyIdAsync(int EmployeeId)
        {
            try
            {
                return await _db.Employeestbl.FirstOrDefaultAsync(x=>x.EmployeeId==EmployeeId);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> NewEmployeeAsync(Employee employee)
        {
            int retval = 0;
            try
            {
                Employee data = new Employee()
                {
                    DepartId = employee.DepartId,
                    RoleId = employee.RoleId,
                    CompanyMail = employee.CompanyMail,
                    Name = employee.Name,
                    DOJ = employee.DOJ,
                    Exp=employee.Exp,
                    EmployeeStatus=empStatus.Active,
                    PrimaryContact=employee.PrimaryContact,
                    PrimaryEmail=employee.PrimaryEmail,
                    SecondaryContact=employee.SecondaryContact,
                    Skills=employee.Skills,
                    EmpUserName = employee.CompanyMail.Split("@")[0].ToString(),
                    Manager=employee.Manager

                };
                _db.Employeestbl.Add(data);
                 await _db.SaveChangesAsync();
                retval = 1;
                
            }
            catch (Exception ex)
            {

            }
            return retval;
        }

        public Task<int> UpdateAsync(Employee employee, int EmployeeId)
        {
            throw new NotImplementedException();
        }
    }
}


using System;
using System.Data;
using HUCM_App.DbContextfile;
using HUCM_App.Models;
using HUCM_App.Repositry;
using Microsoft.EntityFrameworkCore;

namespace HUCM_App.Services
{
	public class SkillService: ISkillRepositry
	{
        private readonly ApplicationDbContext _db;
		public SkillService(ApplicationDbContext db)
		{
            _db = db;
		}

        public async Task<int> AddSkillAsync(Skill skill)
        {
            int retval = 0;
            try
            {
                var IsExist = _db.SkillsTbl.Any(x => x.Name == skill.Name && x.IsActive == true);
                if (!IsExist)
                {
                    await _db.SkillsTbl.AddAsync(skill);
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

        public async Task<int> DeleteSkillAsync(int SkillId)
        {
            int retval = 0;
            try
            {
                var IsExist = _db.SkillsTbl.Any(x => x.SkillId == SkillId && x.IsActive == true);
                if (IsExist)
                {
                    var Deaprtments = _db.SkillsTbl.First(x => x.SkillId == SkillId && x.IsActive == true);

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

        public  async Task<IEnumerable<Skill>> GetSkillAsync()
        {
            try
            {
                return await _db.SkillsTbl.ToListAsync();
            }
            catch
            {
                return Enumerable.Empty<Skill>();
            }
        }

        public async Task<Skill> GetSkillByIdAsync(int SkillId)
        {
            try
            {
                return await _db.SkillsTbl.FirstOrDefaultAsync(x => x.SkillId == SkillId);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> UpdateSkillAsync(Skill empSkill, int SkillId)
        {
            int retval = 0;
            try
            {
                var IsExist = _db.SkillsTbl.Any(x => x.SkillId == SkillId && x.IsActive == true);
                if (IsExist)
                {
                    var Deaprtments = _db.SkillsTbl.First(x => x.SkillId == SkillId && x.IsActive == true);


                    Deaprtments.ModifiedDate = DateTime.Today.ToString();
                    Deaprtments.Name = empSkill.Name;
                    Deaprtments.ModifiedBy = empSkill.ModifiedBy;
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


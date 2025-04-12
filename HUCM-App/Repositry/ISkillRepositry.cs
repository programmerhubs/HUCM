using System;
using HUCM_App.Models;

namespace HUCM_App.Repositry
{
	public interface ISkillRepositry
	{
        Task<int> AddSkillAsync(Skill Skill);
        Task<int> DeleteSkillAsync(int SkillId);
        Task<int> UpdateSkillAsync(Skill empSkill, int SkillId);
        Task<IEnumerable<Skill>> GetSkillAsync();
        Task<Skill> GetSkillByIdAsync(int SkillId);
    }
}


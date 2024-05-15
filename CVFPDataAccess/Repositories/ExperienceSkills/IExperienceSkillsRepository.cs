using CVFPDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Repositories.ExperienceSkills
{
    public interface IExperienceSkillsRepository
    {
        public ICollection<ExperienceSkill> GetExperienceSkillsByUserIdCandidate(int userId);
    }
}

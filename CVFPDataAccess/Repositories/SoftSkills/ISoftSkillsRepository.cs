using CVFPDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Repositories.SoftSkills
{
    public interface ISoftSkillsRepository
    {
        public Task<ICollection<SoftSkill>> GetSoftSkillsByUserIdCandidate(int userId);
    }
}

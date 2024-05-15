using CVFPDataAccess.Data;
using CVFPDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Repositories.ExperienceSkills
{
    public class ExperienceSkillsRepository : IExperienceSkillsRepository
    {
        private readonly CVContext _context;

        public ExperienceSkillsRepository(CVContext cVContext)
        {
            _context = cVContext;
        }

        public ICollection<ExperienceSkill> GetExperienceSkillsByUserIdCandidate(int userId)
        {
            return _context.ExperienceSkills
                .Where(acss => acss.Experience.CandidateId == userId)
                .ToList();
        }
    }
}

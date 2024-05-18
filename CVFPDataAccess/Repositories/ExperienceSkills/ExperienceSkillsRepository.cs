using CVFPDataAccess.Data;
using CVFPDataAccess.Models;
using Microsoft.EntityFrameworkCore;
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

        public async Task<ICollection<ExperienceSkill>> GetExperienceSkillsByCandidateIdAsync(int candidateId)
        {
            return await _context.ExperienceSkills
                .Where(acss => acss.Experience.CandidateId == candidateId)
                .ToListAsync();
        }
    }
}

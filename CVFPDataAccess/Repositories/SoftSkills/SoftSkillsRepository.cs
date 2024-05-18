using CVFPDataAccess.Data;
using CVFPDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Repositories.SoftSkills
{
    public class SoftSkillsRepository : ISoftSkillsRepository
    {
        private readonly CVContext _context;

        public SoftSkillsRepository(CVContext cVContext)
        {
            _context = cVContext;
        }

        public async Task<ICollection<SoftSkill>> GetSoftSkillsByCandidateIdAsync(int candidateId)
        {
            return await _context.AssociationCandidatesSoftSkills
                .Where(acss => acss.CandidateId == candidateId)
                .Include(chs => chs.SoftSkill)
                .ThenInclude(hs => hs.AssociationCandidateSoftSkills)
                .Select(ss => ss.SoftSkill).ToListAsync();
        }
    }
}

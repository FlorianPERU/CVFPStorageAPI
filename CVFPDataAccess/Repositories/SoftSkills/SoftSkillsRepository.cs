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

        public ICollection<SoftSkill> GetSoftSkillsByUserIdCandidate(int userId)
        {
            return _context.AssociationCandidatesSoftSkills
                .Where(acss => acss.CandidateId == userId)
                .Include(chs => chs.SoftSkill)
                .ThenInclude(hs => hs.AssociationCandidateSoftSkills)
                .Select(ss => ss.SoftSkill).ToList();
        }
    }
}

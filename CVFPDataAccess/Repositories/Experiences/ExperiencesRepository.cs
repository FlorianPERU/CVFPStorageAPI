using CVFPDataAccess.Data;
using CVFPDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Repositories.Experiences
{
    public class ExperiencesRepository : IExperiencesRepository
    {
        private readonly CVContext _context;

        public ExperiencesRepository(CVContext cVContext)
        {
            _context = cVContext;
        }

        public ICollection<Experience> GetExperiencesByUserIdCandidate(int userId)
        {
            return _context.Experiences
                .Where(e => e.CandidateId == userId && e.ParentExperienceId == null)//get tree experiences
                .Include(e => e.SubExperiences)
                .Include(e => e.Job)
                .Include(e => e.ContractType)
                .ToList();
        }
    }
}

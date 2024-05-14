using CVFPDataAccess.Data;
using CVFPDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Repositories.Hobbies
{
    public class HobbiesRepository : IHobbiesRepository
    {
        private readonly CVContext _context;

        public HobbiesRepository(CVContext cVContext)
        {
            _context = cVContext;
        }

        public ICollection<Hobbie> GetHobbiesByUserIdCandidate(int userId)
        {
            return _context.AssociationCandidateHobbies
                .Where(ach => ach.CandidateId == userId)
                .Include(chs => chs.Hobbie)
                .ThenInclude(hs => hs.AssociationCandidateHobbies)
                .Select(ach => ach.Hobbie)
                .ToList();
        }
    }
}

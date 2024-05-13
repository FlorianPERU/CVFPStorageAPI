using CVFPDataAccess.Data;
using CVFPDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Repositories.Formations
{
    public class FormationsRepository : IFormationsRepository
    {
        private readonly CVContext _context;

        public FormationsRepository(CVContext cVContext)
        {
            _context = cVContext;
        }

        public ICollection<Formation> GetFormationsByUserIdCandidate(int userId)
        {
            return _context.Formations.Where(c => c.CandidateId == userId).ToList();
        }
    }
}

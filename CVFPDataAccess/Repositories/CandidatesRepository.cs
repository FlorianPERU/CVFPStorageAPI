using CVFPDataAccess.Data;
using CVFPDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Repositories
{
    public class CandidatesRepository : ICandidatesRepository
    {
        private readonly CVContext _context;

        public CandidatesRepository(CVContext cVContext) 
        {
            _context = cVContext;
        }

        public Candidate GetFirstCandidate()
        {
            return _context.Candidates.First();
        }
    }
}

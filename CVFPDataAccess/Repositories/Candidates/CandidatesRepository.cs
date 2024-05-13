using CVFPDataAccess.Data;
using CVFPDataAccess.Models;

namespace CVFPDataAccess.Repositories.Candidates
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

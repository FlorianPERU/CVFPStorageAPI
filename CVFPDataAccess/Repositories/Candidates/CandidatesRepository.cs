using CVFPDataAccess.Data;
using CVFPDataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace CVFPDataAccess.Repositories.Candidates
{
    public class CandidatesRepository : ICandidatesRepository
    {
        private readonly CVContext _context;

        public CandidatesRepository(CVContext cVContext)
        {
            _context = cVContext;
        }

        public async Task<Candidate> GetFirstCandidateAsync()
        {
            return await _context.Candidates.FirstAsync();
        }
    }
}

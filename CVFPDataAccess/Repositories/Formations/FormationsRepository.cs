using CVFPDataAccess.Data;
using CVFPDataAccess.Models;
using Microsoft.EntityFrameworkCore;
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

        public async Task<ICollection<Formation>> GetFormationsByCandidateIdAsync(int candidateId)
        {
            return await _context.Formations.Where(c => c.CandidateId == candidateId).ToListAsync();
        }
    }
}

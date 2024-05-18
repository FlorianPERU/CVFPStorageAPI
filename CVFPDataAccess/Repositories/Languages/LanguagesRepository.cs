using CVFPDataAccess.Data;
using CVFPDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Repositories.Languages
{
    public class LanguagesRepository : ILanguagesRepository
    {
        private readonly CVContext _context;

        public LanguagesRepository(CVContext cVContext)
        {
            _context = cVContext;
        }

        public async Task<ICollection<Language>> GetLanguagesByCandidateIdAsync(int candidateId)
        {
            return await _context.AssociationCandidateLanguages
                .Where(ach => ach.CandidateId == candidateId)
                .Include(chs => chs.Language)
                .ThenInclude(hs => hs.AssociationCandidateLanguages)
                .Select(ach => ach.Language)
                .ToListAsync();
        }
    }
}

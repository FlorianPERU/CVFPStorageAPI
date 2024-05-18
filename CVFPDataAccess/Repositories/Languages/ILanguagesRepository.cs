using CVFPDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Repositories.Languages
{
    public interface ILanguagesRepository
    {
        public Task<ICollection<Language>> GetLanguagesByCandidateIdAsync(int candidateId);
    }
}

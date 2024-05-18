using CVFPDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Repositories.Experiences
{
    public interface IExperiencesRepository
    {
        public Task<ICollection<Experience>> GetExperiencesByCandidateIdAsync(int candidateId);
    }
}

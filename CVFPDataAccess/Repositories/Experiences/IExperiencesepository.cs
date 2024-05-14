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
        public ICollection<Experience> GetExperiencesByUserIdCandidate(int userId);
    }
}

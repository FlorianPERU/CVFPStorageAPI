using CVFPDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Repositories.Formations
{
    public interface IFormationsRepository
    {
        public Task<ICollection<Formation>> GetFormationsByUserIdCandidate(int userId);
    }
}

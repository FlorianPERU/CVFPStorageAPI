using CVFPDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Repositories.Certifications
{
    public interface ICertificationsRepository
    {
        public Task<ICollection<Certification>> GetCertificationsByUserIdCandidateAsync(int userId);
    }
}

using CVFPDataAccess.Data;
using CVFPDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Repositories.Certifications
{
    public class CertificationsRepository : ICertificationsRepository
    {
        private readonly CVContext _context;

        public CertificationsRepository(CVContext cVContext)
        {
            _context = cVContext;
        }

        public ICollection<Certification> GetCertificationsByUserIdCandidate(int userId)
        {
            return _context.Certifications.Where(c => c.CandidateId == userId).ToList();
        }
    }
}

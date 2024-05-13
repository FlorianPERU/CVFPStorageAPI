using CVFPDataAccess.Models;
using CVFPDataAccess.Repositories.Certifications;
using CVFPDataAccess.Repositories.Formations;
using CVFPServices.DTOs;
using CVFPServices.Extensions;
using CVFPServices.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.Services
{
    public class CertificationsFormationsService : ICertificationsFormationsService
    {

        private readonly IFormationsRepository _formationsRepository;
        private readonly ICertificationsRepository _certificationsRepository;

        public CertificationsFormationsService(IFormationsRepository formationsRepository, ICertificationsRepository certificationsRepository) 
        {
            _formationsRepository = formationsRepository;
            _certificationsRepository = certificationsRepository;
        }

        public CertificationsFormationsDTO GetCertificationsFormationsDTOByUserId(int userId)
        {
            return new CertificationsFormationsDTO()
            {
                CertificationDTOs = _certificationsRepository.GetCertificationsByUserIdCandidate(userId).Select(c => c.ToDTO()).ToList(),
                FormationDTOs = _formationsRepository.GetFormationsByUserIdCandidate(userId).Select(c => c.ToDTO()).ToList()
            };
        }
    }
}

using CVFPDataAccess.Models;
using CVFPDataAccess.Repositories.Certifications;
using CVFPDataAccess.Repositories.Formations;
using CVFPServices.DTOs;
using CVFPServices.Extensions;
using CVFPServices.Services.Interfaces;
using Microsoft.AspNetCore.Http.Features;
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

        public async Task<CertificationsFormationsDTO> GetCertificationsFormationsDTOByCandidateIdAsync(int candidateId)
        {
            var certifications = await _certificationsRepository.GetCertificationsByCandidateIdAsync(candidateId);
            var formations = await _formationsRepository.GetFormationsByCandidateIdAsync(candidateId);
            return new CertificationsFormationsDTO()
            {
                Certifications = certifications.Select(c => c.ToDTO()).ToList(),
                Formations = formations.Select(c => c.ToDTO()).ToList()
            };
        }
    }
}

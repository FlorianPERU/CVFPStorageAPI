using CVFPDataAccess.Models;
using CVFPDataAccess.Repositories;
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
    public class CandidatesService : ICandidatesService
    {

        private readonly ICandidatesRepository _candidatesRepository;
        public CandidatesService(ICandidatesRepository candidatesRepository) 
        {
            _candidatesRepository = candidatesRepository;
        }

        public CandidateDTO GetFirstCandidateDTO()
        {
            return _candidatesRepository.GetFirstCandidate().ToDTO();
        }
    }
}

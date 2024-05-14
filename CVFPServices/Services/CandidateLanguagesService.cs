using CVFPDataAccess.Models;
using CVFPDataAccess.Repositories.Languages;
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
    public class CandidateLanguagesService : ICandidateLanguagesService
    {

        private readonly ILanguagesRepository _languagesRepository;
        public CandidateLanguagesService(ILanguagesRepository languagesRepository) 
        {
            _languagesRepository = languagesRepository;
        }

        public ICollection<CandidateLanguagesDTO> GetLanguagesDTOByUserId(int userId)
        {
            return _languagesRepository.GetLanguagesByUserIdCandidate(userId).Select(l=> l.ToDTO(userId)).ToList();
        }
    }
}

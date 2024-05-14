using CVFPDataAccess.Models;
using CVFPDataAccess.Repositories.Experiences;
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
    public class ExperiencesService : IExperiencesService
    {

        private readonly IExperiencesRepository _ExperiencesRepository;
        public ExperiencesService(IExperiencesRepository ExperiencesRepository) 
        {
            _ExperiencesRepository = ExperiencesRepository;
        }

        public ICollection<ExperienceDTO> GetExperiencesDTOByUserIdCandidate(int userId)
        {
            return _ExperiencesRepository.GetExperiencesByUserIdCandidate(userId).Select(e => e.ToDTO()).ToList();
        }
    }
}

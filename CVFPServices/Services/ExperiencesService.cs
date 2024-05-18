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

        private readonly IExperiencesRepository _experiencesRepository;
        public ExperiencesService(IExperiencesRepository ExperiencesRepository) 
        {
            _experiencesRepository = ExperiencesRepository;
        }

        public async Task<ICollection<ExperienceDTO>> GetExperiencesDTOByUserIdCandidate(int userId)
        {
            var experiences = await _experiencesRepository.GetExperiencesByUserIdCandidate(userId);
            return experiences.Select(e => e.ToDTO()).ToList();
        }
    }
}

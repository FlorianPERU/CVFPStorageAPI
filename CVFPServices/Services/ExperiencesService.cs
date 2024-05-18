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
        public ExperiencesService(IExperiencesRepository experiencesRepository) 
        {
            _experiencesRepository = experiencesRepository;
        }

        public async Task<ICollection<ExperienceDTO>> GetExperiencesDTOByCandidateIdAsync(int candidateId)
        {
            var experiences = await _experiencesRepository.GetExperiencesByCandidateIdAsync(candidateId);
            return experiences.Select(e => e.ToDTO()).ToList();
        }
    }
}

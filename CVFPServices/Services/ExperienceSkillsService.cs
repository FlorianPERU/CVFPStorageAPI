using CVFPDataAccess.Models;
using CVFPDataAccess.Repositories.ExperienceSkills;
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
    public class ExperienceSkillsService : IExperienceSkillsService
    {

        private readonly IExperienceSkillsRepository _experienceSkillsRepository;
        public ExperienceSkillsService(IExperienceSkillsRepository experienceSkillsRepository) 
        {
            _experienceSkillsRepository = experienceSkillsRepository;
        }

        public async Task<ICollection<ExperienceSkillDTO>> GetExperienceSkillsDTOByCandidateIdAsync(int candidateId)
        {
            var experienceSkills = await _experienceSkillsRepository.GetExperienceSkillsByCandidateIdAsync(candidateId);
            return experienceSkills.Select(e => e.ToDTO()).ToList();
        }
    }
}

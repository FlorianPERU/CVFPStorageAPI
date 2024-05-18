using CVFPDataAccess.Models;
using CVFPDataAccess.Repositories.HardSkills;
using CVFPDataAccess.Repositories.SoftSkills;
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
    public class CandidateSkillsService : ICandidateSkillsService
    {


        private readonly ISoftSkillsRepository _softSkillsRepository;
        private readonly IHardSkillsRepository _hardSkillsRepository;

        public CandidateSkillsService(ISoftSkillsRepository softSkillsRepository, IHardSkillsRepository hardSkillsRepository)
        {
            _softSkillsRepository = softSkillsRepository;
            _hardSkillsRepository = hardSkillsRepository;
        }

        public async Task<CandidateSkillsDTO> GetCandidateSkillsDTOByUserIdAsync(int userId)
        {
            var softSkills = await _softSkillsRepository.GetSoftSkillsByUserIdCandidateAsync(userId);
            var hardSkills = await _hardSkillsRepository.GetHardSkillsByUserIdCandidateAsync(userId);
            return new CandidateSkillsDTO()
            {
                SoftSkills = softSkills.Select(c => c.ToDTO(userId)).ToList(),
                HardSkills = hardSkills.Select(c => c.ToDTO(userId)).ToList()
            };
        }
    }
}

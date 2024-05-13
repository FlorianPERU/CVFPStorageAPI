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

        public CandidateSkillsDTO GetCandidateSkillsDTOByUserId(int userId)
        {
            return new CandidateSkillsDTO()
            {
                SoftSkills = _softSkillsRepository.GetSoftSkillsByUserIdCandidate(userId).Select(c => c.ToDTO(userId)).ToList(),
                HardSkills = _hardSkillsRepository.GetHardSkillsByUserIdCandidate(userId).Select(c => c.ToDTO(userId)).ToList()
            };
        }
    }
}

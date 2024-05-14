using CVFPDataAccess.Models;
using CVFPServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.Extensions
{
    public static class ExperienceExtensions
    {
        public static ExperienceDTO ToDTO(this Experience experience)
        {
            return new ExperienceDTO
            {
                Id = experience.Id,
                CandidateId = experience.CandidateId,
                BeginDate = experience.BeginDate,
                EndDate = experience.EndDate,
                CompanyInfo = experience.CompanyInfo,
                CompanyName = experience.CompanyName,
                ContractType = experience.ContractType.ToDTO(),
                Job = experience.Job.ToDTO(),
                LinkedinLink = experience.LinkedinLink,
                SubExperiences = experience.SubExperiences?.Select(e => e.ToDTO()).ToList(),
                WorkCity = experience.WorkCity
            };
        }
    }
}
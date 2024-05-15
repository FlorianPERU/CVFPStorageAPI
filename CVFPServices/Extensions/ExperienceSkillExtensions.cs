using CVFPDataAccess.Models;
using CVFPServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.Extensions
{
    public static class ExperienceSkillExtensions
    {
        public static ExperienceSkillDTO ToDTO(this ExperienceSkill experienceSkill)
        {
            return new ExperienceSkillDTO
            {
                ExperienceId = experienceSkill.ExperienceId,
                Position = experienceSkill.Position,
                HardSkillId = experienceSkill.HardSkillId,
                SoftSkillId = experienceSkill.SoftSkillId
            };
        }
    }
}
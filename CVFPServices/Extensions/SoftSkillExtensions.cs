using CVFPDataAccess.Models;
using CVFPServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.Extensions
{
    public static class SoftSkillExtensions
    {
        public static SoftSkillDTO ToDTO(this SoftSkill softSkill, int userId)
        {
            AssociationCandidateSoftSkill associationCandidateSoftSkill = 
                softSkill.AssociationCandidateSoftSkills.First(acss => acss.CandidateId == userId && acss.SoftSkillId == softSkill.Id);
            return new SoftSkillDTO
            {
                Id = softSkill.Id,
                Name = softSkill.Name,
                LogoLink = softSkill.LogoLink,
                Position = associationCandidateSoftSkill.Position,
                SkillMasteryPercentage = associationCandidateSoftSkill.SkillMasteryPercentage
            };
        }
    }
}
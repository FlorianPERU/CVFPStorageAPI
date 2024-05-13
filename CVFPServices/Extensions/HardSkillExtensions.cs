using CVFPDataAccess.Models;
using CVFPServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.Extensions
{
    public static class HardSkillExtensions
    {
        public static HardSkillDTO ToDTO(this HardSkill hardSkill, int userId)
        {
            AssociationCandidateHardSkill associationCandidateHardSkill = 
                hardSkill.AssociationCandidateHardSkills.First(acss => acss.CandidateId == userId && acss.HardSkillId == hardSkill.Id);
            return new HardSkillDTO
            {
                Id = hardSkill.Id,
                Name = hardSkill.Name,
                LogoLink = hardSkill.LogoLink,
                Position = associationCandidateHardSkill.PositionHardSkill,
                HardSkillType = hardSkill.HardSkillType.ToDTO(associationCandidateHardSkill.PositionHardSkillType)
            };
        }
    }
}
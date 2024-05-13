using CVFPDataAccess.Models;
using CVFPServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.Extensions
{
    public static class HardSkillTypeExtensions
    {
        public static HardSkillTypeDTO ToDTO(this HardSkillType hardSkillType, int positionHardSkillType)
        {
            return new HardSkillTypeDTO
            {
                Id = hardSkillType.Id,
                Name = hardSkillType.Name,
                Position = positionHardSkillType
            };
        }
    }
}
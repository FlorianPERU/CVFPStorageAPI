using CVFPDataAccess.Models;
using CVFPServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.Extensions
{
    public static class FormationExtensions
    {
        public static FormationDTO ToDTO(this Formation formation)
        {
            return new FormationDTO
            {
                Id = formation.Id,
                Name = formation.Name,
                SchoolAddress = formation.SchoolAddress,
                SchoolName = formation.SchoolName,
                Position = formation.Position,
                BeginDate = formation.BeginDate,
                EndDate = formation.EndDate
            };
        }
    }
}
using CVFPDataAccess.Models;
using CVFPServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.Extensions
{
    public static class CertificationExtensions
    {
        public static CertificationDTO ToDTO(this Certification certification)
        {
            return new CertificationDTO
            {
                Id = certification.Id,
                Name = certification.Name,
                LogoLink = certification.LogoLink,
                Position = certification.Position,
                ObtentionDate = certification.ObtentionDate
            };
        }
    }
}
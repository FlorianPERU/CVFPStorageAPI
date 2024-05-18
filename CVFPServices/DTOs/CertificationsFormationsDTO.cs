using CVFPDataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.DTOs
{
    public class CertificationsFormationsDTO
    {
        public required List<CertificationDTO> Certifications { get; set; }
        public required List<FormationDTO> Formations { get; set; }
    }
}

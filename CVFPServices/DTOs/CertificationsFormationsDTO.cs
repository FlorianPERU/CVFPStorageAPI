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
        public CertificationsFormationsDTO()
        {
            Certifications = new List<CertificationDTO>();
            Formations = new List<FormationDTO>();
        }

        public List<CertificationDTO> Certifications { get; set; }
        public List<FormationDTO> Formations { get; set; }
    }
}

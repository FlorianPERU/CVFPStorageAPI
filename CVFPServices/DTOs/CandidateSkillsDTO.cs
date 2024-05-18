using CVFPDataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.DTOs
{
    public class CandidateSkillsDTO
    {
        public required List<SoftSkillDTO> SoftSkills { get; set; }
        public required List<HardSkillDTO> HardSkills { get; set; }
    }
}

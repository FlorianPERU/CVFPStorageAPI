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
        public CandidateSkillsDTO()
        {
            SoftSkills = new List<SoftSkillDTO>();
            HardSkills = new List<HardSkillDTO>();
        }

        public List<SoftSkillDTO> SoftSkills { get; set; }
        public List<HardSkillDTO> HardSkills { get; set; }
    }
}

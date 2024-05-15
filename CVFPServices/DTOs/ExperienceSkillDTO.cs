using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.DTOs
{
    public class ExperienceSkillDTO
    {
        public int ExperienceId { get; set; }
        public int Position { get; set; }
        public int? SoftSkillId { get; set; }
        public int? HardSkillId { get; set; }
    }
}

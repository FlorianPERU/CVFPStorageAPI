using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Models
{
    public class ExperienceSkill
    {
        [Required]
        public int Position { get; set; }
        public int? SoftSkillId { get; set; }
        public SoftSkill SoftSkill { get; set; }
        public int? HardSkillId { get; set; }
        public HardSkill HardSkill { get; set; }
        [Required]
        public int ExperienceId { get; set; }
        public Experience Experience { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Models
{
    public class HardSkill
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public required string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public required string LogoLink { get; set; }
        public int HardSkillTypeId { get; set; }
        public required HardSkillType HardSkillType { get; set; }
        public required virtual ICollection<AssociationCandidateHardSkill> AssociationCandidateHardSkills { get; set; }
        public required virtual ICollection<ExperienceSkill> ExperienceSkills { get; set; }
    }
}

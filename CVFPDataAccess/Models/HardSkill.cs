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
        public string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public string LogoLink { get; set; }
        public int HardSkillTypeId { get; set; }
        public HardSkillType HardSkillType { get; set; }
        public ICollection<AssociationCandidateHardSkill> AssociationCandidateHardSkills { get; set; }
    }
}

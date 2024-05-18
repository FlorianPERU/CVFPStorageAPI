using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Models
{
    public class SoftSkill
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public required string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public required string LogoLink { get; set; }
        public required virtual ICollection<AssociationCandidateSoftSkill> AssociationCandidateSoftSkills { get; set; }
        public required  virtual ICollection<ExperienceSkill> ExperienceSkills { get; set; }
    }
}

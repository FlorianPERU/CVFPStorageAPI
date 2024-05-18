using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Models
{
    public class AssociationCandidateSoftSkill
    {
        public int CandidateId { get; set; }
        public required virtual Candidate Candidate { get; set; }
        public int SoftSkillId { get; set; }
        public required SoftSkill SoftSkill { get; set; }
        [Required]
        [Range(0, 100)]
        public int SkillMasteryPercentage { get; set; }
        [Required]
        public int Position { get; set; }
    }
}

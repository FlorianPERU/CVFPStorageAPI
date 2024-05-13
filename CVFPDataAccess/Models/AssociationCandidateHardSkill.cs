using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Models
{
    public class AssociationCandidateHardSkill
    {
        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }
        public int HardSkillId { get; set; }
        public HardSkill HardSkill { get; set; }
        [Required]
        public int PositionHardSkill { get; set; }
        [Required]
        public int PositionHardSkillType { get; set; }
    }
}

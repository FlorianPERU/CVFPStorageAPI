using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Models
{
    public class AssociationCandidateHobbie
    {
        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }
        public int HobbieId { get; set; }
        public Hobbie Hobbie { get; set; }
        [Required]
        public int Position { get; set; }
    }
}

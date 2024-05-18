using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Models
{
    public class Certification
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public required string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public required string LogoLink { get; set; }
        [Required]
        public DateTime ObtentionDate { get; set; }
        [Required]
        public int Position { get; set; }
        public int CandidateId { get; set; }
        public virtual required Candidate Candidate { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Models
{
    public class Formation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string SchoolName { get; set; }
        [Required]
        [MaxLength(100)]
        public string SchoolAddress { get; set; }
        [Required]
        public DateTime BeginDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public int Position { get; set; }
        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }
    }
}

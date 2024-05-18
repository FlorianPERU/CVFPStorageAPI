using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Models
{
    public class AssociationCandidateLanguage
    {
        public int CandidateId { get; set; }
        public required virtual Candidate Candidate { get; set; }
        public int LanguageId { get; set; }
        public required Language Language { get; set; }
        [Required]
        public int Position { get; set; }
        [Required]
        public bool IsNative { get; set; }
        public string? Ref { get; set; }
    }
}

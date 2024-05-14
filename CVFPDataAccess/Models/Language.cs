using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Models
{
    public class Language
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(255)]
        public string? LogoLink { get; set; }
        public ICollection<AssociationCandidateLanguage> AssociationCandidateLanguages { get; set; }
    }
}

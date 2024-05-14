using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Models
{
    public class JobTask
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Task { get; set; }
        [Required]
        public int Position { get; set; }
        public int ExperienceId { get; set; }
        public Experience Experience { get; set; }
    }
}

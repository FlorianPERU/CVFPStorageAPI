﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public required string Name { get; set; }
        public required virtual ICollection<Experience> Experiences { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.DTOs
{
    public class SoftSkillDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string LogoLink { get; set; }
        public int SkillMasteryPercentage { get; set; }
        public int Position { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.DTOs
{
    public class CertificationDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string LogoLink { get; set; }
        public DateTime ObtentionDate { get; set; }
        public int Position { get; set; }
    }
}

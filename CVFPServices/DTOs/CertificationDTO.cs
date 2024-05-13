using CVFPDataAccess.Models;
using System;
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
        public string Name { get; set; }
        public string LogoLink { get; set; }
        public DateTime ObtentionDate { get; set; }
        public int Position { get; set; }
    }
}

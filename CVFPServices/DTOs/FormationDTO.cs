using CVFPDataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.DTOs
{
    public class FormationDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SchoolName { get; set; }
        public string SchoolAddress { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Position { get; set; }
    }
}

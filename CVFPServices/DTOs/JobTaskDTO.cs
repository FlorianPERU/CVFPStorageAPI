using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.DTOs
{
    public class JobTaskDTO
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public int Position { get; set; }
        public int ExperienceId { get; set; }
    }
}

using CVFPDataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.DTOs
{
    public class ExperienceDTO
    {
        public int Id { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string CompanyName { get; set; }
        public string WorkCity { get; set; }
        public string? CompanyInfo { get; set; }
        public string? LinkedinLink { get; set; }
        public ContractTypeDTO ContractType { get; set; }
        public JobDTO Job { get; set; }
        public ICollection<ExperienceDTO>? SubExperiences { get; set; }
        public int CandidateId { get; set; }
    }
}

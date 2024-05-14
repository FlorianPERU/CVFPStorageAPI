using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Models
{
    public class Experience
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        [Required]
        [MaxLength(50)]
        public string CompanyName { get; set; }
        [Required]
        [MaxLength(50)]
        public string WorkCity { get; set; }
        [MaxLength(255)]
        public string? CompanyInfo { get; set; }
        [MaxLength(255)]
        public string? LinkedinLink { get; set; }
        public int ContractTypeId { get; set; }
        public ContractType ContractType { get; set; }
        public int JobId { get; set; }
        public Job Job { get; set; }
        public int? ParentExperienceId { get; set; }
        public Experience ParentExperience { get; set; }
        public ICollection<Experience> SubExperiences { get; set; }
        public ICollection<JobTask> JobTasks { get; set; }
        public int CandidateId { get; set; }
        public virtual Candidate Candidate { get; set; }
    }
}

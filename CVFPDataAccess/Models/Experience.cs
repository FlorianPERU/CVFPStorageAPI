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
        public required string CompanyName { get; set; }
        [Required]
        [MaxLength(50)]
        public required string WorkCity { get; set; }
        [MaxLength(255)]
        public string? CompanyInfo { get; set; }
        [MaxLength(255)]
        public string? LinkedinLink { get; set; }
        public int ContractTypeId { get; set; }
        public required ContractType ContractType { get; set; }
        public int JobId { get; set; }
        public required Job Job { get; set; }
        public int? ParentExperienceId { get; set; }
        public virtual required Experience ParentExperience { get; set; }
        public virtual required ICollection<Experience> SubExperiences { get; set; }
        public virtual required ICollection<JobTask> JobTasks { get; set; }
        public virtual required ICollection<ExperienceSkill> ExperienceSkills { get; set; }
        public int CandidateId { get; set; }
        public virtual required Candidate Candidate { get; set; }
    }
}

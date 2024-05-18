using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Models
{
    public class Candidate
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public required string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public required string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [EnumDataType(typeof(DrivingLicenseTypeEnum))]
        public DrivingLicenseTypeEnum DrivingLicenseType { get; set; }
        [Required]
        public bool HasOwnVehicle { get; set; }
        [Required]
        [MaxLength(500)]
        public required string PresentationSentence { get; set; }
        [Required]
        [MaxLength(255)]
        public required string IdentityPhotoLink { get; set; }
        [Required]
        [MaxLength(255)]
        public required string LinkedinLink { get; set; }
        [Required]
        [MaxLength(255)]
        public required string Address { get; set; }
        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public required string Email { get; set; }
        [Required]
        [MaxLength(20)]
        public required string PhoneNumber { get; set; }
        [Required]
        [MaxLength(100)]
        public required string DesiredJobType { get; set; }
        public virtual required ICollection<Formation> Formations { get; set; }
        public virtual required ICollection<Certification> Certifications { get; set; }
        public virtual required ICollection<Experience> Experiences { get; set; }
        public virtual required ICollection<AssociationCandidateSoftSkill> AssociationCandidateSoftSkills { get; set; }
        public virtual required ICollection<AssociationCandidateHardSkill> AssociationCandidateHardSkills { get; set; }
        public virtual required ICollection<AssociationCandidateHobbie> AssociationCandidateHobbies { get; set; }
        public virtual required ICollection<AssociationCandidateLanguage> AssociationCandidateLanguages { get; set; }
    }

    public enum DrivingLicenseTypeEnum
    {
        A,
        A1,
        A2,
        B,
        B1,
        BE
    }
}

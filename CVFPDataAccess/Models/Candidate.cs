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
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        [EnumDataType(typeof(DrivingLicenseTypeEnum))]
        public DrivingLicenseTypeEnum DrivingLicenseType { get; set; }
        [Required]
        public bool HasOwnVehicle { get; set; }
        [Required]
        [MaxLength(500)]
        public string PresentationSentence { get; set; }
        [Required]
        [MaxLength(255)]
        public string IdentityPhotoLink { get; set; }
        [Required]
        [MaxLength(255)]
        public string LinkedinLink { get; set; }
        [Required]
        [MaxLength(255)]
        public string Address { get; set; }
        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
        [Required]
        [MaxLength(100)]
        public string DesiredJobType { get; set; }
        public ICollection<Formation> Formations { get; set; }
        public ICollection<Certification> Certifications { get; set; }
        public ICollection<AssociationCandidateSoftSkill> AssociationCandidateSoftSkills { get; set; }
        public ICollection<AssociationCandidateHardSkill> AssociationCandidateHardSkills { get; set; }
        public ICollection<AssociationCandidateHobbie> AssociationCandidateHobbies { get; set; }

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

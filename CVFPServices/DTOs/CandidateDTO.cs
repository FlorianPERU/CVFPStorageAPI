using CVFPCommon.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.DTOs
{
    public class CandidateDTO
    {
        public int Id { get; set; }

        public required string FirstName { get; set; }

        public required string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public DrivingLicenseTypeEnum DrivingLicenseType { get; set; }

        public bool HasOwnVehicle { get; set; }

        public required string PresentationSentence { get; set; }

        public required string IdentityPhotoLink { get; set; }

        public required string LinkedinLink { get; set; }

        public required string Address { get; set; }

        public required string Email { get; set; }

        public required string PhoneNumber { get; set; }

        public required string DesiredJobType { get; set; }

    }
}

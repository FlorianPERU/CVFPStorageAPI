using CVFPDataAccess.Models;
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

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public DrivingLicenseTypeEnum DrivingLicenseType { get; set; }

        public bool HasOwnVehicle { get; set; }

        public string PresentationSentence { get; set; }

        public string IdentityPhotoLink { get; set; }

        public string LinkedinLink { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string DesiredJobType { get; set; }

    }

    //public enum DrivingLicenseTypeEnum
    //{
    //    A,
    //    A1,
    //    A2,
    //    B,
    //    B1,
    //    BE
    //}
}

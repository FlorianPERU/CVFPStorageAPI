using CVFPDataAccess.Models;
using CVFPServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.Extensions
{
    public static class CandidateExtensions
    {
        public static CandidateDTO ToDTO(this Candidate candidate)
        {
            return new CandidateDTO
            {
                Id = candidate.Id,
                FirstName = candidate.FirstName,
                LastName = candidate.LastName,
                DateOfBirth = candidate.DateOfBirth,
                DrivingLicenseType = candidate.DrivingLicenseType,
                HasOwnVehicle = candidate.HasOwnVehicle,
                PresentationSentence = candidate.PresentationSentence,
                IdentityPhotoLink = candidate.IdentityPhotoLink,
                LinkedinLink = candidate.LinkedinLink,
                Address = candidate.Address,
                Email = candidate.Email,
                PhoneNumber = candidate.PhoneNumber,
                DesiredJobType = candidate.DesiredJobType
            };
        }
    }
}
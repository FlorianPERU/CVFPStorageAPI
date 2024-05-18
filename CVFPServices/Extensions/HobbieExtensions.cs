using CVFPDataAccess.Models;
using CVFPServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.Extensions
{
    public static class HobbieExtensions
    {
        public static CandidateHobbiesDTO ToDTO(this Hobbie hobbie, int candidateId)
        {
            AssociationCandidateHobbie associationCandidateHobbie = 
                hobbie.AssociationCandidateHobbies.First(acss => acss.CandidateId == candidateId && acss.HobbieId == hobbie.Id);
            return new CandidateHobbiesDTO
            {
                Id = hobbie.Id,
                Name = hobbie.Name,
                LogoLink = hobbie.LogoLink,
                Position = associationCandidateHobbie.Position
            };
        }
    }
}
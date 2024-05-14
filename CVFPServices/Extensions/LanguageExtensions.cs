using CVFPDataAccess.Models;
using CVFPServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.Extensions
{
    public static class LanguageExtensions
    {
        public static CandidateLanguagesDTO ToDTO(this Language Language, int userId)
        {
            AssociationCandidateLanguage associationCandidateLanguage = 
                Language.AssociationCandidateLanguages.First(acss => acss.CandidateId == userId && acss.LanguageId == Language.Id);
            return new CandidateLanguagesDTO
            {
                Id = Language.Id,
                Name = Language.Name,
                LogoLink = Language.LogoLink,
                Position = associationCandidateLanguage.Position,
                IsNative = associationCandidateLanguage.IsNative,
                Ref = associationCandidateLanguage.Ref
            };
        }
    }
}
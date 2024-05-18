using CVFPServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.Services.Interfaces
{
    public interface ICandidateLanguagesService
    {
        public Task<ICollection<CandidateLanguagesDTO>> GetLanguagesDTOByCandidateIdAsync(int candidateId);

    }
}

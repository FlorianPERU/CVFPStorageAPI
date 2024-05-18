using CVFPServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.Services.Interfaces
{
    public interface ICandidatesService
    {
        public Task<CandidateDTO> GetFirstCandidateDTOAsync();

    }
}

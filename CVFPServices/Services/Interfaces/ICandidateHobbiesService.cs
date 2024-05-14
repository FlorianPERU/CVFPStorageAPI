using CVFPServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.Services.Interfaces
{
    public interface ICandidateHobbiesService
    {
        public ICollection<CandidateHobbiesDTO> GetHobbiesDTOByUserId(int userId);

    }
}

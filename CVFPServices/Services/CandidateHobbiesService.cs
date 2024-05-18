using CVFPDataAccess.Models;
using CVFPDataAccess.Repositories.Hobbies;
using CVFPServices.DTOs;
using CVFPServices.Extensions;
using CVFPServices.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPServices.Services
{
    public class CandidateHobbiesService : ICandidateHobbiesService
    {

        private readonly IHobbiesRepository _hobbiesRepository;
        public CandidateHobbiesService(IHobbiesRepository hobbiesRepository) 
        {
            _hobbiesRepository = hobbiesRepository;
        }

        public async Task<ICollection<CandidateHobbiesDTO>> GetHobbiesDTOByUserIdAsync(int userId)
        {
            var hobbies = await _hobbiesRepository.GetHobbiesByUserIdCandidateAsync(userId);
            return hobbies.Select(h=> h.ToDTO(userId)).ToList();
        }
    }
}

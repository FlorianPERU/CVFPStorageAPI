using CVFPServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace CVFPApiPackage.Client
{
    public class CandidateHobbiesClient
    {
        private readonly HttpClient _httpClient;

        public CandidateHobbiesClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ICollection<CandidateHobbiesDTO>> GetCandidateHobbiesAsync(int candidateId)
        {
            var response = await _httpClient.GetAsync($"CandidateHobbies?candidateId={candidateId}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<ICollection<CandidateHobbiesDTO>>() ?? new List<CandidateHobbiesDTO>();
        }
    }
}
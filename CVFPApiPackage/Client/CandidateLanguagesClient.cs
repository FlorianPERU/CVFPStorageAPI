using CVFPServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace CVFPApiPackage.Client
{
    public class CandidateLanguagesClient
    {
        private readonly HttpClient _httpClient;

        public CandidateLanguagesClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ICollection<CandidateLanguagesDTO>> GetCandidateLanguagesAsync(int candidateId)
        {
            var response = await _httpClient.GetAsync($"CandidateLanguages?candidateId={candidateId}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<ICollection<CandidateLanguagesDTO>>() ?? new List<CandidateLanguagesDTO>();
        }
    }
}
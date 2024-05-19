using CVFPServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace CVFPApiPackage.Client
{
    public class CandidateSkillsClient
    {
        private readonly HttpClient _httpClient;

        public CandidateSkillsClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CandidateSkillsDTO> GetCandidateSkillsAsync(int candidateId)
        {
            var response = await _httpClient.GetAsync($"CandidateSkills?candidateId={candidateId}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<CandidateSkillsDTO>() ?? new CandidateSkillsDTO();
        }
    }
}
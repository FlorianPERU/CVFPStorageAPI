using CVFPServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace CVFPApiPackage.Client
{
    public class ExperienceSkillsClient
    {
        private readonly HttpClient _httpClient;

        public ExperienceSkillsClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ICollection<ExperienceSkillDTO>> GetExperienceSkillsAsync(int candidateId)
        {
            var response = await _httpClient.GetAsync($"ExperienceSkills?candidateId={candidateId}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<ICollection<ExperienceSkillDTO>>() ?? new List<ExperienceSkillDTO>();
        }
    }
}
using CVFPServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace CVFPApiPackage.Client
{
    public class ExperiencesClient
    {
        private readonly HttpClient _httpClient;

        public ExperiencesClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ICollection<ExperienceDTO>> GetExperiencesAsync(int candidateId)
        {
            var response = await _httpClient.GetAsync($"Experiences?candidateId={candidateId}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<ICollection<ExperienceDTO>>() ?? new List<ExperienceDTO>();
        }
    }
}
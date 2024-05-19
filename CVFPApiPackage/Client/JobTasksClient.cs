using CVFPServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace CVFPApiPackage.Client
{
    public class JobTasksClient
    {
        private readonly HttpClient _httpClient;

        public JobTasksClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ICollection<JobTaskDTO>> GetJobTasksAsync(int candidateId)
        {
            var response = await _httpClient.GetAsync($"JobTasks?candidateId={candidateId}");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<ICollection<JobTaskDTO>>() ?? new List<JobTaskDTO>();
        }
    }
}
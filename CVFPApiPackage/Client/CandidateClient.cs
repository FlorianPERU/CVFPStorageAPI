using CVFPServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace CVFPApiPackage.Client
{
    public class CandidateClient
    {
        private readonly HttpClient _httpClient;

        public CandidateClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CandidateDTO> GetFirstCandidateAsync()
        {
            var response = await _httpClient.GetAsync($"FirstCandidate");
            response.EnsureSuccessStatusCode();

            var candidate = await response.Content.ReadFromJsonAsync<CandidateDTO>();

            if (candidate == null)
            {
                //Fisrt Candidate can not be null
                throw new Exception("Fisrt Candidate can not be null");
            }

            return candidate;
        }
    }
}
using CVFPServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace CVFPApiPackage.Client
{
    public class CertificationsFormationsClient
    {
        private readonly HttpClient _httpClient;

        public CertificationsFormationsClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CertificationsFormationsDTO> GetCertificationsFormationsAsync(int candidateId)
        {
            var response = await _httpClient.GetAsync($"CertificationsFormations?candidateId={candidateId}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<CertificationsFormationsDTO>() ?? new CertificationsFormationsDTO();
        }
    }
}
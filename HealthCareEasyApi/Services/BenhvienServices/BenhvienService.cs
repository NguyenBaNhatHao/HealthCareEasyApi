using Microsoft.AspNetCore.Components;
using HealthCareEasyApi.Models;
using HealthCareEasyApi.Data;

namespace HealthCareEasyApi.Services.SinhvienServices
{
    public class BenhvienService : IBenhvienService
    {
        public readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;
        public List<Benhvien> Benhvienservices { get; set; } = new List<Benhvien>();
        public BenhvienService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
            _http.BaseAddress = new Uri(_navigationManager.BaseUri);
        }

        public async Task GetBenhvienDetail()
        {
            var resutl = await _http.GetFromJsonAsync<List<Benhvien>>("api/benhvien");
            if (resutl != null)
            {
                Benhvienservices = resutl;
            }
        }
    }
}

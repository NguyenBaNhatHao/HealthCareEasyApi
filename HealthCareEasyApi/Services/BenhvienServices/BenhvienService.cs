using Microsoft.AspNetCore.Components;
using HealthCareEasyApi.Models;
using HealthCareEasyApi.Dtos;
using HealthCareEasyApi.Data;
using Newtonsoft.Json;

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
            Console.WriteLine(resutl);
            if (resutl != null)
            {
                Benhvienservices = resutl;
            }
            
        }

        public async Task CreateBenhvien(Benhvien benhvien)
        {
            var resutl = await _http.PostAsJsonAsync("api/benhvien/create", benhvien);
            await Setbenhvien(resutl);
        }
        private async Task Setbenhvien(HttpResponseMessage result)
        {
            //var response = await result.Content.ReadFromJsonAsync<List<SuperHero>>();
            //Heroes = response;
            _navigationManager.NavigateTo("benhvien");
        }
    }
}

using HealthCareEasyApi.Models;
using HealthCareEasyApi.Dtos;
using HealthCareEasyApi.Data;
namespace HealthCareEasyApi.Services.SinhvienServices
{
    public interface IBenhvienService
    {
        List<Benhvien> Benhvienservices { get; set; }
        Task GetBenhvienDetail();
        Task CreateBenhvien(Benhvien benhvien);
    }
}

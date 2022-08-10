using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using HealthCareEasyApi.Models;
namespace HealthCareEasyApi.Dtos
{
    public class DichvuDTO
    {
        public int? DichvuId { get; set; }
        public string? Tendichvu { get; set; }
    }
}

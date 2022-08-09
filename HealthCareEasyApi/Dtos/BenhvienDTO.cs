using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace HealthCareEasyApi.Dtos
{
    public class BenhvienDTO
    {
        [Required]
        public string? Benhvien_Id { get; set; }
        public string? Tenbenhvien { get; set; }
        public string? Thongtin { get; set; }
        public string? Giatien { get; set; }
        public string? Image { get; set; }
        public int DichvuId { get; set; }
        public string? Tendichvu { get; set; }
        
    }
}

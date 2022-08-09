using System.ComponentModel.DataAnnotations;
namespace HealthCareEasyApi.Models
{
    public class Dichvu
    {
        [Required]
        public int DichvuId { get; set; }
        public string? Tendichvu { get; set; }
        public ICollection<Benhvien> Benhviens { get; set; }
    }
}

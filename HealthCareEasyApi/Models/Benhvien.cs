using System.ComponentModel.DataAnnotations;
namespace HealthCareEasyApi.Models
{
    public class Benhvien
    {
        [Key]
        
        public int Id { get; set; }
        public string? Benhvien_Id { get; set; }
        public string? Tenbenhvien { get; set; }
        public string? Thongtin { get; set; }
        public string? Giatien { get; set; }
        public string? Image { get; set; }
        public int? DichvuId { get; set; }
        public virtual Dichvu Dichvu { get; set; }

    }
}

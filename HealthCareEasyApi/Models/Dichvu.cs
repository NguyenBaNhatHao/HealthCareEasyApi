using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HealthCareEasyApi.Models
{
    public class Dichvu
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int? DichvuId { get; set; }
        public string? Tendichvu { get; set; }

    }
}

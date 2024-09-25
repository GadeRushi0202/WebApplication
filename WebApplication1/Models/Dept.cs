using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Dept")]
    public class Dept
    {
        [Key]
        public int Did { get; set; }
        [Required]
        public string? Dname { get; set; }
    }
}

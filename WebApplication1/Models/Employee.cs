using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public int salary {get; set; }
        [ForeignKey("Did")]
        public int Did { get;set; }
    }
}

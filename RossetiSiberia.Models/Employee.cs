using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RossetiSiberia.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string MiddleName { get; set; } = string.Empty;

        public int PositionId { get; set; }

        [ForeignKey("PositionId")]
        public Position? Position { get; set; }

        [Required]
        [MaxLength(11)]
        public string Mobile { get; set; } = string.Empty;

        [Required]
        [MaxLength(75)]
        public string Email { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
    }
}

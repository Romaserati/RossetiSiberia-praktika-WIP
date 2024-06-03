using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RossetiSiberia.Models
{
    public class Position
    {
        public int Id { get; set; }

        [MaxLength(30)]
        public string PositionName { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }
    }
}

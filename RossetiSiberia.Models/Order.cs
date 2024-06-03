using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RossetiSiberia.Models
{
    public class Order
    {
        public int Id { get; set; }

        public string CustomerId { get; set; } = string.Empty;

        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set; }

        public int ServiceId { get; set; }

        [ForeignKey("ServiceId")]
        public Service? Service { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}

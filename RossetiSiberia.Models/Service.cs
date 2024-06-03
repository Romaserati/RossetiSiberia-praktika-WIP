using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RossetiSiberia.Models
{
    [Table("Services")]
    public class Service
    {
        public int Id { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Заполните это поле")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Категория не выбрана")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category? Category { get; set; }

        [MaxLength(200)]
        [Required(ErrorMessage = "Заполните это поле")]
        public string Description { get; set; } = string.Empty;

        [ValidateNever]
        public string ImageUrl { get; set; } = string.Empty;

    }
}

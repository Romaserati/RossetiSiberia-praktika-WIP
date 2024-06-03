/*using Microsoft.AspNetCore.Mvc;*/
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace RossetiSiberia.Models
{
    public class Category
    {
        public int Id { get; set; }
        [MaxLength(75)]
        [Required(ErrorMessage = "Заполните это поле")]
        public string CategoryName { get; set; } = string.Empty;
    }
}

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace RossetiSiberia.Models
{
    public class Customer : IdentityUser
    {
        [Required(ErrorMessage = "Поле обязательно к заполнению")]
        [MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Поле обязательно к заполнению")]
        [MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Поле обязательно к заполнению")]
        [MaxLength(50)]
        public string MiddleName { get; set; } = string.Empty;

    }
}

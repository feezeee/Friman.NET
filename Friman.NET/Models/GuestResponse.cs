using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Friman.NET.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Введи норм имя!")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Введи норм почту!")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Почта кривая")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify whether you' 11 attend")]
        public bool? WillAttend { get; set; }
    }
}

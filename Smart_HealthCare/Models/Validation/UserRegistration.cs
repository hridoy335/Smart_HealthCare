using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Smart_HealthCare.Models
{
    [MetadataType(typeof(MetadataUserRegistration))]
    public partial class UserRegistration
    {
    }

    public class MetadataUserRegistration
    {
        [Required]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Name is not correct format")]
        [Display(Name ="Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Username is required. ")]
        [MaxLength(50, ErrorMessage = "User username can't be more than 50 characters")]
        [Display(Name ="UserName")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required. ")]
        [Display(Name ="Password")]
        [MaxLength(50, ErrorMessage = "User password can't be more than 50 characters")]
        public string Password { get; set; }
    }
}
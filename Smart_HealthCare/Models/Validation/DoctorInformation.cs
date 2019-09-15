using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Smart_HealthCare.Models
{
    [MetadataType(typeof(MetadataDoctorInformation))]
    public partial class DoctorInformation
    {
    }

    public class MetadataDoctorInformation
    {
        [Required(ErrorMessage ="Name is required. ")]                            
        [Display(Name ="Doctor Name")]
        [MaxLength(50, ErrorMessage = "User Doctor name Type name can't be more than 50 characters")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Name is not correct format")]
        public string DoctorName { get; set; }

        [Required(ErrorMessage ="Image is required.")]
        public string DoctorImage { get; set; }

        
        [Required(ErrorMessage = "Mobile Number is required.")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string DoctorContact { get; set; }

        [Required(ErrorMessage = "Mail is required.")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "EMail is not correct format")]
        [Display(Name = "Email")]
        public string DoctorEmail { get; set; }

        [Required(ErrorMessage ="Address required.")]
        [Display(Name ="Address")]

        public int DoctorAddressId { get; set; }
        [Required]
        public int RegistrationId { get; set; }
    }
}
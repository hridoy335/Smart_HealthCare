using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Smart_HealthCare.Models
{
    [MetadataType(typeof(MetadataPatientInformation))]
    public partial class PatientInformation
    {
    }

    public class MetadataPatientInformation
    {
        [Required(ErrorMessage = "Image is required.")]
        public string PatientImage { get; set; }

        [Required(ErrorMessage = "Name is required. ")]
        [Display(Name = "Patient Name")]
        [MaxLength(50, ErrorMessage = "User patient name Type name can't be more than 50 characters")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Name is not correct format")]
        public string PatientName { get; set; }

        [Required(ErrorMessage = "Mail is required.")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Email is not correct format")]
        [Display(Name = "Email")]
        public string PatientMail { get; set; }

        [Required(ErrorMessage = "Mobile Number is required.")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string PatientContact { get; set; }

        public int PatientAddressId { get; set; }
        public int RegistrationId { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Smart_HealthCare.Models
{
    [MetadataType(typeof(MetadataUpzila))]      
    public partial class Upazila
    {
    }

    public class MetadataUpzila
    {
        [Required(ErrorMessage = "Name is required. ")]
        [Display(Name = "Upzila Name")]
        [MaxLength(50, ErrorMessage = "User upazila name Type name can't be more than 50 characters")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Name is not correct format")]
        public string UpazilaName { get; set; }
    }
}
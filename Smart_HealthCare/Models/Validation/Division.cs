using System;                                                                       
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Smart_HealthCare.Models
{
    [MetadataType(typeof(MetadataDivision))]
    public partial class Division
    {
    }
    public class MetadataDivision
    {
        [Required(ErrorMessage = "Name is required. ")]
        [Display(Name = "Division Name")]
        [MaxLength(50, ErrorMessage = "User division name can't be more than 50 characters")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Name is not correct format")]
        public string DivisionName { get; set; }
    }
}
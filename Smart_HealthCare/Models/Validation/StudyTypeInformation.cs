using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Smart_HealthCare.Models
{
    [MetadataType(typeof(MetadataStudyType))]
    public partial class StudyTypeInformation
    {
    }

    public class MetadataStudyType
    {
        [Required(ErrorMessage = "Name is required. ")]
        [Display(Name = "Study Type Name")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Name is not correct format")]
        [MaxLength(50, ErrorMessage = "User Study Type name can't be more than 50 characters")]
        public string StudyType { get; set; }
    }
}
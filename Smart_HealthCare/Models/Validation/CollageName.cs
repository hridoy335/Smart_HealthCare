using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Smart_HealthCare.Models
{
    [MetadataType(typeof(MetadataCollageName))]
    public partial class CollageName
    {
    }

    public class MetadataCollageName
    {

        [Required(ErrorMessage = "Name is required. ")]
        [Display(Name = "Collage Name")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Name is not correct format")]
        [MaxLength(50, ErrorMessage = "User collage name can't be more than 50 characters")]
        public string CollageName1 { get; set; }

    }
}
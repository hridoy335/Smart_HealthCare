using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Smart_HealthCare.Models
{
    [MetadataType(typeof(MetadataZila))]
    public partial class Zila
    {
    }

    public class MetadataZila
    {
        [Required(ErrorMessage = "Name is required. ")]
        [Display(Name = "Zila Name")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Name is not correct format")]
        public string ZilaName { get; set; }
    }
}
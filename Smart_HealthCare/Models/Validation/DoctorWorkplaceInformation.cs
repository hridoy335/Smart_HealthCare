using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Smart_HealthCare.Models
{
    [MetadataType(typeof(MetadataDoctorWorkplaceInformation))]
    public partial class DoctorWorkplaceInformation
    {
    }

    public class MetadataDoctorWorkplaceInformation
    {
        [Required]
        public int DoctorId { get; set; }
        [Required(ErrorMessage ="Place name is required. ")]
        [MaxLength(50, ErrorMessage = "User place name can't be more than 50 characters")]
        public string PlaceName { get; set; }

        [Required]
        public int PlaceAddressId { get; set; }
        [Required(ErrorMessage ="Join date is required. ")]
        [DataType(DataType.Date)]
        public System.DateTime JoiningDate { get; set; }

        [Required(ErrorMessage = "End date is required. ")]
        [DataType(DataType.Date)]
        public System.DateTime EndDate { get; set; }

        [Required(ErrorMessage ="Job status is required.")]
        public bool PresentStatus { get; set; }
    }
}
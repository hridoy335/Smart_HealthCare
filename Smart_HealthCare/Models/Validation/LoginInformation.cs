using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Smart_HealthCare.Models
{
    [MetadataType(typeof(MetadataLoginInformation))]
    public partial class LoginInformation
    {
    }
    public class MetadataLoginInformation
    {
        [Required]
        public int RegistrationId { get; set; }
        [Required]
        public string IpAddress { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public Nullable<System.TimeSpan> LoginTime { get; set; }
    }
}
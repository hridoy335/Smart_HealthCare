//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Smart_HealthCare.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RatingAndCommand
    {
        public int RatingId { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public Nullable<int> RatingPoint { get; set; }
        public string Command { get; set; }
    
        public virtual DoctorInformation DoctorInformation { get; set; }
    }
}
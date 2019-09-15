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
    
    public partial class Upazila
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Upazila()
        {
            this.DoctorInformations = new HashSet<DoctorInformation>();
            this.DoctorWorkplaceInformations = new HashSet<DoctorWorkplaceInformation>();
            this.PatientInformations = new HashSet<PatientInformation>();
        }
    
        public int UpazilaId { get; set; }
        public string UpazilaName { get; set; }
        public int ZilaId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoctorInformation> DoctorInformations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoctorWorkplaceInformation> DoctorWorkplaceInformations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientInformation> PatientInformations { get; set; }
        public virtual Zila Zila { get; set; }
    }
}
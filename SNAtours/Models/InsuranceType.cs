//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SNAtours.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class InsuranceType
    {
        public InsuranceType()
        {
            this.Insurances = new HashSet<Insurance>();
        }
    
        public int Id { get; set; }
        public string Age { get; set; }
    
        public virtual ICollection<Insurance> Insurances { get; set; }
    }
}

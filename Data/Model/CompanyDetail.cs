//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CompanyDetail
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }
        public string WebSiteLink { get; set; }
        public Nullable<int> CompanySize { get; set; }
        public string CopmanyAddress1 { get; set; }
        public string CopmanyAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreatedDate { get; set; }
    
        public virtual UserRegistration UserRegistration { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiyetisyenApp.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class KullaniciRole
    {
        public int Id { get; set; }
        public Nullable<int> userId { get; set; }
        public Nullable<int> roleId { get; set; }
    
        public virtual KullaniciTable KullaniciTable { get; set; }
        public virtual Role Role { get; set; }
    }
}
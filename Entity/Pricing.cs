//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pricing
    {
        public int Id { get; set; }
        public string HourRange { get; set; }
        public int Price { get; set; }
        public bool Status { get; set; }
        public int ParkAreaId { get; set; }
    
        public virtual ParkArea ParkArea { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoSpeed_Orlov.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Building_Materials
    {
        public int Material_Number { get; set; }
        public string Material_Name { get; set; }
        public string Measure_Unit { get; set; }
        public int Remains { get; set; }
        public int Storage { get; set; }
    
        public virtual Storage Storage1 { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMP
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tb_pur
    {
        public int ID { get; set; }
        public string pur_name { get; set; }
        public string pur_type { get; set; }
        public Nullable<double> pur_Buy { get; set; }
        public Nullable<double> pur_sell { get; set; }
        public Nullable<double> pur_Qu { get; set; }
        public Nullable<double> pur_Tbuy { get; set; }
        public Nullable<int> cat_id { get; set; }
    
        public virtual TB_CAT TB_CAT { get; set; }
    }
}

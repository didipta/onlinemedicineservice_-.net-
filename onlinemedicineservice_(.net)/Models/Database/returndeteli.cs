//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace onlinemedicineservice__.net_.Models.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class returndeteli
    {
        public int id { get; set; }
        public string p_name { get; set; }
        public int p_quantity { get; set; }
        public string p_price { get; set; }
        public int return_id { get; set; }
        public int p_id { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Returnproduct Returnproduct { get; set; }
    }
}

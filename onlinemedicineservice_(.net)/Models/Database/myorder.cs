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
    
    public partial class myorder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public myorder()
        {
            this.deliverinfoes = new HashSet<deliverinfo>();
            this.Orderdetails = new HashSet<Orderdetail>();
        }
    
        public int Id { get; set; }
        public string Oder_id { get; set; }
        public int User_id { get; set; }
        public string U_username { get; set; }
        public string totale_price { get; set; }
        public string Paymanttype { get; set; }
        public string O_status { get; set; }
        public string totale_iteam { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<deliverinfo> deliverinfoes { get; set; }
        public virtual Systemuser Systemuser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orderdetail> Orderdetails { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace new_Theatre
{
    using System;
    using System.Collections.Generic;
    
    public partial class Performance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Performance()
        {
            this.PurchasedTickets = new HashSet<PurchasedTickets>();
        }
    
        public int ID_performance { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public System.DateTime Time { get; set; }
        public double Cost { get; set; }
        public int ID_author { get; set; }
        public int Number_places { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchasedTickets> PurchasedTickets { get; set; }
    }
}

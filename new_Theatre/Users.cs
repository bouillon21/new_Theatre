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
    using new_Theatre.Func;
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            this.PurchasedTickets = new HashSet<PurchasedTickets>();
        }

        public Users(string login, string password, string name, string firstName, string lastName, bool is_Admin)
        {
            Login = login;
            Password = password;
            Name = name;
            FirstName = firstName;
            LastName = lastName;
            this.is_Admin = is_Admin;
            this.PurchasedTickets = new HashSet<PurchasedTickets>();
        }

        public int ID_user { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool is_Admin { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchasedTickets> PurchasedTickets { get; set; }
    }
}

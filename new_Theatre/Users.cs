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
    
    public partial class Users
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public Nullable<bool> is_Admin { get; set; }
        public int id_user { get; set; }


        public Users(string Login, string Password, string Phone, bool is_Admin)
        {
            this.Login = Login;
            this.Password = Password;
            this.Phone = Phone;
            this.is_Admin = is_Admin;
        }

        public Users()
        {

        }
    }
}

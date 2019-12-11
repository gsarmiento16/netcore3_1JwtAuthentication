using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.ViewModels
{
    public class UserViewModel
    {
        public string Ext_Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumbe2 { get; set; }
        public bool CompleteRegister { get; set; }
        DateTime Created { get; set; }
        string UserCreated { get; set; }
        public bool HasEntity { get; set; }
    }
}

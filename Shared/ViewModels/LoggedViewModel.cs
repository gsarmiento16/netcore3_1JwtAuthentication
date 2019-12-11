using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.ViewModels
{
    public class LoggedViewModel
    {
        public string Token { get; set; }
        public virtual UserViewModel User { get; set; }
    }
}

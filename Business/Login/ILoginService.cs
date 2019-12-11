using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Shared.ViewModels;

namespace Business
{
    public interface ILoginService
    {
        LoggedViewModel Login(LogingViewModel login, string key, string issuer, int expires);
        string BuildToken(UserViewModel user, string key, string issuer, int expires);
    }
}

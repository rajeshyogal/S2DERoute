using S2DERoute.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2DERoute.Services
{
    public interface IAuthenticateService
    {
        User Autheticate(string username, string password);
    }
}

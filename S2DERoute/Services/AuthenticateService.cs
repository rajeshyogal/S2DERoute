using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using S2DERoute.Entities;

namespace S2DERoute.Services
{
    public class AuthenticateService : IAuthenticateService
    {

        private List<User> _users = new List<User>
        {
            new User {Id = 1, username = "admin", password = "admin", Role = Role.Admin },
            new User {Id = 2, username = "user", password = "user", Role = Role.User}

        };


        public User Autheticate(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}

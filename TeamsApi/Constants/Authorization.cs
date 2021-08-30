using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamsApi.Constants
{
    public class Authorization
    {
        public enum Roles
        {
            Admin,
            User
        }
        public const string default_username = "user";
        public const string default_email = "a@c.com";
        public const string default_password = "Pa$$w0rd.";
        public const Roles default_role = Roles.User;
    }
}

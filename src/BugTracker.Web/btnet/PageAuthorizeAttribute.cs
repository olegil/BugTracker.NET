﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace btnet
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public class PageAuthorizeAttribute : Attribute
    {
        private readonly string[] _roles;

        public PageAuthorizeAttribute()
        {
            _roles = new string[0];
        }

        public PageAuthorizeAttribute(params string[] roles)
        {
            _roles = roles;
        }

        
        public bool OnAuthorize(IPrincipal principal)
        {
            return principal.Identity.IsAuthenticated && 
                (_roles.Length == 0 || _roles.Any(role => principal.IsInRole(role)));
        }
    }
}
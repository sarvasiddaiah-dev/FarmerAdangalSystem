using AuthenticationService.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationService.Application.Services
{
    public class AuthService : IAuthService
    {
        public string GetServiceName()
        {
            return "FarmerAdangal Authentication Service";
        }
    }
}

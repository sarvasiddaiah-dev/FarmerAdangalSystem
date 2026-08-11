using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationService.Domain.Enums
{
    public enum OtpPurpose
    {
        Login = 1,
        ForgotPassword = 2,
        Registration = 3,
        ChangeMobileNumber = 4
    }
}

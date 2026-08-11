using AuthenticationService.Domain.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationService.Domain.Exceptions
{
    public  class UserNotFoundException: DomainException
    {
        public UserNotFoundException():base(ErrorMessages.UserNotFound)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace AuthenticationService.Infrastructure.Persistence.Connection
{
    public interface IConnectionFactory
    {
        SqlConnection CreateConnection();
    }
}

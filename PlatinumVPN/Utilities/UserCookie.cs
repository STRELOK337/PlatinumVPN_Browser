using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatinumVPN.Utilities
{
    public class UserCookie
    {
        public string SessionKey { get; set; } = Guid.NewGuid().ToString();
    }
}

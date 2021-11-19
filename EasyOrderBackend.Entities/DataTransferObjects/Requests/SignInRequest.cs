using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyOrderBackend.Entities.DataTransferObjects.Requests
{
    public class SignInRequest
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}

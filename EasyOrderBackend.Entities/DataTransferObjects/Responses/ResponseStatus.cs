using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyOrderBackend.Entities.DataTransferObjects.Responses
{
    public class ResponseStatus
    {
        public bool IsSucceeded { get; set; }
        
        public string Message { get; set; }
    }
}

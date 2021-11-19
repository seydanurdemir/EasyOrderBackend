using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyOrderBackend.Entities.DataTransferObjects.Responses
{
    public class CodeBaseResponse
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string ContactTitle { get; set; }

        public string AddressTitle { get; set; }

        public string CardTitle { get; set; }

        public Guid GuidCode { get; set; }
        
        public ResponseStatus ResponseStatus { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyOrderBackend.Entities.DataTransferObjects.Responses
{
    public class OrderBaseResponse
    {
        public int Id { get; set; }

        public Guid GuidCode { get; set; }

        public string Source { get; set; }

        public string Amount { get; set; }

        public string DateAndTime { get; set; }

        public ResponseStatus ResponseStatus { get; set; }
    }
}

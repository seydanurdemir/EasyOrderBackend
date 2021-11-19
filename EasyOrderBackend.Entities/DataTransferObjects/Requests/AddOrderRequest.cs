using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyOrderBackend.Entities.DataTransferObjects.Requests
{
    public class AddOrderRequest
    {
        //Done automatically after api call
        public int AccountId { get; set; }

        public Guid GuidCode { get; set; }

        public string Source { get; set; }

        public string Amount { get; set; }

        //public string DateAndTime { get; set; }
        //Add automatically on api call
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyOrderBackend.Entities.DataTransferObjects.Requests
{
    public class AddAddressRequest
    {
        public int CurrentAccountId { get; set; }

        public string Title { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string District { get; set; }

        public string Street { get; set; }

        public string Number { get; set; }

        public string PostalCode { get; set; }
    }
}

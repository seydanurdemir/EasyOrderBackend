using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyOrderBackend.Entities.DataTransferObjects.Requests
{
    public class AddCodeRequest
    {
        public int CurrentAccountId { get; set; }

        public string Title { get; set; }

        public int ContactId { get; set; }

        public int AddressId { get; set; }

        public int CardId { get; set; }
    }
}

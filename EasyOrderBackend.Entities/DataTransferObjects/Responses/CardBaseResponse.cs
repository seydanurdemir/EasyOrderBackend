using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyOrderBackend.Entities.DataTransferObjects.Responses
{
    public class CardBaseResponse
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string CardNumber { get; set; }

        public string ExpirationDate { get; set; }

        public string CVV { get; set; }

        public int ControlLimit { get; set; }

        public ResponseStatus ResponseStatus { get; set; }
    }
}

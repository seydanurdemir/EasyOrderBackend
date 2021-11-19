using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyOrderBackend.Entities.DataTransferObjects.Responses
{
    public class ContactBaseResponse
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Phone { get; set; }

        public string IdentityNumber { get; set; }

        public ResponseStatus ResponseStatus { get; set; }
    }
}

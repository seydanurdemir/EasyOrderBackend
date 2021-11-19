using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyOrderBackend.Entities.Entities
{
    public class Contact
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(32, MinimumLength = 3, ErrorMessage = "Maximum 32, Minimum 3 Characters")]
        [DataType(DataType.Text)]
        public string Title { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage = "Maximum 50, Minimum 1 Characters")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage = "Maximum 50, Minimum 1 Characters")]
        [DataType(DataType.Text)]
        public string Surname { get; set; }

        [StringLength(10, MinimumLength = 10, ErrorMessage = "Maximum 10, Minimum 10 Characters")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [StringLength(11, MinimumLength = 11, ErrorMessage = "Maximum 11, Minimum 11 Characters")]
        public string IdentityNumber { get; set; }

        public bool IsRecordValid { get; set; }

        public int InsertUserId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime InsertDateTime { get; set; }

        public int UpdateUserId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime UpdateDateTime { get; set; }
    }
}

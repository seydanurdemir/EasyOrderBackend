using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyOrderBackend.Entities.Entities
{
    public class Address
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(32, MinimumLength = 3, ErrorMessage = "Maximum 32, Minimum 3 Characters")]
        [DataType(DataType.Text)]
        public string Title { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage = "Maximum 50, Minimum 1 Characters")]
        [DataType(DataType.Text)]
        public string City { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage = "Maximum 50, Minimum 1 Characters")]
        [DataType(DataType.Text)]
        public string Region { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage = "Maximum 50, Minimum 1 Characters")]
        [DataType(DataType.Text)]
        public string District { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage = "Maximum 50, Minimum 1 Characters")]
        [DataType(DataType.Text)]
        public string Street { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage = "Maximum 50, Minimum 1 Characters")]
        [DataType(DataType.Text)]
        public string Number { get; set; }

        [StringLength(10, MinimumLength = 3, ErrorMessage = "Maximum 10, Minimum 3 Characters")]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }

        public bool IsRecordValid { get; set; }

        public int InsertUserId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime InsertDateTime { get; set; }

        public int UpdateUserId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime UpdateDateTime { get; set; }
    }
}

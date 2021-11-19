using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyOrderBackend.Entities.Entities
{
    public class Card
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(32, MinimumLength = 3, ErrorMessage = "Maximum 32, Minimum 3 Characters")]
        [DataType(DataType.Text)]
        public string Title { get; set; }

        [StringLength(60, MinimumLength = 1, ErrorMessage = "Maximum 60, Minimum 1 Characters")]
        [DataType(DataType.CreditCard)]
        public string CardNumber { get; set; }

        [StringLength(8, MinimumLength = 6, ErrorMessage = "Maximum 8, Minimum 6 Characters")]
        //[DataType(DataType.Date)]
        public string ExpirationDate { get; set; }

        [StringLength(5, MinimumLength = 3, ErrorMessage = "Maximum 5, Minimum 3 Characters")]
        public string CVV { get; set; }

        public int ControlLimit { get; set; }

        public bool IsRecordValid { get; set; }

        public int InsertUserId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime InsertDateTime { get; set; }

        public int UpdateUserId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime UpdateDateTime { get; set; }
    }
}

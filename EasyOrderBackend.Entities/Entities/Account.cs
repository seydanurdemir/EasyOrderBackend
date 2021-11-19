using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyOrderBackend.Entities.Entities
{
    [Table("Accounts")]
    public class Account
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //Unique
        [StringLength(64, MinimumLength = 8)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [StringLength(32, MinimumLength = 8, ErrorMessage = "Maximum 32, Minimum 8 Characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage = "Maximum 50, Minimum 1 Characters")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage = "Maximum 50, Minimum 1 Characters")]
        [DataType(DataType.Text)]
        public string Surname { get; set; }

        //Unique
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Maximum 10, Minimum 10 Characters")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DataType(DataType.ImageUrl)]
        public string Image { get; set; }

        [DefaultValue(true)]
        public bool IsRecordValid { get; set; }

        public int InsertUserId { get; set; }

        [DataType(DataType.DateTime)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime InsertDateTime { get; set; }

        public int UpdateUserId { get; set; }

        [DataType(DataType.DateTime)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdateDateTime { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyOrderBackend.Entities.Entities
{
    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(32, MinimumLength = 3, ErrorMessage = "Maximum 32, Minimum 3 Characters")]
        [DataType(DataType.Text)]
        public string Title { get; set; }

        public Guid GuidCode { get; set; }

        [StringLength(256, MinimumLength = 3, ErrorMessage = "Maximum 256, Minimum 3 Characters")]
        [DataType(DataType.Url)]
        public string Url { get; set; }

        [StringLength(32, MinimumLength = 1, ErrorMessage = "Maximum 32, Minimum 1 Characters")]
        [DataType(DataType.Currency)]
        public string Amount { get; set; }

        [StringLength(36, MinimumLength = 18, ErrorMessage = "Maximum 36, Minimum 18 Characters")]
        [DataType(DataType.DateTime)]
        public string DateAndTime { get; set; }

        public bool IsRecordValid { get; set; }

        public int InsertUserId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime InsertDateTime { get; set; }

        public int UpdateUserId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime UpdateDateTime { get; set; }
    }
}
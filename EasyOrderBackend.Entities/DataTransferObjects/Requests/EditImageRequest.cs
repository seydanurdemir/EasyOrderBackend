﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyOrderBackend.Entities.DataTransferObjects.Requests
{
    public class EditImageRequest
    {
        public int CurrentAccountId { get; set; }

        public string Image { get; set; }
    }
}

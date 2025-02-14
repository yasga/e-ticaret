﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ETicaret.Core.Models
{
    public partial class StockStatus
    {
        public StockStatus()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}

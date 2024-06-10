﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity.Concrete
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}

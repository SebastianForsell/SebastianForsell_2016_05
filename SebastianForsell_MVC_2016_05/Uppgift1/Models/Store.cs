﻿//Sebastian Forsell

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1.Models
{
    public class Store
    {
        public int StoreID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Product> Products { get; set; }
    }
}

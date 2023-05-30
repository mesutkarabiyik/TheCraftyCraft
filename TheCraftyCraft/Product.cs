using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheCraftyCraft
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int StockAmount { get; set; }

        public String ImageUrl { get; set; }

    }
}
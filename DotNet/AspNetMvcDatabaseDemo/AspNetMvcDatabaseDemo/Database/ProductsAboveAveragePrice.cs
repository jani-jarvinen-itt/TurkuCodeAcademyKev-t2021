using System;
using System.Collections.Generic;

#nullable disable

namespace AspNetMvcDatabaseDemo.Database
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}

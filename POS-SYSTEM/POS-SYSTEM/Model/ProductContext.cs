using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POS_SYSTEM.Model
{
    public class ProductContext :DbContext
    {
        public ProductContext(DbContextOptions options)
          : base(options) { }
     

        public DbSet<ProductList> ProductLists { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace POS_SYSTEM.Model
{
    public class ProductList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductCode { get; set; }
        public string ProductCatogory { get; set; }
        public int ProductCatogoryId { get; set; }
        public int PriceBuy { get; set; }
        public int PriceSell { get; set; }
    }
}

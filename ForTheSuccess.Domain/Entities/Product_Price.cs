using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTheSuccess.Domain.Entities
{
    public class ProductPrice : BaseEntity
    {
        public string Prdct_Brcd { get; set; }
        public decimal Prdct_Unit_Price { get; set; }
        public string Prdct_Price_Currency { get; set; }
        public int Branch_ID { get; set; }
        public string Prdct_Desc { get; set; }
    }
}

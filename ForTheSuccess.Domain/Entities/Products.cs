using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTheSuccess.Domain.Entities
{
    public class Products : BaseEntity
    {
        public string Prdct_Brcd { get; set; }
        public string Prdct_Cd { get; set; }
        public int Prdct_Detail_ID { get; set; }
        public int Categori_ID { get; set; }
        public int Branch_ID { get; set; }
        public int Supplier_ID { get; set; }
        public string Prdct_Name { get; set; }
        public string Prdct_Color { get; set; }
        public string Prdct_Size { get; set; }
        public string Prdct_Quantity { get; set; }
        public decimal Prdct_Unit_Price { get; set; }
        public string Prdct_Currency { get; set; }
        public string Prdct_Desc { get; set; }
        

    }
}

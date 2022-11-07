using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTheSuccess.Domain.Entities
{
    public class Process : BaseEntity
    {
        public string Prdct_Brcd { get; set; } // prdct_id alanı da olabilir???
        public string Receipt_No { get; set; }
        public int Emp_ID { get; set; }
        public int Branch_ID { get; set; }
        public decimal Prdct_Unit_Price { get; set; } // product_price tablosundan alınacak

        public string Prdct_Price_Currency { get; set; } // product_price tablosundan alınacak
        public int Sale_Guantity { get; set; }
        public decimal Sale_Amount { get; set; } // bir ürünün satış fiyatı
        public decimal Sale_Total_Amount { get; set; } // bir satıştaki toplam satış tutarı
        public int Sales_Type_ID { get; set; }
        public string Old_Receipt_No { get; set; }

        public string Process_Desc { get; set; }
    }
}

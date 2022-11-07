using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTheSuccess.Domain.Entities
{
    public class SupplierProducts : BaseEntity
    {
        public int Supplier_ID { get; set; }
        public string Splr_Prdct_Brcd { get; set; }
        public string Splr_Prdct_Cd { get; set; }
        public int Order_No { get; set; }
        public string Prdct_Name { get; set; }
        public string Prdct_Color { get; set; }
        public string Prdct_Size { get; set; }
        public string Prdct_Quantity { get; set; }
        public decimal Prdct_Unit_Price { get; set; }
        public string Prdct_Currency { get; set; }
        public string Sender { get; set; }
        public DateTime Shipping_Dt { get; set; } // sevkiyat diye ayrı tablo olacak
    }
}

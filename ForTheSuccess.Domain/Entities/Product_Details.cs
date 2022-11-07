﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTheSuccess.Domain.Entities
{
    public class ProductDetails : BaseEntity 
    {
        public string Prdct_Brcd { get; set; }
        public string Prdct_Cd { get; set; }
        public int Categori_ID { get; set; }
        public int Branch_ID { get; set; }
        public int Supplier_ID { get; set; }
        public int Employee_ID { get; set; } // receiver için
        public string Prdct_Name { get; set; }
        public string Prdct_Brand { get; set; }
        public string Prdct_Color { get; set; }
        public string Prdct_Size { get; set; }
        public string Prdct_Quantity { get; set; }
        public string Prdct_Unit_Price { get; set; }
        public string Prdct_Currency { get; set; }
        public string Prdct_Model_No { get; set; }
        public DateTime Prdct_Recieved_Dt { get; set; }
        public string Prdct_Material { get; set; }
        public string Prdct_Articel { get; set; }
        public string Prdct_Garni { get; set; }
        public string Prdct_Garni_Color { get; set; }
        public string Prdct_Season { get; set; }

    }
}

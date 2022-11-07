using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTheSuccess.Domain.Entities
{
    public class Suppliers : BaseEntity
    {
        public string Company_Name { get; set; }
        public string Supplier_Name { get; set; } // kişi ismi
        public string Supplier_Phone { get; set; }
        public string Supplier_Email { get; set; }
        public string Company_Address { get; set; }
        public string Company_Desc { get; set; }
    }
    }

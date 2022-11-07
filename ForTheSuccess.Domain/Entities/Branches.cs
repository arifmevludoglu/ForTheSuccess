using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTheSuccess.Domain.Entities
{
    public class Branches : BaseEntity
    {
        public string Branch_Name { get; set; }

        public int Country_ID { get; set; }

        public int City_ID { get; set; }

        public string Currency { get; set; }

        public string Branch_Address { get; set; }

        public string Branch_Phone { get; set; }

        public string Branch_Email { get; set; }

        public string Branch_Desc { get; set; }
    }
}

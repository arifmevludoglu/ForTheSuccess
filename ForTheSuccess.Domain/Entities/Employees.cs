using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTheSuccess.Domain.Entities
{
    public class Employees : BaseEntity 
    {
        public string Emp_Name { get; set; }
        public string Emp_Surname { get; set; }
        public int Branch_ID { get; set; }
        public string Emp_Phone { get; set; }

        public DateTime Emp_Sdt { get; set; } 

        public DateTime Emp_Edt { get; set; }
        public string Emp_Email { get; set; }

        public DateTime Emp_Insert_Dt { get; set; }

        public DateTime Emp_Update_Dt { get; set; }
    }
}

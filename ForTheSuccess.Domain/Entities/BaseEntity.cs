using ForTheSuccess.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTheSuccess.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public int DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public EuIsDeleted IsDeleted { get; set; } = EuIsDeleted.No;
    }
}

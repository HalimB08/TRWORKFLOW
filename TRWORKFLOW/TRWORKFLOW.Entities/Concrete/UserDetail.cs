using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRWORKFLOW.Entities.Concrete
{
    public class UserDetail
    {
        public int ID { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Department { get; set; }
        public string? Profession { get; set; }
        public DateTime EmploymentStartDate { get; set; }
        public DateTime EmploymentEndDate { get; set; }
        public string? EmployeeClass { get; set; }
    }
}

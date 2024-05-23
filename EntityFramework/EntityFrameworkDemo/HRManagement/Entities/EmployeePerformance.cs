using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.Entities
{
    public class EmployeePerformance
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Test {  get; set; }
        public string Communication { get; set; }
        public string Cognition { get; set; }
        public string Interview { get; set; }

    }
}

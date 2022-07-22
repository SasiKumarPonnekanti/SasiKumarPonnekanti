using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public int ContactNo { get; set; }
        public string? Education { get; set; }
        public int ShiftStartTime { get; set; }
        public int ShiftEndTime { get; set; }
        protected int BasicPay { get; set; }
    }
}

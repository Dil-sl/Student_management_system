using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management_system.Models
{
    public class AttendanceModel
    {
        public int AttendanceID { get; set; }
        public int ClassID { get; set; }
        public DateTime Date { get; set; }
        public int StudentID { get; set; }
        public string Status { get; set; }
    }
}

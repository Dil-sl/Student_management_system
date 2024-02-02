using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management_system.Models
{
    public class StudentModel
    {
        public int StudentID { get; set; }
        public string RegNo { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string GuardianName { get; set; }
        public string GuardianContactNumber { get; set; }
        public string Class { get; set; }
    }
}

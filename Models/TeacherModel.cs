using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management_system.Models
{
    public class TeacherModel
    {
        public int TeacherID { get; set; }
        public string FullName { get; set; }
        public DateTime DOB { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Subjects { get; set; }
        public string OwnedClass { get; set; }

        // for UI needs 
        public int UserID { get; set; }
        public string Username { get; set; }
        public string UserType { get; set; }

    }
}

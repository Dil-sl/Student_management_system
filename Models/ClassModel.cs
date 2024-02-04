using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management_system.Models
{
    public class ClassModel
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        //join purpose only
        public string TeacherName { get; set; }
        public int? TeacherID { get; set; }
    }
}

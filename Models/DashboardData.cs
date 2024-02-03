using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management_system.Models
{
    public class DashboardData
    {
        public int TotalClasses { get; set; }
        public int TotalTeachers { get; set; }
        public int TotalStudents { get; set; }
        public int TotalStudentUsers { get; set; }
        public int TotalTeacherUsers { get; set; }
        public int TodayAttendance { get; set; }
        public int TotalAnnouncements { get; set; }
        public int ClassesWithAttendance { get; set; }
        public int ClassesWithCompleteAttendance { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management_system.Models
{
    public class NoticeboardModel
    {
        public int NoticeID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int PostedBy { get; set; }
        public DateTime PostedDate { get; set; }
        public DateTime ExpiredDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherAttendance.model
{
    class Attendance
    {

        public int TeacherId { get; set; }
        public int CourseId { get; set; }
        public int RoomId { get; set; }
        public String StartTime { get; set; }
        public String LeaveTime { get; set; }
        public String Comment { get; set; }
        public String Date { get; set; }

        public Attendance(int t_id, int c_id, int r_id, string start, string leave, string Comment, string date)
        {
            this.TeacherId = t_id;
            this.CourseId = c_id;
            this.RoomId = r_id;
            this.StartTime = start;
            this.LeaveTime = leave;
            this.Comment = Comment;
            this.Date = date; 
        }

    }
}

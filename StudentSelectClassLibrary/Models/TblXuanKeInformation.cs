using System;
using System.Collections.Generic;

namespace StudentSelectClass.Models
{
    public partial class TblXuanKeInformation
    {
        public int StuCourseId { get; set; }
        public string StudentNum { get; set; }
        public string CourseNum { get; set; }
        public string TeacherNum { get; set; }
        public double Grade { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreateTime { get; set; }
        public string ModifyBy { get; set; }
        public DateTime ModifyTime { get; set; }
        public string DeleteBy { get; set; }
        public DateTime? DeleteTime { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] Version { get; set; }
    }
}

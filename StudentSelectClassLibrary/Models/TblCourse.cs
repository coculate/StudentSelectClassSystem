using System;

namespace StudentSelectClassLibrary.Models
{
    public partial class TblCourse
    {
        public int CourseId { get; set; }
        public string CourseNum { get; set; }
        public string CourseName { get; set; }
        public double CourseCredit { get; set; }
        public int CourseClass { get; set; }
        public string CourseDesc { get; set; }
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

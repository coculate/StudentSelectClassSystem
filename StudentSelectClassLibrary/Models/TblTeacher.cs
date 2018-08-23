using System;
using System.Collections.Generic;

namespace StudentSelectClass.Models
{
    public partial class TblTeacher
    {
        public int TeacherId { get; set; }
        public string TeacherNum { get; set; }
        public string DeptNum { get; set; }
        public string TeacherName { get; set; }
        public string TeacherSex { get; set; }
        public DateTime TeacherBirthday { get; set; }
        public string TeacherTitle { get; set; }
        public string TeacherPassword { get; set; }
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

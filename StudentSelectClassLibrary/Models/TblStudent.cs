using System;
using System.Collections.Generic;

namespace StudentSelectClass.Models
{
    public partial class TblStudent
    {
        public int StudentId { get; set; }
        public string StudentNum { get; set; }
        public string StudentName { get; set; }
        public string MajorNum { get; set; }
        public string StudentSex { get; set; }
        public DateTime StudentBirthday { get; set; }
        public string StudentPassword { get; set; }
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

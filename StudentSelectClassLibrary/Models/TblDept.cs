using System;
using System.Collections.Generic;

namespace StudentSelectClassLibrary.Models
{
    public partial class TblDept
    {
        public int DeptId { get; set; }
        public string DeptNum { get; set; }
        public string DeptName { get; set; }
        public string DeptChairman { get; set; }
        public string DeptTel { get; set; }
        public string DeptDesc { get; set; }
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

using System;
using System.Collections.Generic;

namespace StudentSelectClassLibrary.Models
{
    public partial class TblManager
    {
        public int ManagerId { get; set; }
        public string ManagerNum { get; set; }
        public string ManagerName { get; set; }
        public string ManagerSex { get; set; }
        public DateTime ManagerBirthday { get; set; }
        public string ManagerPassword { get; set; }
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

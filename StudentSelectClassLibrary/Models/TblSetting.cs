﻿using System;
using System.Collections.Generic;

namespace StudentSelectClassLibrary.Models
{
    public partial class TblSetting
    {
        public int Id { get; set; }
        public string IfTakeCourse { get; set; }
        public string IfInputGrade { get; set; }
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

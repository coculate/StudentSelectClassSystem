﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace StudentSelectClass.Dtos {
    /// <summary>
    /// 学生信息传输类
    /// </summary>
    [DataContract]
    public class TblStudentDto {
        /// <summary>
        /// 主键ID
        /// </summary>
        [DataMember]
        public int StudentId { get; set; }

        /// <summary>
        /// 学生号码
        /// </summary>
        [DataMember]
        public string StudentNum { get; set; }

        /// <summary>
        /// 学生姓名
        /// </summary>
        [DataMember]
        public string StudentName { get; set; }

        /// <summary>
        /// 专业编号
        /// </summary>
        [DataMember]
        public string MajorNum { get; set; }

        /// <summary>
        /// 学生性别
        /// </summary>
        [DataMember]
        public string StudentSex { get; set; }

        /// <summary>
        /// 学生生日
        /// </summary>
        [DataMember]
        public DateTime StudentBirthday { get; set; }

        /// <summary>
        /// 学生密码
        /// </summary>
        [DataMember]
        public string StudentPassword { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        /// <value></value>
        [DataMember]
        public string CreatedBy { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        /// <value></value>
        [DataMember]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        /// <value></value>
        [DataMember]
        public string ModifyBy { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        /// <value></value>
        [DataMember]
        public DateTime ModifyTime { get; set; }

        /// <summary>
        /// 删除人
        /// </summary>
        /// <value></value>
        [DataMember]
        public string DeleteBy { get; set; }

        /// <summary>
        /// 删除时间
        /// </summary>
        /// <value></value>
        [DataMember]
        public DateTime? DeleteTime { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        /// <value></value>
        [DataMember]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        /// <value></value>
        [DataMember]
        public byte[] Version { get; set; }
    }
}
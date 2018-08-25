using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace StudentSelectClassLibrary.Dtos {
    /// <summary>
    /// 教师传输类
    /// </summary>
    [DataContract]
    public class TblTeacherDto {
        /// <summary>
        /// 主键ID
        /// </summary>
        [DataMember]
        public int TeacherId { get; set; }

        /// <summary>
        /// 教师编号
        /// </summary>
        [DataMember]
        public string TeacherNum { get; set; }

        /// <summary>
        /// 院系号码
        /// </summary>
        [DataMember]
        public string DeptNum { get; set; }

        /// <summary>
        /// 教师姓名
        /// </summary>
        [DataMember]
        public string TeacherName { get; set; }

        /// <summary>
        /// 教师性别
        /// </summary>
        [DataMember]
        public string TeacherSex { get; set; }

        /// <summary>
        /// 教师生日
        /// </summary>
        [DataMember]
        public DateTime TeacherBirthday { get; set; }

        /// <summary>
        /// 教师职称
        /// </summary>
        [DataMember]
        public string TeacherTitle { get; set; }

        /// <summary>
        /// 教师密码
        /// </summary>
        [DataMember]
        public string TeacherPassword { get; set; }

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
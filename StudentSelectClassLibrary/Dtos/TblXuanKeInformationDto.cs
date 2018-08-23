using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace StudentSelectClass.Dtos {
    /// <summary>
    /// 选课信息传输类
    /// </summary>
    [DataContract]
    public class TblXuanKeInformationDto {
        /// <summary>
        /// 主键ID
        /// </summary>
        [DataMember]
        public int StuCourseId { get; set; }

        /// <summary>
        /// 学生号码
        /// </summary>
        [DataMember]
        public string StudentNum { get; set; }

        /// <summary>
        /// 课程号码
        /// </summary>
        [DataMember]
        public string CourseNum { get; set; }

        /// <summary>
        /// 教师号码
        /// </summary>
        [DataMember]
        public string TeacherNum { get; set; }

        /// <summary>
        /// 成绩
        /// </summary>
        [DataMember]
        public double Grade { get; set; }

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
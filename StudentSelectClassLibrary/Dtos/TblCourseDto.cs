using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace StudentSelectClass.Dtos {
    /// <summary>
    /// 课程传输类
    /// </summary>
    [DataContract]
    public class TblCourseDto {
        /// <summary>
        /// 课程编号
        /// </summary>
        /// <value></value>
        [DataMember]
        public int CourseId { get; set; }

        /// <summary>
        /// 课程课时
        /// </summary>
        /// <value></value>
        [DataMember]
        public string CourseNum { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>
        /// <value></value>
        [DataMember]
        public string CourseName { get; set; }

        /// <summary>
        /// 课程学分
        /// </summary>
        /// <value></value>
        [DataMember]
        public double CourseCredit { get; set; }

        /// <summary>
        /// 课程班级
        /// </summary>
        /// <value></value>
        [DataMember]
        public int CourseClass { get; set; }

        /// <summary>
        /// 课程描述
        /// </summary>
        /// <value></value>
        [DataMember]
        public string CourseDesc
        { get; set; }

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

        /// <summary>
        /// 班级名称
        /// </summary>
        [DataMember]
        public string ClassName { get; set; }
    }
}
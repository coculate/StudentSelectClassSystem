using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace StudentSelectClassLibrary.Dtos {
    /// <summary>
    /// 设置传输类
    /// </summary>
    [DataContract]
    public class TblSettingDto {
        /// <summary>
        /// 主键ID
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// 选课控制（取“0”或“1”）
        /// </summary>
        [DataMember]
        public string IfTakeCourse { get; set; }

        /// <summary>
        /// 成绩录入控制（取“0”或“1”）
        /// </summary>
        [DataMember]
        public string IfInputGrade { get; set; }

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
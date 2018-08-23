using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace StudentXuanKeSystem.Dtos {
    /// <summary>
    /// 专业传输类
    /// </summary>
    [DataContract]
    public class TblMajorDto {
        /// <summary>
        /// 主键ID
        /// </summary>
        [DataMember]
        public int MajorId { get; set; }

        /// <summary>
        /// 专业号码
        /// </summary>
        [DataMember]
        public string MajorNum { get; set; }

        /// <summary>
        /// 院系号码
        /// </summary>
        [DataMember]
        public string DeptNum { get; set; }

        /// <summary>
        /// 专业名称
        /// </summary>
        [DataMember]
        public string MajorName { get; set; }

        /// <summary>
        /// 辅导员
        /// </summary>
        [DataMember]
        public string MajorAssistant { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        [DataMember]
        public string MajorTel { get; set; }

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
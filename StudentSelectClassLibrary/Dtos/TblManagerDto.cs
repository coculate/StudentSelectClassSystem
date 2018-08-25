using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace StudentSelectClassLibrary.Dtos
{
    /// <summary>
    /// 管理员传输类
    /// </summary>
    [DataContract]
    public class TblManagerDto
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        [DataMember]
        public int ManagerId { get; set; }

        /// <summary>
        /// 管理员编号
        /// </summary>
        [DataMember]
        public string ManagerNum { get; set; }

        /// <summary>
        /// 管理员名称
        /// </summary>
        [DataMember]
        public string ManagerName { get; set; }

        /// <summary>
        /// 管理员性别
        /// </summary>
        [DataMember]
        public string ManagerSex { get; set; }

        /// <summary>
        /// 管理员生日
        /// </summary>
        [DataMember]
        public DateTime ManagerBirthday { get; set; }

        /// <summary>
        /// 管理员密码
        /// </summary>
        [DataMember]
        public string ManagerPassword { get; set; }

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

using StudentSelectClass.Models;
using StudentSelectClass.Dtos;

namespace StudentSelectClass.DA
{
    public class CourseDa
    {
        /// <summary>
        /// 上下文连接
        /// </summary>
        public XuanKeDBContext XuanKeDB { get; set; }

        #region 增
        public void AddCourse(TblCourseDto dto)
        {
            var entity = dto.ToEntity();
            XuanKeDB.Add(entity);
            XuanKeDB.SaveChanges();
        }
        #endregion

        #region 删

        #endregion

        #region 改

        #endregion

        #region 查

        #endregion
    }
}

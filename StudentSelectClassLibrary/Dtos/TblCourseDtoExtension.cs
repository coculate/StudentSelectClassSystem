using StudentSelectClass.Models;
using StudentXuanKeSystem.Dtos;

namespace StudentSelectClass.Dtos {
    public static class TblCourseDtoExtension {
        public static TblCourse ToEntity (this TblCourseDto dto) {
            if (dto == null) {
                return new TblCourse ();
            }
            return new TblCourse {
                    CourseId = dto.CourseId,
                    CourseClass = dto.CourseClass,
                    CourseCredit = dto.CourseCredit,
                    CourseDesc = dto.CourseDesc,
                    CourseName = dto.CourseName,
                    CourseNum = dto.CourseNum,
                    CreatedBy = dto.CreatedBy,
                    CreateTime = dto.CreateTime,
                    ModifyBy = dto.ModifyBy,
                    ModifyTime = dto.ModifyTime,
                    DeleteBy = dto.DeleteBy,
                    DeleteTime = dto.DeleteTime,
                    IsDeleted = dto.IsDeleted,
                    Version = dto.Version
            };
        }

        public static TblCourseDto ToDto (this TblCourse entity) {
            if (entity == null) {
                return new TblCourseDto ();
            }
            return new TblCourseDto {
                    CourseId = entity.CourseId,
                    CourseClass = entity.CourseClass,
                    CourseCredit = entity.CourseCredit,
                    CourseDesc = entity.CourseDesc,
                    CourseName = entity.CourseName,
                    CourseNum = entity.CourseNum,
                    CreatedBy = entity.CreatedBy,
                    CreateTime = entity.CreateTime,
                    ModifyBy = entity.ModifyBy,
                    ModifyTime = entity.ModifyTime,
                    DeleteBy = entity.DeleteBy,
                    DeleteTime = entity.DeleteTime,
                    IsDeleted = entity.IsDeleted,
                    Version = entity.Version
            };
        }
    }
}
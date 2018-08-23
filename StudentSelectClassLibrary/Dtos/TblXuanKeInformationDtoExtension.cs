using StudentSelectClass.Models;
using StudentXuanKeSystem.Dtos;

namespace StudentSelectClass.Dtos {
    public static class TblXuanKeInformationDtoExtension {
        public static TblXuanKeInformation ToEntity (this TblXuanKeInformationDto dto) {
            if (dto == null) {
                return new TblXuanKeInformation ();
            }
            return new TblXuanKeInformation {
                StuCourseId = dto.StuCourseId,
                    StudentNum = dto.StudentNum,
                    CourseNum = dto.CourseNum,
                    TeacherNum = dto.TeacherNum,
                    Grade = dto.Grade,
                    CreateTime = dto.CreateTime,
                    CreatedBy = dto.CreatedBy,
                    ModifyBy = dto.ModifyBy,
                    ModifyTime = dto.ModifyTime,
                    DeleteBy = dto.DeleteBy,
                    DeleteTime = dto.DeleteTime,
                    IsDeleted = dto.IsDeleted,
                    Version = dto.Version
            };
        }

        public static TblXuanKeInformationDto ToDto (this TblXuanKeInformation entity) {
            if (entity == null) {
                return new TblXuanKeInformationDto ();
            }
            return new TblXuanKeInformationDto {
                StuCourseId = entity.StuCourseId,
                    StudentNum = entity.StudentNum,
                    CourseNum = entity.CourseNum,
                    TeacherNum = entity.TeacherNum,
                    Grade = entity.Grade,
                    CreateTime = entity.CreateTime,
                    CreatedBy = entity.CreatedBy,
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
using StudentSelectClassLibrary.Models;

namespace StudentSelectClassLibrary.Dtos
{
    public static class TblTeacherDtoExtension {
        public static TblTeacher ToEntity (this TblTeacherDto dto) {
            if (dto == null) {
                return new TblTeacher ();
            }
            return new TblTeacher {
                TeacherId = dto.TeacherId,
                    TeacherBirthday = dto.TeacherBirthday,
                    TeacherName = dto.TeacherName,
                    TeacherNum = dto.TeacherNum,
                    TeacherPassword = dto.TeacherPassword,
                    TeacherSex = dto.TeacherSex,
                    TeacherTitle = dto.TeacherTitle,
                    DeptNum = dto.DeptNum,
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

        public static TblTeacherDto ToDto (this TblTeacher entity) {
            if (entity == null) {
                return new TblTeacherDto ();
            }
            return new TblTeacherDto {
                TeacherId = entity.TeacherId,
                    TeacherBirthday = entity.TeacherBirthday,
                    TeacherName = entity.TeacherName,
                    TeacherNum = entity.TeacherNum,
                    TeacherPassword = entity.TeacherPassword,
                    TeacherSex = entity.TeacherSex,
                    TeacherTitle = entity.TeacherTitle,
                    DeptNum = entity.DeptNum,
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
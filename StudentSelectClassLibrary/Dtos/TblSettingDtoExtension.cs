using StudentSelectClass.Models;
using StudentXuanKeSystem.Dtos;

namespace StudentSelectClass.Dtos {
    public static class TblSettingDtoExtension {
        public static TblSetting ToEntity (this TblSettingDto dto) {
            if (dto == null) {
                return new TblSetting ();
            }
            return new TblSetting {
                Id = dto.Id,
                    IfTakeCourse = dto.IfTakeCourse,
                    IfInputGrade = dto.IfInputGrade,
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

        public static TblSettingDto ToDto (this TblSetting entity) {
            if (entity == null) {
                return new TblSettingDto ();
            }
            return new TblSettingDto {
                Id = entity.Id,
                    IfTakeCourse = entity.IfTakeCourse,
                    IfInputGrade = entity.IfInputGrade,
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
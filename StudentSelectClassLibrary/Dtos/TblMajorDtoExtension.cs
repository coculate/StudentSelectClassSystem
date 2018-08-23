using StudentSelectClass.Models;
using StudentXuanKeSystem.Dtos;

namespace StudentSelectClass.Dtos {
    public static class TblMajorDtoExtension {
        public static TblMajor ToEntity (this TblMajorDto dto) {
            if (dto == null) {
                return new TblMajor ();
            }
            return new TblMajor {
                MajorId = dto.MajorId,
                    MajorNum = dto.MajorNum,
                    DeptNum = dto.DeptNum,
                    MajorName = dto.MajorName,
                    MajorAssistant = dto.MajorAssistant,
                    MajorTel = dto.MajorTel,
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

        public static TblMajorDto ToDto (this TblMajor entity) {
            if (entity == null) {
                return new TblMajorDto ();
            }
            return new TblMajorDto {
                MajorId = entity.MajorId,
                    MajorNum = entity.MajorNum,
                    DeptNum = entity.DeptNum,
                    MajorName = entity.MajorName,
                    MajorAssistant = entity.MajorAssistant,
                    MajorTel = entity.MajorTel,
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
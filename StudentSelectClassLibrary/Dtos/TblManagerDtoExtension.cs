using StudentSelectClassLibrary.Models;

namespace StudentSelectClassLibrary.Dtos
{
    public static class TblManagerDtoExtension {
        public static TblManager ToEntity (this TblManagerDto dto) {
            if (dto == null) {
                return new TblManager ();
            }
            return new TblManager {
                ManagerId = dto.ManagerId,
                    ManagerBirthday = dto.ManagerBirthday,
                    ManagerName = dto.ManagerName,
                    ManagerNum = dto.ManagerNum,
                    ManagerPassword = dto.ManagerPassword,
                    ManagerSex = dto.ManagerSex,
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

        public static TblManagerDto ToDto (this TblManager entity) {
            if (entity == null) {
                return new TblManagerDto ();
            }
            return new TblManagerDto {
                ManagerId = entity.ManagerId,
                    ManagerBirthday = entity.ManagerBirthday,
                    ManagerName = entity.ManagerName,
                    ManagerNum = entity.ManagerNum,
                    ManagerPassword = entity.ManagerPassword,
                    ManagerSex = entity.ManagerSex,
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
using StudentSelectClass.Models;
using StudentXuanKeSystem.Dtos;

namespace StudentSelectClass.Dtos {
    public static class TBlDeptDtoExtension {
        public static TblDept ToEntity (this TblDeptDto dto) {
            if (dto == null) {
                return new TblDept ();
            }
            return new TblDept {
                    DeptId = dto.DeptId,
                    DeptNum = dto.DeptNum,
                    DeptName = dto.DeptName,
                    DeptChairman = dto.DeptChairman,
                    DeptTel = dto.DeptTel,
                    DeptDesc = dto.DeptDesc,
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

        public static TblDeptDto ToDto (this TblDept entity) {
            if (entity == null) {
                return new TblDeptDto ();
            }
            return new TblDeptDto {
                    DeptId = entity.DeptId,
                    DeptNum = entity.DeptNum,
                    DeptName = entity.DeptName,
                    DeptChairman = entity.DeptChairman,
                    DeptTel = entity.DeptTel,
                    DeptDesc = entity.DeptDesc,
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
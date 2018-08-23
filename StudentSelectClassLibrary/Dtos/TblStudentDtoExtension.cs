using System;
using System.Collections.Generic;
using System.Text;
using StudentSelectClass.Models;
using StudentXuanKeSystem.Dtos;

namespace StudentSelectClass.Dtos {
    public static class TblStudentDtoExtension {
        /// <summary>
        /// 转化为实体
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public static TblStudent ToEntity (this TblStudentDto dto) {
            if (dto == null) {
                return new TblStudent ();
            }
            return new TblStudent {
                StudentId = dto.StudentId,
                    StudentBirthday = dto.StudentBirthday,
                    StudentName = dto.StudentName,
                    StudentNum = dto.StudentNum,
                    StudentPassword = dto.StudentPassword,
                    StudentSex = dto.StudentSex,
                    MajorNum = dto.MajorNum,
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

        public static TblStudentDto ToDto (this TblStudent entity) {
            if (entity == null) {
                return new TblStudentDto ();
            }
            return new TblStudentDto {
                StudentId = entity.StudentId,
                    StudentBirthday = entity.StudentBirthday,
                    StudentName = entity.StudentName,
                    StudentNum = entity.StudentNum,
                    StudentPassword = entity.StudentPassword,
                    StudentSex = entity.StudentSex,
                    MajorNum = entity.MajorNum,
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
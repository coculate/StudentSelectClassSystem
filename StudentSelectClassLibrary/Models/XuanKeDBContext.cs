using Microsoft.EntityFrameworkCore;

namespace StudentSelectClass.Models
{
    public partial class XuanKeDBContext : DbContext
    {
        public virtual DbSet<TblCourse> TblCourse { get; set; }
        public virtual DbSet<TblDept> TblDept { get; set; }
        public virtual DbSet<TblMajor> TblMajor { get; set; }
        public virtual DbSet<TblManager> TblManager { get; set; }
        public virtual DbSet<TblSetting> TblSetting { get; set; }
        public virtual DbSet<TblStudent> TblStudent { get; set; }
        public virtual DbSet<TblTeacher> TblTeacher { get; set; }
        public virtual DbSet<TblXuanKeInformation> TblXuanKeInformation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //                optionsBuilder.UseSqlServer(@"Server=.;Database=XuanKeDB;Trusted_Connection=True;");
            }
        }

        public XuanKeDBContext(DbContextOptions<XuanKeDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCourse>(entity =>
            {
                entity.HasKey(e => e.CourseId);

                entity.ToTable("TblCourse");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.CourseName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CourseNum)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeleteBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyBy).HasMaxLength(50);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Version).IsRowVersion();
            });

            modelBuilder.Entity<TblDept>(entity =>
            {
                entity.HasKey(e => e.DeptId);

                entity.ToTable("TblDept");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeleteBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.DeptChairman)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DeptNum)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeptTel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifyBy).HasMaxLength(50);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Version).IsRowVersion();
            });

            modelBuilder.Entity<TblMajor>(entity =>
            {
                entity.HasKey(e => e.MajorId);

                entity.ToTable("TblMajor");

                entity.Property(e => e.MajorId).HasColumnName("MajorID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeleteBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.DeptNum)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MajorAssistant)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MajorName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MajorNum)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MajorTel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifyBy).HasMaxLength(50);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Version).IsRowVersion();
            });

            modelBuilder.Entity<TblManager>(entity =>
            {
                entity.HasKey(e => e.ManagerId);

                entity.ToTable("TblManager");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeleteBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.ManagerBirthday).HasColumnType("datetime");

                entity.Property(e => e.ManagerName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ManagerNum)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ManagerPassword)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ManagerSex)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifyBy).HasMaxLength(50);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Version).IsRowVersion();
            });

            modelBuilder.Entity<TblSetting>(entity =>
            {
                entity.ToTable("TblSetting");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeleteBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.IfInputGrade)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IfTakeCourse)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifyBy).HasMaxLength(50);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.Version).IsRowVersion();
            });

            modelBuilder.Entity<TblStudent>(entity =>
            {
                entity.HasKey(e => e.StudentId);

                entity.ToTable("TblStudent");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeleteBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.MajorNum)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifyBy).HasMaxLength(50);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.StudentBirthday).HasColumnType("datetime");

                entity.Property(e => e.StudentName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StudentNum)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StudentPassword)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StudentSex).IsRequired();

                entity.Property(e => e.Version).IsRowVersion();
            });

            modelBuilder.Entity<TblTeacher>(entity =>
            {
                entity.HasKey(e => e.TeacherId);

                entity.ToTable("TblTeacher");

                entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeleteBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.DeptNum)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifyBy).HasMaxLength(50);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.TeacherBirthday).HasColumnType("datetime");

                entity.Property(e => e.TeacherName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TeacherNum)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TeacherPassword)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TeacherSex)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TeacherTitle)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Version).IsRowVersion();
            });

            modelBuilder.Entity<TblXuanKeInformation>(entity =>
            {
                entity.HasKey(e => e.StuCourseId);

                entity.ToTable("TblXuanKeInformation");

                entity.Property(e => e.StuCourseId).HasColumnName("StuCourseID");

                entity.Property(e => e.CourseNum)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeleteBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyBy).HasMaxLength(50);

                entity.Property(e => e.ModifyTime).HasColumnType("datetime");

                entity.Property(e => e.StudentNum)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TeacherNum)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Version).IsRowVersion();
            });
        }
    }
}

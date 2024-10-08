﻿// <auto-generated />
using System;
using FaskhutdinovMikhailKT_31_21.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FaskhutdinovMikhailKT_31_21.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241004171406_CreateDatabase")]
    partial class CreateDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FaskhutdinovMikhailKT_31_21.Models.AcademicDegree", b =>
                {
                    b.Property<int>("AcademicDegreeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("academic_degree_id")
                        .HasComment("Идентификатор ученой степени");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AcademicDegreeId"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar")
                        .HasColumnName("c_title")
                        .HasComment("Название ученой степени");

                    b.HasKey("AcademicDegreeId")
                        .HasName("pk_cs_academic_degree_academic_degree_id");

                    b.ToTable("cs_academic_degree", (string)null);
                });

            modelBuilder.Entity("FaskhutdinovMikhailKT_31_21.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("department_id")
                        .HasComment("Идентификатор кафедры");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<int?>("HeadId")
                        .HasColumnType("int")
                        .HasColumnName("f_head_id")
                        .HasComment("Идентификатор главы кафедры");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar")
                        .HasColumnName("c_name")
                        .HasComment("Название кафедры");

                    b.HasKey("DepartmentId")
                        .HasName("pk_cs_department_department_id");

                    b.HasIndex("HeadId")
                        .IsUnique()
                        .HasFilter("[f_head_id] IS NOT NULL");

                    b.HasIndex(new[] { "HeadId" }, "idx_head_id");

                    b.ToTable("cs_department", (string)null);
                });

            modelBuilder.Entity("FaskhutdinovMikhailKT_31_21.Models.Discipline", b =>
                {
                    b.Property<int>("DisciplineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("discipline_id")
                        .HasComment("Идентификатор дисциплины");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DisciplineId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar")
                        .HasColumnName("c_name")
                        .HasComment("Название дисциплины");

                    b.HasKey("DisciplineId")
                        .HasName("pk_cs_discipline_discipline_id");

                    b.ToTable("cs_discipline", (string)null);
                });

            modelBuilder.Entity("FaskhutdinovMikhailKT_31_21.Models.Position", b =>
                {
                    b.Property<int>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("position_id")
                        .HasComment("Идентификатор должности");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PositionId"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar")
                        .HasColumnName("c_title")
                        .HasComment("Название должности");

                    b.HasKey("PositionId")
                        .HasName("pk_cs_position_position_id");

                    b.ToTable("cs_position", (string)null);
                });

            modelBuilder.Entity("FaskhutdinovMikhailKT_31_21.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("teacher_id")
                        .HasComment("Идентификатор преподавателя");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"));

                    b.Property<int?>("AcademicDegreeId")
                        .HasColumnType("int")
                        .HasColumnName("f_academic_degree_id")
                        .HasComment("Идентификатор ученой степени");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int")
                        .HasColumnName("f_department_id")
                        .HasComment("Идентификатор кафедры");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar")
                        .HasColumnName("c_firstname")
                        .HasComment("Фамилия преподавателя");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar")
                        .HasColumnName("c_lastname")
                        .HasComment("Имя преподавателя");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar")
                        .HasColumnName("c_patronymic")
                        .HasComment("Отчество преподавателя");

                    b.Property<int?>("PositionId")
                        .HasColumnType("int")
                        .HasColumnName("f_position_id")
                        .HasComment("Идентификатор должности");

                    b.HasKey("TeacherId")
                        .HasName("pk_cd_teacher_teacher_id");

                    b.HasIndex(new[] { "AcademicDegreeId" }, "idx_academic_degree_id");

                    b.HasIndex(new[] { "DepartmentId" }, "idx_department_id");

                    b.HasIndex(new[] { "PositionId" }, "idx_position_id");

                    b.ToTable("cd_teacher", (string)null);
                });

            modelBuilder.Entity("FaskhutdinovMikhailKT_31_21.Models.TeacherDiscipline", b =>
                {
                    b.Property<int?>("DisciplineId")
                        .HasColumnType("int")
                        .HasColumnName("f_discipline_id")
                        .HasComment("Идентификатор дисциплины");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("int")
                        .HasColumnName("f_teacher_id")
                        .HasComment("Идентификатор преподавателя");

                    b.Property<int>("WorkloadHours")
                        .HasColumnType("int")
                        .HasColumnName("n_workload_hours")
                        .HasComment("Рабочие часы");

                    b.HasKey("DisciplineId", "TeacherId")
                        .HasName("pk_cd_teacher_discipline_teacher_discipline_id");

                    b.HasIndex(new[] { "DisciplineId" }, "idx_discipline_id");

                    b.HasIndex(new[] { "TeacherId" }, "idx_teacher_id");

                    b.ToTable("cd_teacher_discipline", (string)null);
                });

            modelBuilder.Entity("FaskhutdinovMikhailKT_31_21.Models.Department", b =>
                {
                    b.HasOne("FaskhutdinovMikhailKT_31_21.Models.Teacher", "Head")
                        .WithOne()
                        .HasForeignKey("FaskhutdinovMikhailKT_31_21.Models.Department", "HeadId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("fk_f_head_id");

                    b.Navigation("Head");
                });

            modelBuilder.Entity("FaskhutdinovMikhailKT_31_21.Models.Teacher", b =>
                {
                    b.HasOne("FaskhutdinovMikhailKT_31_21.Models.AcademicDegree", "AcademicDegree")
                        .WithMany()
                        .HasForeignKey("AcademicDegreeId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("fk_f_academic_degree_id");

                    b.HasOne("FaskhutdinovMikhailKT_31_21.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("fk_f_department_id");

                    b.HasOne("FaskhutdinovMikhailKT_31_21.Models.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("fk_f_position_id");

                    b.Navigation("AcademicDegree");

                    b.Navigation("Department");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("FaskhutdinovMikhailKT_31_21.Models.TeacherDiscipline", b =>
                {
                    b.HasOne("FaskhutdinovMikhailKT_31_21.Models.Discipline", "Discipline")
                        .WithMany()
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_f_discipline_id");

                    b.HasOne("FaskhutdinovMikhailKT_31_21.Models.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_f_teacher_id");

                    b.Navigation("Discipline");

                    b.Navigation("Teacher");
                });
#pragma warning restore 612, 618
        }
    }
}

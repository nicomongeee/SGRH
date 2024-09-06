﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SGRH.Web.Models.Data;

#nullable disable

namespace SGRH.Web.Migrations
{
    [DbContext(typeof(SgrhContext))]
    [Migration("20240330060109_AddOrdinarySalary")]
    partial class AddOrdinarySalary
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SGRH.Web.Models.Entities.Absence", b =>
                {
                    b.Property<int>("AbsenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AbsenceId"));

                    b.Property<int?>("AbsenceCategoryId_Absence_Category")
                        .HasColumnType("int");

                    b.Property<string>("Absence_Comments")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("End_Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Start_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("AbsenceId");

                    b.HasIndex("AbsenceCategoryId_Absence_Category");

                    b.HasIndex("UserId");

                    b.ToTable("Absences");
                });

            modelBuilder.Entity("SGRH.Web.Models.Entities.AbsenceCategory", b =>
                {
                    b.Property<int>("Id_Absence_Category")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Absence_Category"));

                    b.Property<string>("Category_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id_Absence_Category");

                    b.ToTable("AbsenceCategories");
                });

            modelBuilder.Entity("SGRH.Web.Models.Entities.Attendance", b =>
                {
                    b.Property<int>("Id_Attendance")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Attendance"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EntryTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ExitTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id_Attendance");

                    b.HasIndex("UserId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("SGRH.Web.Models.Entities.BenefitsLiquidation", b =>
                {
                    b.Property<int>("Id_Benefit")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Benefit"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Benefit_Type")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Deductions")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Net_Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("PersonalActionId_Action")
                        .HasColumnType("int");

                    b.Property<decimal>("Taxes")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id_Benefit");

                    b.HasIndex("PersonalActionId_Action");

                    b.ToTable("BenefitsLiquidations");
                });

            modelBuilder.Entity("SGRH.Web.Models.Entities.Department", b =>
                {
                    b.Property<int>("Id_Department")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Department"));

                    b.Property<string>("Department_Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id_Department");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("SGRH.Web.Models.Entities.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AbsenceId")
                        .HasColumnType("int");

                    b.Property<byte[]>("Content")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DossierId_Record")
                        .HasColumnType("int");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<long>("Size")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AbsenceId");

                    b.HasIndex("DossierId_Record");

                    b.ToTable("Document");
                });

            modelBuilder.Entity("SGRH.Web.Models.Entities.Dossier", b =>
                {
                    b.Property<int>("Id_Record")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Record"));

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("DocumentType")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id_Record");

                    b.HasIndex("UserId");

                    b.ToTable("Dossiers");
                });

            modelBuilder.Entity("SGRH.Web.Models.Entities.Overtime", b =>
                {
                    b.Property<int>("Id_OT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_OT"));

                    b.Property<decimal>("AmountOT")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("Hours_Worked")
                        .HasColumnType("int");

                    b.Property<DateTime>("OT_Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PersonalActionId_Action")
                        .HasColumnType("int");

                    b.Property<int>("TypeOT")
                        .HasColumnType("int");

                    b.Property<string>("WorkPeriodName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_OT");

                    b.HasIndex("PersonalActionId_Action");

                    b.ToTable("Overtimes");
                });

            modelBuilder.Entity("SGRH.Web.Models.Entities.Payroll", b =>
                {
                    b.Property<int>("Id_Payroll")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Payroll"));

                    b.Property<decimal>("BancoPopular")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("EnfermedadMaternidad")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GrossSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("IVM")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NetSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OrdinarySalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OtHours")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OtHoursAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PayrollFrequency")
                        .HasColumnType("int");

                    b.Property<int>("PayrollPeriodId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalDeductions")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id_Payroll");

                    b.HasIndex("PayrollPeriodId");

                    b.HasIndex("UserId");

                    b.ToTable("Payrolls");
                });

            modelBuilder.Entity("SGRH.Web.Models.Entities.PayrollPeriod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PeriodName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PayrollPeriod");
                });

            modelBuilder.Entity("SGRH.Web.Models.Entities.PersonalAction", b =>
                {
                    b.Property<int>("Id_Action")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Action"));

                    b.Property<int>("ActionType")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<DateTime?>("Approval_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("ApprovedByUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool?>("Is_Approved")
                        .HasColumnType("bit");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id_Action");

                    b.HasIndex("ApprovedByUserId");

                    b.HasIndex("UserId");

                    b.ToTable("PersonalActions");
                });

            modelBuilder.Entity("SGRH.Web.Models.Entities.Position", b =>
                {
                    b.Property<int>("Id_Position")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Position"));

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Position_Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id_Position");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("SGRH.Web.Models.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<decimal>("BaseSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Dni")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("HiredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<int?>("PositionId")
                        .HasColumnType("int");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.Property<int>("VacationDays")
                        .HasColumnType("int");

                    b.Property<int?>("WorkPeriodId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("PositionId");

                    b.HasIndex("WorkPeriodId");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("SGRH.Web.Models.Entities.Vacation", b =>
                {
                    b.Property<int>("Id_Vacation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Vacation"));

                    b.Property<string>("Comments")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("End_Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PersonalActionId_Action")
                        .HasColumnType("int");

                    b.Property<int>("RequestedDays")
                        .HasColumnType("int");

                    b.Property<DateTime>("Start_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id_Vacation");

                    b.HasIndex("PersonalActionId_Action");

                    b.ToTable("Vacations");
                });

            modelBuilder.Entity("SGRH.Web.Models.Entities.Warning", b =>
                {
                    b.Property<int>("Id_Warnings")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Warnings"));

                    b.Property<string>("Observations")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("PersonalActionId_Action")
                        .HasColumnType("int");

                    b.Property<string>("Reason")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id_Warnings");

                    b.HasIndex("PersonalActionId_Action");

                    b.HasIndex("UserId");

                    b.ToTable("Warnings");
                });

            modelBuilder.Entity("SGRH.Web.Models.Entities.WorkPeriod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MaxDailyOTHours")
                        .HasColumnType("int");

                    b.Property<int>("MaxPeriodValue")
                        .HasColumnType("int");

                    b.Property<string>("PeriodDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PeriodName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WorkPeriod");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SGRH.Web.Models.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SGRH.Web.Models.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SGRH.Web.Models.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SGRH.Web.Models.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SGRH.Web.Models.Entities.Absence", b =>
                {
                    b.HasOne("SGRH.Web.Models.Entities.AbsenceCategory", "AbsenceCategory")
                        .WithMany()
                        .HasForeignKey("AbsenceCategoryId_Absence_Category");

                    b.HasOne("SGRH.Web.Models.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("AbsenceCategory");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SGRH.Web.Models.Entities.Attendance", b =>
                {
                    b.HasOne("SGRH.Web.Models.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SGRH.Web.Models.Entities.BenefitsLiquidation", b =>
                {
                    b.HasOne("SGRH.Web.Models.Entities.PersonalAction", "PersonalAction")
                        .WithMany()
                        .HasForeignKey("PersonalActionId_Action");

                    b.Navigation("PersonalAction");
                });

            modelBuilder.Entity("SGRH.Web.Models.Entities.Document", b =>
                {
                    b.HasOne("SGRH.Web.Models.Entities.Absence", null)
                        .WithMany("Document")
                        .HasForeignKey("AbsenceId");

                    b.HasOne("SGRH.Web.Models.Entities.Dossier", null)
                        .WithMany("Document")
                        .HasForeignKey("DossierId_Record");
                });

            modelBuilder.Entity("SGRH.Web.Models.Entities.Dossier", b =>
                {
                    b.HasOne("SGRH.Web.Models.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SGRH.Web.Models.Entities.Overtime", b =>
                {
                    b.HasOne("SGRH.Web.Models.Entities.PersonalAction", "PersonalAction")
                        .WithMany()
                        .HasForeignKey("PersonalActionId_Action");

                    b.Navigation("PersonalAction");
                });

            modelBuilder.Entity("SGRH.Web.Models.Entities.Payroll", b =>
                {
                    b.HasOne("SGRH.Web.Models.Entities.PayrollPeriod", "PayrollPeriod")
                        .WithMany()
                        .HasForeignKey("PayrollPeriodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SGRH.Web.Models.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("PayrollPeriod");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SGRH.Web.Models.Entities.PersonalAction", b =>
                {
                    b.HasOne("SGRH.Web.Models.Entities.User", "ApprovedByUser")
                        .WithMany()
                        .HasForeignKey("ApprovedByUserId");

                    b.HasOne("SGRH.Web.Models.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("ApprovedByUser");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SGRH.Web.Models.Entities.Position", b =>
                {
                    b.HasOne("SGRH.Web.Models.Entities.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("SGRH.Web.Models.Entities.User", b =>
                {
                    b.HasOne("SGRH.Web.Models.Entities.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.HasOne("SGRH.Web.Models.Entities.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId");

                    b.HasOne("SGRH.Web.Models.Entities.WorkPeriod", "workPeriod")
                        .WithMany()
                        .HasForeignKey("WorkPeriodId");

                    b.Navigation("Department");

                    b.Navigation("Position");

                    b.Navigation("workPeriod");
                });

            modelBuilder.Entity("SGRH.Web.Models.Entities.Vacation", b =>
                {
                    b.HasOne("SGRH.Web.Models.Entities.PersonalAction", "PersonalAction")
                        .WithMany()
                        .HasForeignKey("PersonalActionId_Action");

                    b.Navigation("PersonalAction");
                });

            modelBuilder.Entity("SGRH.Web.Models.Entities.Warning", b =>
                {
                    b.HasOne("SGRH.Web.Models.Entities.PersonalAction", "PersonalAction")
                        .WithMany()
                        .HasForeignKey("PersonalActionId_Action");

                    b.HasOne("SGRH.Web.Models.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("PersonalAction");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SGRH.Web.Models.Entities.Absence", b =>
                {
                    b.Navigation("Document");
                });

            modelBuilder.Entity("SGRH.Web.Models.Entities.Dossier", b =>
                {
                    b.Navigation("Document");
                });
#pragma warning restore 612, 618
        }
    }
}

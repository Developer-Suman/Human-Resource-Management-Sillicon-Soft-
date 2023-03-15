﻿// <auto-generated />
using System;
using HRMS_Silicon.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HRMS_Silicon.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HRMS_Silicon.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Employee_id")
                        .HasColumnType("int");

                    b.Property<string>("Fullname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

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

                    b.Property<byte[]>("ProfilePicture")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("UserRoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Employee_id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("UserRoleId");

                    b.ToTable("MyUsers", "Identity");

                    b.HasData(
                        new
                        {
                            Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "735da6b7-13ed-4d9c-9866-741bcb119383",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAELvq106WyI9Cj77NxAHmtiKkIDyENXqbyknzWTiEOkGTTeCiMjDYghhwMI+C5EqB6Q==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "872df28f-9e13-4f48-b502-7e89084a1446",
                            TwoFactorEnabled = false,
                            UserName = "Admin",
                            UserRoleId = "1"
                        });
                });

            modelBuilder.Entity("HRMS_Silicon.Models.Attendence", b =>
                {
                    b.Property<int>("Attendence_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Current_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Employee_id")
                        .HasColumnType("int");

                    b.Property<bool>("Is_Active")
                        .HasColumnType("bit");

                    b.Property<string>("TotalHours")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Turn_In")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Turn_Out")
                        .HasColumnType("datetime2");

                    b.HasKey("Attendence_Id");

                    b.HasIndex("Employee_id");

                    b.ToTable("Attendence", "hrms");
                });

            modelBuilder.Entity("HRMS_Silicon.Models.Department", b =>
                {
                    b.Property<int>("Department_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Department_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Is_Active")
                        .HasColumnType("bit");

                    b.HasKey("Department_id");

                    b.ToTable("Department", "hrms");
                });

            modelBuilder.Entity("HRMS_Silicon.Models.Designation", b =>
                {
                    b.Property<int>("Designation_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Designation_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Designation_id");

                    b.ToTable("Designation", "hrms");
                });

            modelBuilder.Entity("HRMS_Silicon.Models.Employee", b =>
                {
                    b.Property<int>("Employee_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact_1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Department_id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Designation_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenderEnum")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Is_Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Joining_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Last_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Marital_status")
                        .HasColumnType("int");

                    b.HasKey("Employee_id");

                    b.HasIndex("Department_id");

                    b.HasIndex("Designation_id");

                    b.ToTable("Employee", "hrms");
                });

            modelBuilder.Entity("HRMS_Silicon.Models.EmployeeSalaryDetail", b =>
                {
                    b.Property<int>("Employee_id")
                        .HasColumnType("int");

                    b.Property<int>("SalaryDetailId")
                        .HasColumnType("int");

                    b.HasKey("Employee_id", "SalaryDetailId");

                    b.HasIndex("SalaryDetailId");

                    b.ToTable("EmployeeSalaryDetail", "hrms");
                });

            modelBuilder.Entity("HRMS_Silicon.Models.Holiday", b =>
                {
                    b.Property<int>("Holiday_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HolidayDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HolidayName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Holiday_Id");

                    b.ToTable("Holiday", "hrms");
                });

            modelBuilder.Entity("HRMS_Silicon.Models.Leave", b =>
                {
                    b.Property<int>("Leave_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AppliedOnDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date_from")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date_to")
                        .HasColumnType("datetime2");

                    b.Property<int>("Employee_id")
                        .HasColumnType("int");

                    b.Property<int>("LeaveApproval")
                        .HasColumnType("int");

                    b.Property<int>("LeaveTypeEnum")
                        .HasColumnType("int");

                    b.Property<string>("Leave_reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Total_days")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Leave_id");

                    b.HasIndex("Employee_id");

                    b.ToTable("Leave", "hrms");
                });

            modelBuilder.Entity("HRMS_Silicon.Models.Notice", b =>
                {
                    b.Property<int>("NoticeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NoticeDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("NoticeId");

                    b.ToTable("Notice", "hrms");
                });

            modelBuilder.Entity("HRMS_Silicon.Models.Resignation", b =>
                {
                    b.Property<int>("Resignation_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Employee_id")
                        .HasColumnType("int");

                    b.Property<bool>("Is_active")
                        .HasColumnType("bit");

                    b.Property<string>("Resign_reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resignation_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Resignation_id");

                    b.HasIndex("Employee_id");

                    b.ToTable("Resignation", "hrms");
                });

            modelBuilder.Entity("HRMS_Silicon.Models.SalaryDetail", b =>
                {
                    b.Property<int>("SalaryDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployeeSalary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SalaryImplementingDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("SalaryStatus")
                        .HasColumnType("bit");

                    b.HasKey("SalaryDetailId");

                    b.ToTable("SalaryDetail", "hrms");
                });

            modelBuilder.Entity("HRMS_Silicon.Models.UserActivity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ActivityDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("userActivities");
                });

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

                    b.ToTable("AspNetRoles", "Identity");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "1",
                            Name = "Admin",
                            NormalizedName = "Admin"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "2",
                            Name = "Manager",
                            NormalizedName = "Manager"
                        },
                        new
                        {
                            Id = "3",
                            ConcurrencyStamp = "3",
                            Name = "Employee",
                            NormalizedName = "Employee"
                        },
                        new
                        {
                            Id = "4",
                            ConcurrencyStamp = "4",
                            Name = "HRManager",
                            NormalizedName = "HRManager"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", "Identity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", "Identity");
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

                    b.ToTable("AspNetUserLogins", "Identity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", "Identity");

                    b.HasData(
                        new
                        {
                            UserId = "b74ddd14-6340-4840-95c2-db12554843e5",
                            RoleId = "1"
                        });
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

                    b.ToTable("AspNetUserTokens", "Identity");
                });

            modelBuilder.Entity("HRMS_Silicon.Models.ApplicationUser", b =>
                {
                    b.HasOne("HRMS_Silicon.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("Employee_id");

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", "UserRole")
                        .WithMany()
                        .HasForeignKey("UserRoleId");

                    b.Navigation("Employee");

                    b.Navigation("UserRole");
                });

            modelBuilder.Entity("HRMS_Silicon.Models.Attendence", b =>
                {
                    b.HasOne("HRMS_Silicon.Models.Employee", "EmployeeData")
                        .WithMany()
                        .HasForeignKey("Employee_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeData");
                });

            modelBuilder.Entity("HRMS_Silicon.Models.Employee", b =>
                {
                    b.HasOne("HRMS_Silicon.Models.Department", "DepartmentModel")
                        .WithMany()
                        .HasForeignKey("Department_id");

                    b.HasOne("HRMS_Silicon.Models.Designation", "DesignationModel")
                        .WithMany()
                        .HasForeignKey("Designation_id");

                    b.Navigation("DepartmentModel");

                    b.Navigation("DesignationModel");
                });

            modelBuilder.Entity("HRMS_Silicon.Models.EmployeeSalaryDetail", b =>
                {
                    b.HasOne("HRMS_Silicon.Models.Employee", "Employee")
                        .WithMany("EmployeeSalaryDetails")
                        .HasForeignKey("Employee_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRMS_Silicon.Models.SalaryDetail", "SalaryDetail")
                        .WithMany("EmployeeSalaryDetails")
                        .HasForeignKey("SalaryDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("SalaryDetail");
                });

            modelBuilder.Entity("HRMS_Silicon.Models.Leave", b =>
                {
                    b.HasOne("HRMS_Silicon.Models.Employee", "EmployeeFK")
                        .WithMany()
                        .HasForeignKey("Employee_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeFK");
                });

            modelBuilder.Entity("HRMS_Silicon.Models.Resignation", b =>
                {
                    b.HasOne("HRMS_Silicon.Models.Employee", "EmployeeModel")
                        .WithMany()
                        .HasForeignKey("Employee_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeModel");
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
                    b.HasOne("HRMS_Silicon.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HRMS_Silicon.Models.ApplicationUser", null)
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

                    b.HasOne("HRMS_Silicon.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HRMS_Silicon.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HRMS_Silicon.Models.Employee", b =>
                {
                    b.Navigation("EmployeeSalaryDetails");
                });

            modelBuilder.Entity("HRMS_Silicon.Models.SalaryDetail", b =>
                {
                    b.Navigation("EmployeeSalaryDetails");
                });
#pragma warning restore 612, 618
        }
    }
}

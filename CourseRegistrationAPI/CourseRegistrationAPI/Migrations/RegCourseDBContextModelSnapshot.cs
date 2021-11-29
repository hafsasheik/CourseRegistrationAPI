﻿// <auto-generated />
using System;
using CourseRegistrationAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CourseRegistrationAPI.Migrations
{
    [DbContext(typeof(RegCourseDBContext))]
    partial class RegCourseDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CourseRegistrationAPI.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageSrc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StudyPace")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            CourseInfo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Posuere urna nec tincidunt praesent semper feugiat nibh sed.",
                            EndDate = new DateTime(2022, 2, 27, 11, 32, 28, 689, DateTimeKind.Local).AddTicks(480),
                            ImageSrc = "https://i1.wp.com/www.hyrobygg.se/wp-content/uploads/2016/03/js-logo.png?fit=500%2C500&ssl=1",
                            StartDate = new DateTime(2021, 11, 29, 11, 32, 28, 686, DateTimeKind.Local).AddTicks(5901),
                            StudyPace = 100,
                            Subject = "Javascript"
                        },
                        new
                        {
                            CourseId = 2,
                            CourseInfo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Posuere urna nec tincidunt praesent semper feugiat nibh sed.",
                            EndDate = new DateTime(2022, 2, 27, 11, 32, 28, 689, DateTimeKind.Local).AddTicks(2193),
                            ImageSrc = "https://cdn.pixabay.com/photo/2017/08/05/11/16/logo-2582748_640.png",
                            StartDate = new DateTime(2021, 11, 29, 11, 32, 28, 689, DateTimeKind.Local).AddTicks(2178),
                            StudyPace = 100,
                            Subject = "HTML"
                        },
                        new
                        {
                            CourseId = 3,
                            CourseInfo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Posuere urna nec tincidunt praesent semper feugiat nibh sed.",
                            EndDate = new DateTime(2022, 2, 27, 11, 32, 28, 689, DateTimeKind.Local).AddTicks(2201),
                            ImageSrc = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a7/React-icon.svg/1280px-React-icon.svg.png",
                            StartDate = new DateTime(2021, 11, 29, 11, 32, 28, 689, DateTimeKind.Local).AddTicks(2198),
                            StudyPace = 100,
                            Subject = "React"
                        },
                        new
                        {
                            CourseId = 4,
                            CourseInfo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Posuere urna nec tincidunt praesent semper feugiat nibh sed.",
                            EndDate = new DateTime(2022, 2, 27, 11, 32, 28, 689, DateTimeKind.Local).AddTicks(2207),
                            ImageSrc = "https://upload.wikimedia.org/wikipedia/commons/4/49/Redux.png",
                            StartDate = new DateTime(2021, 11, 29, 11, 32, 28, 689, DateTimeKind.Local).AddTicks(2204),
                            StudyPace = 100,
                            Subject = "Redux"
                        });
                });

            modelBuilder.Entity("CourseRegistrationAPI.Models.Registration", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("Registrations");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            CourseId = 1
                        });
                });

            modelBuilder.Entity("CourseRegistrationAPI.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salt")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "Oskar@Pustinen.com",
                            FirstName = "Oskar",
                            LastName = "Pustinen",
                            Password = "cUkRJKVzFvvlS2dH+L/AiNwhg2wLG8DkYK5cCXE0fVA=",
                            Salt = "uRATMgbyvt5abILXnAH7Cg=="
                        },
                        new
                        {
                            UserId = 2,
                            Email = "Nikola@Pavlovic.com",
                            FirstName = "Nikola",
                            LastName = "Pavlovic",
                            Password = "cUkRJKVzFvvlS2dH+L/AiNwhg2wLG8DkYK5cCXE0fVA=",
                            Salt = "uRATMgbyvt5abILXnAH7Cg=="
                        },
                        new
                        {
                            UserId = 3,
                            Email = "Hafsa@Sheik.com",
                            FirstName = "Hafsa",
                            LastName = "Sheik",
                            Password = "cUkRJKVzFvvlS2dH+L/AiNwhg2wLG8DkYK5cCXE0fVA=",
                            Salt = "uRATMgbyvt5abILXnAH7Cg=="
                        },
                        new
                        {
                            UserId = 4,
                            Email = "Erik@Sundberg.com",
                            FirstName = "Eerik",
                            LastName = "Sundberg",
                            Password = "cUkRJKVzFvvlS2dH+L/AiNwhg2wLG8DkYK5cCXE0fVA=",
                            Salt = "uRATMgbyvt5abILXnAH7Cg=="
                        });
                });

            modelBuilder.Entity("CourseRegistrationAPI.Models.Registration", b =>
                {
                    b.HasOne("CourseRegistrationAPI.Models.Course", "Course")
                        .WithMany("Registrations")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseRegistrationAPI.Models.User", "User")
                        .WithMany("Registrations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CourseRegistrationAPI.Models.Course", b =>
                {
                    b.Navigation("Registrations");
                });

            modelBuilder.Entity("CourseRegistrationAPI.Models.User", b =>
                {
                    b.Navigation("Registrations");
                });
#pragma warning restore 612, 618
        }
    }
}

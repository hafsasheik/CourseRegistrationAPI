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

                    b.Property<int>("AvailableSpots")
                        .HasColumnType("int");

                    b.Property<string>("CourseInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageSrc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegisteredStudents")
                        .HasColumnType("int");

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
                            AvailableSpots = 2,
                            CourseInfo = "Du kommer lära dig webbprogrammeringsspråket JavaScript och dess tillhörande verktyg på djupet. Du kommer även skapa applikationer med en kodbas för Android och iOS, och publicera applikationer på marknader.",
                            EndDate = new DateTime(2022, 3, 8, 1, 38, 5, 231, DateTimeKind.Local).AddTicks(6269),
                            ImageSrc = "https://i1.wp.com/www.hyrobygg.se/wp-content/uploads/2016/03/js-logo.png?fit=500%2C500&ssl=1",
                            RegisteredStudents = 0,
                            StartDate = new DateTime(2021, 12, 28, 1, 38, 5, 228, DateTimeKind.Local).AddTicks(6667),
                            StudyPace = 100,
                            Subject = "Javascript"
                        },
                        new
                        {
                            CourseId = 2,
                            AvailableSpots = 3,
                            CourseInfo = "Kursen syftar till att ge studerande kunskaper samt färdigheter inom webbutveckling med hjälp av HTML5 och CSS3 samt hur man skriver semantisk HTML som validerar och är sökmotoroptimerad.",
                            EndDate = new DateTime(2022, 4, 7, 1, 38, 5, 231, DateTimeKind.Local).AddTicks(7822),
                            ImageSrc = "https://cdn.pixabay.com/photo/2017/08/05/11/16/logo-2582748_640.png",
                            RegisteredStudents = 0,
                            StartDate = new DateTime(2022, 1, 7, 1, 38, 5, 231, DateTimeKind.Local).AddTicks(7806),
                            StudyPace = 50,
                            Subject = "HTML"
                        },
                        new
                        {
                            CourseId = 3,
                            AvailableSpots = 4,
                            CourseInfo = "React är ett JavaScript-bibliotek som används för att bygga användargränssnitt. Det utvecklades till en början av en utvecklare på Facebook men är släppt med öppen källkod. Under React-kursen får du lära dig hur du utvecklar med hjälp av React-biblioteket.",
                            EndDate = new DateTime(2022, 2, 6, 1, 38, 5, 231, DateTimeKind.Local).AddTicks(7831),
                            ImageSrc = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a7/React-icon.svg/1280px-React-icon.svg.png",
                            RegisteredStudents = 0,
                            StartDate = new DateTime(2021, 12, 18, 1, 38, 5, 231, DateTimeKind.Local).AddTicks(7827),
                            StudyPace = 100,
                            Subject = "React"
                        },
                        new
                        {
                            CourseId = 4,
                            AvailableSpots = 4,
                            CourseInfo = "Redux är ett bibliotek som tillhandahåller en förutsägbar tillståndscontainer för JavaScript-appar och som ofta används som komplement till React. I den här kursen kommer du att lära dig allt om state-hantering med Redux och närbesläktade verktyg.",
                            EndDate = new DateTime(2022, 2, 11, 1, 38, 5, 231, DateTimeKind.Local).AddTicks(7840),
                            ImageSrc = "https://upload.wikimedia.org/wikipedia/commons/4/49/Redux.png",
                            RegisteredStudents = 0,
                            StartDate = new DateTime(2021, 12, 13, 1, 38, 5, 231, DateTimeKind.Local).AddTicks(7836),
                            StudyPace = 25,
                            Subject = "Redux"
                        },
                        new
                        {
                            CourseId = 7,
                            AvailableSpots = 7,
                            CourseInfo = "Vue.js är känt för sin låga inlärningskurva, flexibilitet och prestanda. Denna kurs avser ge dig goda grunder för att bygga allt ifrån enkla webbapplikationer till större system som kommunicerar med servrar med Vue.",
                            EndDate = new DateTime(2022, 2, 21, 1, 38, 5, 231, DateTimeKind.Local).AddTicks(7849),
                            ImageSrc = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/95/Vue.js_Logo_2.svg/220px-Vue.js_Logo_2.svg.png",
                            RegisteredStudents = 0,
                            StartDate = new DateTime(2021, 12, 23, 1, 38, 5, 231, DateTimeKind.Local).AddTicks(7845),
                            StudyPace = 75,
                            Subject = "Vue.js"
                        },
                        new
                        {
                            CourseId = 8,
                            AvailableSpots = 10,
                            CourseInfo = "Angular är ett open source ramverk för webbutveckling som tagits fram av Google. Det är inte att blanda ihop med AngularJS. Under en Angular-kurs får du lära dig hur du enkelt bygger flexibla och dynamiska webbapplikationer.",
                            EndDate = new DateTime(2022, 1, 14, 1, 38, 5, 231, DateTimeKind.Local).AddTicks(7858),
                            ImageSrc = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cf/Angular_full_color_logo.svg/250px-Angular_full_color_logo.svg.png",
                            RegisteredStudents = 0,
                            StartDate = new DateTime(2021, 12, 15, 1, 38, 5, 231, DateTimeKind.Local).AddTicks(7854),
                            StudyPace = 100,
                            Subject = "Angular"
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
                            CourseId = 3
                        },
                        new
                        {
                            UserId = 2,
                            CourseId = 1
                        },
                        new
                        {
                            UserId = 3,
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

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

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
                            Email = "Oskar@Puustinen.com",
                            FirstName = "Oskar",
                            IsAdmin = false,
                            LastName = "Puustinen",
                            Password = "4IN3F3egM+BjkdronE4FPb3+pcsLLYiVHlonrXwET3A=",
                            Salt = "NU7XfKux9ldYzPk7S//M8w=="
                        },
                        new
                        {
                            UserId = 2,
                            Email = "Nikola@Pavlovic.com",
                            FirstName = "Nikola",
                            IsAdmin = false,
                            LastName = "Pavlovic",
                            Password = "4IN3F3egM+BjkdronE4FPb3+pcsLLYiVHlonrXwET3A=",
                            Salt = "NU7XfKux9ldYzPk7S//M8w=="
                        },
                        new
                        {
                            UserId = 3,
                            Email = "Hafsa@Sheik.com",
                            FirstName = "Hafsa",
                            IsAdmin = false,
                            LastName = "Sheik",
                            Password = "4IN3F3egM+BjkdronE4FPb3+pcsLLYiVHlonrXwET3A=",
                            Salt = "NU7XfKux9ldYzPk7S//M8w=="
                        },
                        new
                        {
                            UserId = 4,
                            Email = "Erik@Sundberg.com",
                            FirstName = "Erik",
                            IsAdmin = false,
                            LastName = "Sundberg",
                            Password = "4IN3F3egM+BjkdronE4FPb3+pcsLLYiVHlonrXwET3A=",
                            Salt = "NU7XfKux9ldYzPk7S//M8w=="
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

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseRegistrationAPI.Migrations
{
    public partial class newSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 3, 8, 1, 38, 5, 231, DateTimeKind.Local).AddTicks(6269), new DateTime(2021, 12, 28, 1, 38, 5, 228, DateTimeKind.Local).AddTicks(6667) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 7, 1, 38, 5, 231, DateTimeKind.Local).AddTicks(7822), new DateTime(2022, 1, 7, 1, 38, 5, 231, DateTimeKind.Local).AddTicks(7806) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 2, 6, 1, 38, 5, 231, DateTimeKind.Local).AddTicks(7831), new DateTime(2021, 12, 18, 1, 38, 5, 231, DateTimeKind.Local).AddTicks(7827) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 2, 11, 1, 38, 5, 231, DateTimeKind.Local).AddTicks(7840), new DateTime(2021, 12, 13, 1, 38, 5, 231, DateTimeKind.Local).AddTicks(7836) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 2, 21, 1, 38, 5, 231, DateTimeKind.Local).AddTicks(7849), new DateTime(2021, 12, 23, 1, 38, 5, 231, DateTimeKind.Local).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 14, 1, 38, 5, 231, DateTimeKind.Local).AddTicks(7858), new DateTime(2021, 12, 15, 1, 38, 5, 231, DateTimeKind.Local).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "4IN3F3egM+BjkdronE4FPb3+pcsLLYiVHlonrXwET3A=", "NU7XfKux9ldYzPk7S//M8w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "4IN3F3egM+BjkdronE4FPb3+pcsLLYiVHlonrXwET3A=", "NU7XfKux9ldYzPk7S//M8w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "4IN3F3egM+BjkdronE4FPb3+pcsLLYiVHlonrXwET3A=", "NU7XfKux9ldYzPk7S//M8w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "4IN3F3egM+BjkdronE4FPb3+pcsLLYiVHlonrXwET3A=", "NU7XfKux9ldYzPk7S//M8w==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 3, 8, 1, 26, 22, 9, DateTimeKind.Local).AddTicks(9237), new DateTime(2021, 12, 28, 1, 26, 22, 6, DateTimeKind.Local).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 4, 7, 1, 26, 22, 10, DateTimeKind.Local).AddTicks(685), new DateTime(2022, 1, 7, 1, 26, 22, 10, DateTimeKind.Local).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 2, 6, 1, 26, 22, 10, DateTimeKind.Local).AddTicks(696), new DateTime(2021, 12, 18, 1, 26, 22, 10, DateTimeKind.Local).AddTicks(691) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 2, 11, 1, 26, 22, 10, DateTimeKind.Local).AddTicks(704), new DateTime(2021, 12, 13, 1, 26, 22, 10, DateTimeKind.Local).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 2, 21, 1, 26, 22, 10, DateTimeKind.Local).AddTicks(730), new DateTime(2021, 12, 23, 1, 26, 22, 10, DateTimeKind.Local).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 1, 14, 1, 26, 22, 10, DateTimeKind.Local).AddTicks(739), new DateTime(2021, 12, 15, 1, 26, 22, 10, DateTimeKind.Local).AddTicks(735) });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "AvailableSpots", "CourseInfo", "EndDate", "ImageSrc", "RegisteredStudents", "StartDate", "StudyPace", "Subject" },
                values: new object[,]
                {
                    { 5, 10, "Kursen skall ge goda kunskaper i syntax och programmeringsteknik i det objektorienterade programspråket C#(C-sharp) och grunderna i . NET ramverket/klassbibllioteket. Vidare skall den ge förståelse för och användning av begrepp som finns i objektorientering och hur detta stöds i C#.", new DateTime(2022, 2, 1, 1, 26, 22, 10, DateTimeKind.Local).AddTicks(713), "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/C_Sharp_wordmark.svg/120px-C_Sharp_wordmark.svg.png", 0, new DateTime(2021, 12, 23, 1, 26, 22, 10, DateTimeKind.Local).AddTicks(709), 100, "C#" },
                    { 6, 5, "Redux är ett bibliotek som tillhandahåller en förutsägbar tillståndscontainer för JavaScript-appar och som ofta används som komplement till React. I den här kursen kommer du att lära dig allt om state-hantering med Redux och närbesläktade verktyg.", new DateTime(2022, 1, 9, 1, 26, 22, 10, DateTimeKind.Local).AddTicks(721), "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/Python-logo-notext.svg/121px-Python-logo-notext.svg.png", 0, new DateTime(2021, 12, 10, 1, 26, 22, 10, DateTimeKind.Local).AddTicks(718), 100, "Python" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "CrhjRaxOe8e2aduvM2kY/EQ0yooApHEyDGjQftv/FRE=", "n+fgwv9RLwnHBsr/iD9WqA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "CrhjRaxOe8e2aduvM2kY/EQ0yooApHEyDGjQftv/FRE=", "n+fgwv9RLwnHBsr/iD9WqA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "CrhjRaxOe8e2aduvM2kY/EQ0yooApHEyDGjQftv/FRE=", "n+fgwv9RLwnHBsr/iD9WqA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "CrhjRaxOe8e2aduvM2kY/EQ0yooApHEyDGjQftv/FRE=", "n+fgwv9RLwnHBsr/iD9WqA==" });
        }
    }
}

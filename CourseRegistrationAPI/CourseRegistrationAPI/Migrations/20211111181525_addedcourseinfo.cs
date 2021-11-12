using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseRegistrationAPI.Migrations
{
    public partial class addedcourseinfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CourseInfo",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseInfo", "EndDate", "StartDate", "StudyPace", "Subject" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 2, 9, 19, 15, 25, 372, DateTimeKind.Local).AddTicks(3121), new DateTime(2021, 11, 11, 19, 15, 25, 370, DateTimeKind.Local).AddTicks(5882), 100, "Javascript" },
                    { 2, null, new DateTime(2022, 2, 9, 19, 15, 25, 372, DateTimeKind.Local).AddTicks(3982), new DateTime(2021, 11, 11, 19, 15, 25, 372, DateTimeKind.Local).AddTicks(3971), 100, "HTML" },
                    { 3, null, new DateTime(2022, 2, 9, 19, 15, 25, 372, DateTimeKind.Local).AddTicks(3988), new DateTime(2021, 11, 11, 19, 15, 25, 372, DateTimeKind.Local).AddTicks(3986), 100, "React" },
                    { 4, null, new DateTime(2022, 2, 9, 19, 15, 25, 372, DateTimeKind.Local).AddTicks(3993), new DateTime(2021, 11, 11, 19, 15, 25, 372, DateTimeKind.Local).AddTicks(3991), 100, "Redux" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FirstName", "LastName", "Password" },
                values: new object[,]
                {
                    { 1, "Oskar@Pustinen.com", "Oskar", "Pustinen", "123" },
                    { 2, "Nikola@Pavlovic.com", "Nikola", "Pavlovic", "123" },
                    { 3, "Hafsa@Sheik.com", "Hafsa", "Sheik", "123" },
                    { 4, "Erik@Sundberg.com", "Eerik", "Sundberg", "123" }
                });

            migrationBuilder.InsertData(
                table: "Registrations",
                columns: new[] { "CourseId", "UserId" },
                values: new object[] { 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "CourseInfo",
                table: "Courses");
        }
    }
}

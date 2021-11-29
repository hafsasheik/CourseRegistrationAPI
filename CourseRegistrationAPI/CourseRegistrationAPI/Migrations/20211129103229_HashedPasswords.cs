using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseRegistrationAPI.Migrations
{
    public partial class HashedPasswords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "Salt",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 2, 27, 11, 32, 28, 689, DateTimeKind.Local).AddTicks(480), new DateTime(2021, 11, 29, 11, 32, 28, 686, DateTimeKind.Local).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 2, 27, 11, 32, 28, 689, DateTimeKind.Local).AddTicks(2193), new DateTime(2021, 11, 29, 11, 32, 28, 689, DateTimeKind.Local).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 2, 27, 11, 32, 28, 689, DateTimeKind.Local).AddTicks(2201), new DateTime(2021, 11, 29, 11, 32, 28, 689, DateTimeKind.Local).AddTicks(2198) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 2, 27, 11, 32, 28, 689, DateTimeKind.Local).AddTicks(2207), new DateTime(2021, 11, 29, 11, 32, 28, 689, DateTimeKind.Local).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "cUkRJKVzFvvlS2dH+L/AiNwhg2wLG8DkYK5cCXE0fVA=", "uRATMgbyvt5abILXnAH7Cg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "cUkRJKVzFvvlS2dH+L/AiNwhg2wLG8DkYK5cCXE0fVA=", "uRATMgbyvt5abILXnAH7Cg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "cUkRJKVzFvvlS2dH+L/AiNwhg2wLG8DkYK5cCXE0fVA=", "uRATMgbyvt5abILXnAH7Cg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "cUkRJKVzFvvlS2dH+L/AiNwhg2wLG8DkYK5cCXE0fVA=", "uRATMgbyvt5abILXnAH7Cg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salt",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 2, 17, 16, 23, 16, 638, DateTimeKind.Local).AddTicks(7669), new DateTime(2021, 11, 19, 16, 23, 16, 636, DateTimeKind.Local).AddTicks(695) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 2, 17, 16, 23, 16, 638, DateTimeKind.Local).AddTicks(9350), new DateTime(2021, 11, 19, 16, 23, 16, 638, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 2, 17, 16, 23, 16, 638, DateTimeKind.Local).AddTicks(9358), new DateTime(2021, 11, 19, 16, 23, 16, 638, DateTimeKind.Local).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 2, 17, 16, 23, 16, 638, DateTimeKind.Local).AddTicks(9364), new DateTime(2021, 11, 19, 16, 23, 16, 638, DateTimeKind.Local).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "123");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Password",
                value: "123");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "Password",
                value: "123");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "Password",
                value: "123");
        }
    }
}

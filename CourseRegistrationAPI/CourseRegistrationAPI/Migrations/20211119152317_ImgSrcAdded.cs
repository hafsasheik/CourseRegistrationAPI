using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseRegistrationAPI.Migrations
{
    public partial class ImgSrcAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageSrc",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "CourseInfo", "EndDate", "ImageSrc", "StartDate" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Posuere urna nec tincidunt praesent semper feugiat nibh sed.", new DateTime(2022, 2, 17, 16, 23, 16, 638, DateTimeKind.Local).AddTicks(7669), "https://i1.wp.com/www.hyrobygg.se/wp-content/uploads/2016/03/js-logo.png?fit=500%2C500&ssl=1", new DateTime(2021, 11, 19, 16, 23, 16, 636, DateTimeKind.Local).AddTicks(695) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "CourseInfo", "EndDate", "ImageSrc", "StartDate" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Posuere urna nec tincidunt praesent semper feugiat nibh sed.", new DateTime(2022, 2, 17, 16, 23, 16, 638, DateTimeKind.Local).AddTicks(9350), "https://cdn.pixabay.com/photo/2017/08/05/11/16/logo-2582748_640.png", new DateTime(2021, 11, 19, 16, 23, 16, 638, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                columns: new[] { "CourseInfo", "EndDate", "ImageSrc", "StartDate" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Posuere urna nec tincidunt praesent semper feugiat nibh sed.", new DateTime(2022, 2, 17, 16, 23, 16, 638, DateTimeKind.Local).AddTicks(9358), "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a7/React-icon.svg/1280px-React-icon.svg.png", new DateTime(2021, 11, 19, 16, 23, 16, 638, DateTimeKind.Local).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4,
                columns: new[] { "CourseInfo", "EndDate", "ImageSrc", "StartDate" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Posuere urna nec tincidunt praesent semper feugiat nibh sed.", new DateTime(2022, 2, 17, 16, 23, 16, 638, DateTimeKind.Local).AddTicks(9364), "https://upload.wikimedia.org/wikipedia/commons/4/49/Redux.png", new DateTime(2021, 11, 19, 16, 23, 16, 638, DateTimeKind.Local).AddTicks(9361) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageSrc",
                table: "Courses");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "CourseInfo", "EndDate", "StartDate" },
                values: new object[] { null, new DateTime(2022, 2, 9, 19, 15, 25, 372, DateTimeKind.Local).AddTicks(3121), new DateTime(2021, 11, 11, 19, 15, 25, 370, DateTimeKind.Local).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "CourseInfo", "EndDate", "StartDate" },
                values: new object[] { null, new DateTime(2022, 2, 9, 19, 15, 25, 372, DateTimeKind.Local).AddTicks(3982), new DateTime(2021, 11, 11, 19, 15, 25, 372, DateTimeKind.Local).AddTicks(3971) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                columns: new[] { "CourseInfo", "EndDate", "StartDate" },
                values: new object[] { null, new DateTime(2022, 2, 9, 19, 15, 25, 372, DateTimeKind.Local).AddTicks(3988), new DateTime(2021, 11, 11, 19, 15, 25, 372, DateTimeKind.Local).AddTicks(3986) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4,
                columns: new[] { "CourseInfo", "EndDate", "StartDate" },
                values: new object[] { null, new DateTime(2022, 2, 9, 19, 15, 25, 372, DateTimeKind.Local).AddTicks(3993), new DateTime(2021, 11, 11, 19, 15, 25, 372, DateTimeKind.Local).AddTicks(3991) });
        }
    }
}

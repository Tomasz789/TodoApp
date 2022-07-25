using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoList.WebApp.Migrations
{
    public partial class DescriptionNullFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b03920a-17ce-4106-83a1-b8146c476377"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f1a9b3a-90d6-4d68-a481-c63f2c2ea3ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f94fd035-2bb5-4868-b005-e67ffb86972f"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "EndDate", "Updated" },
                values: new object[] { new DateTime(2022, 7, 17, 21, 22, 4, 869, DateTimeKind.Local).AddTicks(6397), "test", new DateTime(2022, 7, 17, 22, 22, 4, 869, DateTimeKind.Local).AddTicks(3922), new DateTime(2022, 7, 17, 21, 22, 4, 869, DateTimeKind.Local).AddTicks(6548) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "EndDate", "Updated" },
                values: new object[] { new DateTime(2022, 7, 17, 21, 22, 4, 869, DateTimeKind.Local).AddTicks(6969), "test", new DateTime(2022, 7, 17, 22, 22, 4, 869, DateTimeKind.Local).AddTicks(6908), new DateTime(2022, 7, 17, 21, 22, 4, 869, DateTimeKind.Local).AddTicks(6978) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "EndDate", "Updated" },
                values: new object[] { new DateTime(2022, 7, 17, 21, 22, 4, 869, DateTimeKind.Local).AddTicks(6997), "test", new DateTime(2022, 7, 17, 22, 22, 4, 869, DateTimeKind.Local).AddTicks(6990), new DateTime(2022, 7, 17, 21, 22, 4, 869, DateTimeKind.Local).AddTicks(7000) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("519c1198-1c6e-4ac1-99ee-ceaa9436494d"), new DateTime(2022, 7, 17, 21, 22, 4, 865, DateTimeKind.Local).AddTicks(1358), "user1@gmail.com", "aaabb1C#", new DateTime(2022, 7, 17, 21, 22, 4, 867, DateTimeKind.Local).AddTicks(8862), "Firstuser1" },
                    { new Guid("b51f6aff-3b1b-412e-a383-b97461a926b8"), new DateTime(2022, 7, 17, 21, 22, 4, 867, DateTimeKind.Local).AddTicks(9848), "userno2@wp.pl", "bbbAFF##C1", new DateTime(2022, 7, 17, 21, 22, 4, 867, DateTimeKind.Local).AddTicks(9885), "SecondUser22" },
                    { new Guid("a11767d4-6cd0-4a4b-9a0e-b8e66b773df7"), new DateTime(2022, 7, 17, 21, 22, 4, 868, DateTimeKind.Local).AddTicks(154), "testUser3@gmail.com", "test#PassworD!", new DateTime(2022, 7, 17, 21, 22, 4, 868, DateTimeKind.Local).AddTicks(159), "thirdtestUser3" }
                });

            migrationBuilder.UpdateData(
                table: "TodoLists",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Updated", "UserId" },
                values: new object[] { new DateTime(2022, 7, 17, 21, 22, 4, 869, DateTimeKind.Local).AddTicks(2912), new DateTime(2022, 7, 17, 21, 22, 4, 869, DateTimeKind.Local).AddTicks(3155), new Guid("519c1198-1c6e-4ac1-99ee-ceaa9436494d") });

            migrationBuilder.UpdateData(
                table: "TodoLists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Updated", "UserId" },
                values: new object[] { new DateTime(2022, 7, 17, 21, 22, 4, 869, DateTimeKind.Local).AddTicks(3649), new DateTime(2022, 7, 17, 21, 22, 4, 869, DateTimeKind.Local).AddTicks(3664), new Guid("519c1198-1c6e-4ac1-99ee-ceaa9436494d") });

            migrationBuilder.UpdateData(
                table: "TodoLists",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Updated", "UserId" },
                values: new object[] { new DateTime(2022, 7, 17, 21, 22, 4, 869, DateTimeKind.Local).AddTicks(3692), new DateTime(2022, 7, 17, 21, 22, 4, 869, DateTimeKind.Local).AddTicks(3695), new Guid("b51f6aff-3b1b-412e-a383-b97461a926b8") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("519c1198-1c6e-4ac1-99ee-ceaa9436494d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a11767d4-6cd0-4a4b-9a0e-b8e66b773df7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b51f6aff-3b1b-412e-a383-b97461a926b8"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "EndDate", "Updated" },
                values: new object[] { new DateTime(2022, 7, 17, 21, 12, 38, 732, DateTimeKind.Local).AddTicks(5673), null, new DateTime(2022, 7, 17, 22, 12, 38, 732, DateTimeKind.Local).AddTicks(2966), new DateTime(2022, 7, 17, 21, 12, 38, 732, DateTimeKind.Local).AddTicks(5824) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "EndDate", "Updated" },
                values: new object[] { new DateTime(2022, 7, 17, 21, 12, 38, 732, DateTimeKind.Local).AddTicks(6253), null, new DateTime(2022, 7, 17, 22, 12, 38, 732, DateTimeKind.Local).AddTicks(6202), new DateTime(2022, 7, 17, 21, 12, 38, 732, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "EndDate", "Updated" },
                values: new object[] { new DateTime(2022, 7, 17, 21, 12, 38, 732, DateTimeKind.Local).AddTicks(6296), null, new DateTime(2022, 7, 17, 22, 12, 38, 732, DateTimeKind.Local).AddTicks(6289), new DateTime(2022, 7, 17, 21, 12, 38, 732, DateTimeKind.Local).AddTicks(6299) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("5f1a9b3a-90d6-4d68-a481-c63f2c2ea3ff"), new DateTime(2022, 7, 17, 21, 12, 38, 727, DateTimeKind.Local).AddTicks(2123), "user1@gmail.com", "aaabb1C#", new DateTime(2022, 7, 17, 21, 12, 38, 730, DateTimeKind.Local).AddTicks(7142), "Firstuser1" },
                    { new Guid("f94fd035-2bb5-4868-b005-e67ffb86972f"), new DateTime(2022, 7, 17, 21, 12, 38, 730, DateTimeKind.Local).AddTicks(8188), "userno2@wp.pl", "bbbAFF##C1", new DateTime(2022, 7, 17, 21, 12, 38, 730, DateTimeKind.Local).AddTicks(8206), "SecondUser22" },
                    { new Guid("3b03920a-17ce-4106-83a1-b8146c476377"), new DateTime(2022, 7, 17, 21, 12, 38, 730, DateTimeKind.Local).AddTicks(8476), "testUser3@gmail.com", "test#PassworD!", new DateTime(2022, 7, 17, 21, 12, 38, 730, DateTimeKind.Local).AddTicks(8480), "thirdtestUser3" }
                });

            migrationBuilder.UpdateData(
                table: "TodoLists",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Updated", "UserId" },
                values: new object[] { new DateTime(2022, 7, 17, 21, 12, 38, 732, DateTimeKind.Local).AddTicks(1700), new DateTime(2022, 7, 17, 21, 12, 38, 732, DateTimeKind.Local).AddTicks(1966), new Guid("5f1a9b3a-90d6-4d68-a481-c63f2c2ea3ff") });

            migrationBuilder.UpdateData(
                table: "TodoLists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Updated", "UserId" },
                values: new object[] { new DateTime(2022, 7, 17, 21, 12, 38, 732, DateTimeKind.Local).AddTicks(2488), new DateTime(2022, 7, 17, 21, 12, 38, 732, DateTimeKind.Local).AddTicks(2502), new Guid("5f1a9b3a-90d6-4d68-a481-c63f2c2ea3ff") });

            migrationBuilder.UpdateData(
                table: "TodoLists",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Updated", "UserId" },
                values: new object[] { new DateTime(2022, 7, 17, 21, 12, 38, 732, DateTimeKind.Local).AddTicks(2532), new DateTime(2022, 7, 17, 21, 12, 38, 732, DateTimeKind.Local).AddTicks(2536), new Guid("f94fd035-2bb5-4868-b005-e67ffb86972f") });
        }
    }
}

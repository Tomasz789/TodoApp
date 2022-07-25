using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoList.WebApp.Migrations
{
    public partial class NewPropertyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "Updated" },
                values: new object[] { new DateTime(2022, 7, 25, 7, 57, 29, 790, DateTimeKind.Local).AddTicks(4803), new DateTime(2022, 7, 25, 8, 57, 29, 790, DateTimeKind.Local).AddTicks(2415), new DateTime(2022, 7, 25, 7, 57, 29, 790, DateTimeKind.Local).AddTicks(4981) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndDate", "Priority", "Updated" },
                values: new object[] { new DateTime(2022, 7, 25, 7, 57, 29, 790, DateTimeKind.Local).AddTicks(5554), new DateTime(2022, 7, 25, 8, 57, 29, 790, DateTimeKind.Local).AddTicks(5498), 1, new DateTime(2022, 7, 25, 7, 57, 29, 790, DateTimeKind.Local).AddTicks(5562) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndDate", "Priority", "Updated" },
                values: new object[] { new DateTime(2022, 7, 25, 7, 57, 29, 790, DateTimeKind.Local).AddTicks(5585), new DateTime(2022, 7, 25, 8, 57, 29, 790, DateTimeKind.Local).AddTicks(5577), 2, new DateTime(2022, 7, 25, 7, 57, 29, 790, DateTimeKind.Local).AddTicks(5587) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("ae50b1f6-bc08-48b1-9a2d-8afca4a5d4f9"), new DateTime(2022, 7, 25, 7, 57, 29, 786, DateTimeKind.Local).AddTicks(2518), "user1@gmail.com", "aaabb1C#", new DateTime(2022, 7, 25, 7, 57, 29, 788, DateTimeKind.Local).AddTicks(7502), "Firstuser1" },
                    { new Guid("0a2395b4-c238-4987-8ad3-8ccb43d250bd"), new DateTime(2022, 7, 25, 7, 57, 29, 788, DateTimeKind.Local).AddTicks(8597), "userno2@wp.pl", "bbbAFF##C1", new DateTime(2022, 7, 25, 7, 57, 29, 788, DateTimeKind.Local).AddTicks(8614), "SecondUser22" },
                    { new Guid("841a4b33-4181-4553-aaab-c9cffef86196"), new DateTime(2022, 7, 25, 7, 57, 29, 788, DateTimeKind.Local).AddTicks(8962), "testUser3@gmail.com", "test#PassworD!", new DateTime(2022, 7, 25, 7, 57, 29, 788, DateTimeKind.Local).AddTicks(8966), "thirdtestUser3" }
                });

            migrationBuilder.UpdateData(
                table: "TodoLists",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Updated", "UserId" },
                values: new object[] { new DateTime(2022, 7, 25, 7, 57, 29, 790, DateTimeKind.Local).AddTicks(1400), new DateTime(2022, 7, 25, 7, 57, 29, 790, DateTimeKind.Local).AddTicks(1613), new Guid("ae50b1f6-bc08-48b1-9a2d-8afca4a5d4f9") });

            migrationBuilder.UpdateData(
                table: "TodoLists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Updated", "UserId" },
                values: new object[] { new DateTime(2022, 7, 25, 7, 57, 29, 790, DateTimeKind.Local).AddTicks(2115), new DateTime(2022, 7, 25, 7, 57, 29, 790, DateTimeKind.Local).AddTicks(2133), new Guid("ae50b1f6-bc08-48b1-9a2d-8afca4a5d4f9") });

            migrationBuilder.UpdateData(
                table: "TodoLists",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Updated", "UserId" },
                values: new object[] { new DateTime(2022, 7, 25, 7, 57, 29, 790, DateTimeKind.Local).AddTicks(2157), new DateTime(2022, 7, 25, 7, 57, 29, 790, DateTimeKind.Local).AddTicks(2160), new Guid("0a2395b4-c238-4987-8ad3-8ccb43d250bd") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0a2395b4-c238-4987-8ad3-8ccb43d250bd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("841a4b33-4181-4553-aaab-c9cffef86196"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae50b1f6-bc08-48b1-9a2d-8afca4a5d4f9"));

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "Tasks");

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "Updated" },
                values: new object[] { new DateTime(2022, 7, 17, 21, 22, 4, 869, DateTimeKind.Local).AddTicks(6397), new DateTime(2022, 7, 17, 22, 22, 4, 869, DateTimeKind.Local).AddTicks(3922), new DateTime(2022, 7, 17, 21, 22, 4, 869, DateTimeKind.Local).AddTicks(6548) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndDate", "Updated" },
                values: new object[] { new DateTime(2022, 7, 17, 21, 22, 4, 869, DateTimeKind.Local).AddTicks(6969), new DateTime(2022, 7, 17, 22, 22, 4, 869, DateTimeKind.Local).AddTicks(6908), new DateTime(2022, 7, 17, 21, 22, 4, 869, DateTimeKind.Local).AddTicks(6978) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndDate", "Updated" },
                values: new object[] { new DateTime(2022, 7, 17, 21, 22, 4, 869, DateTimeKind.Local).AddTicks(6997), new DateTime(2022, 7, 17, 22, 22, 4, 869, DateTimeKind.Local).AddTicks(6990), new DateTime(2022, 7, 17, 21, 22, 4, 869, DateTimeKind.Local).AddTicks(7000) });

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
    }
}

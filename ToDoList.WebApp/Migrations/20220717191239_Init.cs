using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoList.WebApp.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TodoLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TodoLists_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TaskListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_TodoLists_TaskListId",
                        column: x => x.TaskListId,
                        principalTable: "TodoLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { new Guid("5f1a9b3a-90d6-4d68-a481-c63f2c2ea3ff"), new DateTime(2022, 7, 17, 21, 12, 38, 727, DateTimeKind.Local).AddTicks(2123), "user1@gmail.com", "aaabb1C#", new DateTime(2022, 7, 17, 21, 12, 38, 730, DateTimeKind.Local).AddTicks(7142), "Firstuser1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { new Guid("f94fd035-2bb5-4868-b005-e67ffb86972f"), new DateTime(2022, 7, 17, 21, 12, 38, 730, DateTimeKind.Local).AddTicks(8188), "userno2@wp.pl", "bbbAFF##C1", new DateTime(2022, 7, 17, 21, 12, 38, 730, DateTimeKind.Local).AddTicks(8206), "SecondUser22" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "Password", "UpdatedAt", "UserName" },
                values: new object[] { new Guid("3b03920a-17ce-4106-83a1-b8146c476377"), new DateTime(2022, 7, 17, 21, 12, 38, 730, DateTimeKind.Local).AddTicks(8476), "testUser3@gmail.com", "test#PassworD!", new DateTime(2022, 7, 17, 21, 12, 38, 730, DateTimeKind.Local).AddTicks(8480), "thirdtestUser3" });

            migrationBuilder.InsertData(
                table: "TodoLists",
                columns: new[] { "Id", "CreatedDate", "Description", "Title", "Updated", "UserId" },
                values: new object[] { 1, new DateTime(2022, 7, 17, 21, 12, 38, 732, DateTimeKind.Local).AddTicks(1700), "test list", "My list", new DateTime(2022, 7, 17, 21, 12, 38, 732, DateTimeKind.Local).AddTicks(1966), new Guid("5f1a9b3a-90d6-4d68-a481-c63f2c2ea3ff") });

            migrationBuilder.InsertData(
                table: "TodoLists",
                columns: new[] { "Id", "CreatedDate", "Description", "Title", "Updated", "UserId" },
                values: new object[] { 2, new DateTime(2022, 7, 17, 21, 12, 38, 732, DateTimeKind.Local).AddTicks(2488), "test list", "My list2", new DateTime(2022, 7, 17, 21, 12, 38, 732, DateTimeKind.Local).AddTicks(2502), new Guid("5f1a9b3a-90d6-4d68-a481-c63f2c2ea3ff") });

            migrationBuilder.InsertData(
                table: "TodoLists",
                columns: new[] { "Id", "CreatedDate", "Description", "Title", "Updated", "UserId" },
                values: new object[] { 3, new DateTime(2022, 7, 17, 21, 12, 38, 732, DateTimeKind.Local).AddTicks(2532), "test list", "My list 3", new DateTime(2022, 7, 17, 21, 12, 38, 732, DateTimeKind.Local).AddTicks(2536), new Guid("f94fd035-2bb5-4868-b005-e67ffb86972f") });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedDate", "Description", "EndDate", "Status", "TaskListId", "Title", "Updated" },
                values: new object[] { 1, new DateTime(2022, 7, 17, 21, 12, 38, 732, DateTimeKind.Local).AddTicks(5673), null, new DateTime(2022, 7, 17, 22, 12, 38, 732, DateTimeKind.Local).AddTicks(2966), 0, 1, "Buy milk", new DateTime(2022, 7, 17, 21, 12, 38, 732, DateTimeKind.Local).AddTicks(5824) });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedDate", "Description", "EndDate", "Status", "TaskListId", "Title", "Updated" },
                values: new object[] { 3, new DateTime(2022, 7, 17, 21, 12, 38, 732, DateTimeKind.Local).AddTicks(6296), null, new DateTime(2022, 7, 17, 22, 12, 38, 732, DateTimeKind.Local).AddTicks(6289), 0, 1, "Do nothing", new DateTime(2022, 7, 17, 21, 12, 38, 732, DateTimeKind.Local).AddTicks(6299) });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedDate", "Description", "EndDate", "Status", "TaskListId", "Title", "Updated" },
                values: new object[] { 2, new DateTime(2022, 7, 17, 21, 12, 38, 732, DateTimeKind.Local).AddTicks(6253), null, new DateTime(2022, 7, 17, 22, 12, 38, 732, DateTimeKind.Local).AddTicks(6202), 0, 2, "Buy coffee", new DateTime(2022, 7, 17, 21, 12, 38, 732, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TaskListId",
                table: "Tasks",
                column: "TaskListId");

            migrationBuilder.CreateIndex(
                name: "IX_TodoLists_UserId",
                table: "TodoLists",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "TodoLists");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

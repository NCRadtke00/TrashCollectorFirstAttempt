using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class InitalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bd85b8b-2e29-4d0a-8824-70fd9b997223");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(nullable: true),
                    lastName = table.Column<string>(nullable: true),
                    street = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    zipCode = table.Column<string>(nullable: true),
                    cordinates = table.Column<string>(nullable: true),
                    initialPickUp = table.Column<string>(nullable: true),
                    additionPickup = table.Column<string>(nullable: true),
                    discontinuePickUps = table.Column<string>(nullable: true),
                    pausePickUps = table.Column<string>(nullable: true),
                    bill = table.Column<double>(nullable: false),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(nullable: true),
                    lastName = table.Column<string>(nullable: true),
                    street = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    zipCode = table.Column<string>(nullable: true),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PickUps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customersId = table.Column<int>(nullable: false),
                    employeesId = table.Column<int>(nullable: false),
                    employeesId1 = table.Column<int>(nullable: true),
                    customerTrashWasNotCollected = table.Column<bool>(nullable: false),
                    customerRecyclingWasNotCollected = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PickUps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PickUps_Customers_customersId",
                        column: x => x.customersId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PickUps_Employees_employeesId",
                        column: x => x.employeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PickUps_Employees_employeesId1",
                        column: x => x.employeesId1,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "60b910da-46a5-4bb3-9a0b-331419c3b834", "e710bf91-585c-4010-a88a-e5f06faf487e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c135c80d-5aa0-463b-a5cf-bee775d3b614", "2c716354-d8a0-4fa0-b7ce-e5bcf34f74b4", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_IdentityUserId",
                table: "Customers",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_IdentityUserId",
                table: "Employees",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PickUps_customersId",
                table: "PickUps",
                column: "customersId");

            migrationBuilder.CreateIndex(
                name: "IX_PickUps_employeesId",
                table: "PickUps",
                column: "employeesId");

            migrationBuilder.CreateIndex(
                name: "IX_PickUps_employeesId1",
                table: "PickUps",
                column: "employeesId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PickUps");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60b910da-46a5-4bb3-9a0b-331419c3b834");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c135c80d-5aa0-463b-a5cf-bee775d3b614");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7bd85b8b-2e29-4d0a-8824-70fd9b997223", "08f790b7-65ac-4b52-a0c9-cd60f4188b4c", "Admin", "ADMIN" });
        }
    }
}

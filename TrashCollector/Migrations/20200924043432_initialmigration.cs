using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b59237cc-72c4-4103-858f-bb101d35be6c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb595c4e-ebe4-4c83-ba36-770cf93276e5");

            migrationBuilder.DropColumn(
                name: "city",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "phoneNumber",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "state",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "city",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "state",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "zipCode",
                table: "Employees",
                newName: "ZipCode");

            migrationBuilder.RenameColumn(
                name: "street",
                table: "Employees",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Employees",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "Employees",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "cordinates",
                table: "Employees",
                newName: "Cordinates");

            migrationBuilder.RenameColumn(
                name: "apartmantOrSuiteNumber",
                table: "Employees",
                newName: "ApartmantOrSuiteNumber");

            migrationBuilder.RenameColumn(
                name: "zipCode",
                table: "Customers",
                newName: "ZipCode");

            migrationBuilder.RenameColumn(
                name: "street",
                table: "Customers",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "phoneNumber",
                table: "Customers",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "pausePickUp",
                table: "Customers",
                newName: "PausePickUp");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Customers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "initialPickUp",
                table: "Customers",
                newName: "InitialPickUp");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "Customers",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "discontinuePickUp",
                table: "Customers",
                newName: "DiscontinuePickUp");

            migrationBuilder.RenameColumn(
                name: "cordinates",
                table: "Customers",
                newName: "Cordinates");

            migrationBuilder.RenameColumn(
                name: "bill",
                table: "Customers",
                newName: "Bill");

            migrationBuilder.RenameColumn(
                name: "apartmantOrSuiteNumber",
                table: "Customers",
                newName: "ApartmantOrSuiteNumber");

            migrationBuilder.RenameColumn(
                name: "additionPickup",
                table: "Customers",
                newName: "AdditionPickup");

            migrationBuilder.RenameColumn(
                name: "zipCode",
                table: "Addresses",
                newName: "ZipCode");

            migrationBuilder.RenameColumn(
                name: "streetAddress",
                table: "Addresses",
                newName: "StreetAddress");

            migrationBuilder.RenameColumn(
                name: "stateName",
                table: "Addresses",
                newName: "StateName");

            migrationBuilder.RenameColumn(
                name: "cordinates",
                table: "Addresses",
                newName: "Cordinates");

            migrationBuilder.RenameColumn(
                name: "cityName",
                table: "Addresses",
                newName: "CityName");

            migrationBuilder.RenameColumn(
                name: "apartmantOrSuiteNumber",
                table: "Addresses",
                newName: "ApartmantOrSuiteNumber");

            migrationBuilder.AddColumn<string>(
                name: "CityName",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhosneNumber",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StateName",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CityName",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StateName",
                table: "Customers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a5cfd6dc-b7f1-41d9-b8b8-e4a0b2735450", "8995835b-5731-4610-9f6e-42d53153b327", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a651af97-b663-47d0-b34c-034aa83669fe", "94f96058-9872-424a-b037-5bc197a75684", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5cfd6dc-b7f1-41d9-b8b8-e4a0b2735450");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a651af97-b663-47d0-b34c-034aa83669fe");

            migrationBuilder.DropColumn(
                name: "CityName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PhosneNumber",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "StateName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CityName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "StateName",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "Employees",
                newName: "zipCode");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Employees",
                newName: "street");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Employees",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Employees",
                newName: "firstName");

            migrationBuilder.RenameColumn(
                name: "Cordinates",
                table: "Employees",
                newName: "cordinates");

            migrationBuilder.RenameColumn(
                name: "ApartmantOrSuiteNumber",
                table: "Employees",
                newName: "apartmantOrSuiteNumber");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "Customers",
                newName: "zipCode");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Customers",
                newName: "street");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Customers",
                newName: "phoneNumber");

            migrationBuilder.RenameColumn(
                name: "PausePickUp",
                table: "Customers",
                newName: "pausePickUp");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Customers",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "InitialPickUp",
                table: "Customers",
                newName: "initialPickUp");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Customers",
                newName: "firstName");

            migrationBuilder.RenameColumn(
                name: "DiscontinuePickUp",
                table: "Customers",
                newName: "discontinuePickUp");

            migrationBuilder.RenameColumn(
                name: "Cordinates",
                table: "Customers",
                newName: "cordinates");

            migrationBuilder.RenameColumn(
                name: "Bill",
                table: "Customers",
                newName: "bill");

            migrationBuilder.RenameColumn(
                name: "ApartmantOrSuiteNumber",
                table: "Customers",
                newName: "apartmantOrSuiteNumber");

            migrationBuilder.RenameColumn(
                name: "AdditionPickup",
                table: "Customers",
                newName: "additionPickup");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "Addresses",
                newName: "zipCode");

            migrationBuilder.RenameColumn(
                name: "StreetAddress",
                table: "Addresses",
                newName: "streetAddress");

            migrationBuilder.RenameColumn(
                name: "StateName",
                table: "Addresses",
                newName: "stateName");

            migrationBuilder.RenameColumn(
                name: "Cordinates",
                table: "Addresses",
                newName: "cordinates");

            migrationBuilder.RenameColumn(
                name: "CityName",
                table: "Addresses",
                newName: "cityName");

            migrationBuilder.RenameColumn(
                name: "ApartmantOrSuiteNumber",
                table: "Addresses",
                newName: "apartmantOrSuiteNumber");

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "phoneNumber",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "state",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "state",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bb595c4e-ebe4-4c83-ba36-770cf93276e5", "798c96ff-670d-40b8-900b-96bca3cb8b31", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b59237cc-72c4-4103-858f-bb101d35be6c", "7d7571be-50c2-4195-a0be-e7116dcde64f", "Employee", "EMPLOYEE" });
        }
    }
}

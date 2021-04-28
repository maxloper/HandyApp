using Microsoft.EntityFrameworkCore.Migrations;

namespace HandyApp.Migrations
{
    public partial class AddADmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "84c00263-dd07-4ead-8bab-58cb9d4f1ac8", "166162ca-85ab-477c-a76b-33547d791a0b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "18206d8c-6965-4577-9a3a-af3342b74a82", "8b725ca7-8134-4b71-857b-84baf9189f01", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UsersName" },
                values: new object[] { "a9ccbb30-d537-4577-ae0e-34ae07a96abf", 0, "603c897d-9ebc-4c48-847c-af0aef3ded04", "tester@test.com", true, false, null, "TESTER@TEST.COM", "TESTER", "AQAAAAEAACcQAAAAEGV32DNLKtUsQ3fOwOAtyu8wkr0IFlOoidjTeWWp1HqM3zeFW8uplqTEKoEFGTKK1g==", "123456789", false, "c049470f-3870-4649-a20d-775b8a8b0f68", false, "tester", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18206d8c-6965-4577-9a3a-af3342b74a82");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84c00263-dd07-4ead-8bab-58cb9d4f1ac8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9ccbb30-d537-4577-ae0e-34ae07a96abf");
        }
    }
}

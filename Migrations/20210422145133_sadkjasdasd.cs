using Microsoft.EntityFrameworkCore.Migrations;

namespace HandyApp.Migrations
{
    public partial class sadkjasdasd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeNameId",
                table: "Asigns",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Asigns_EmployeeNameId",
                table: "Asigns",
                column: "EmployeeNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asigns_Employees_EmployeeNameId",
                table: "Asigns",
                column: "EmployeeNameId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asigns_Employees_EmployeeNameId",
                table: "Asigns");

            migrationBuilder.DropIndex(
                name: "IX_Asigns_EmployeeNameId",
                table: "Asigns");

            migrationBuilder.DropColumn(
                name: "EmployeeNameId",
                table: "Asigns");
        }
    }
}

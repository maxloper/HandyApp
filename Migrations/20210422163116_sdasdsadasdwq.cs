using Microsoft.EntityFrameworkCore.Migrations;

namespace HandyApp.Migrations
{
    public partial class sdasdsadasdwq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AsignId",
                table: "Asigns",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Asigns",
                newName: "AsignId");
        }
    }
}

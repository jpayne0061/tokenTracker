using Microsoft.EntityFrameworkCore.Migrations;

namespace TokenTrackerQuickApp.Migrations
{
    public partial class AddTestProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TestProperty",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TestProperty",
                table: "AspNetUsers");
        }
    }
}

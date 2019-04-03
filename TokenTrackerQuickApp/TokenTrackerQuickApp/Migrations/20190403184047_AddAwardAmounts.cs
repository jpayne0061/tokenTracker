using Microsoft.EntityFrameworkCore.Migrations;

namespace TokenTrackerQuickApp.Migrations
{
    public partial class AddAwardAmounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AwardsBankBalance",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GiveBankBalance",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalTokensAwarded",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AwardsBankBalance",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "GiveBankBalance",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TotalTokensAwarded",
                table: "AspNetUsers");
        }
    }
}

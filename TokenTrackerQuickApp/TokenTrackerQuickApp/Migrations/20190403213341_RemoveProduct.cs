using Microsoft.EntityFrameworkCore.Migrations;

namespace TokenTrackerQuickApp.Migrations
{
    public partial class RemoveProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_AspNetUsers_Group_GroupId",
            //    table: "AspNetUsers");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_PointTransaction_Product",
            //    table: "PointTransaction");

            //migrationBuilder.DropIndex(
            //    name: "IX_AspNetUsers_GroupId",
            //    table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "AspNetUsers");

            migrationBuilder.AddForeignKey(
                name: "FK_PointTransaction_Product_ProductId",
                table: "PointTransaction",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PointTransaction_Product_ProductId",
                table: "PointTransaction");

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "AspNetUsers",
                nullable: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUsers_GroupId",
            //    table: "AspNetUsers",
            //    column: "GroupId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_AspNetUsers_Group_GroupId",
            //    table: "AspNetUsers",
            //    column: "GroupId",
            //    principalTable: "Group",
            //    principalColumn: "GroupId",
            //    onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PointTransaction_Product",
                table: "PointTransaction",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace TokenTrackerQuickApp.Migrations
{
    public partial class RemoveProductId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_PointTransaction_Product_ProductId",
            //    table: "PointTransaction");

            //migrationBuilder.AlterColumn<int>(
            //    name: "ProductId",
            //    table: "PointTransaction",
            //    nullable: true,
            //    oldClrType: typeof(int));

            //migrationBuilder.AddForeignKey(
            //    name: "FK_PointTransaction_Product_ProductId",
            //    table: "PointTransaction",
            //    column: "ProductId",
            //    principalTable: "Product",
            //    principalColumn: "ProductId",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_PointTransaction_Product_ProductId",
            //    table: "PointTransaction");

            //migrationBuilder.AlterColumn<int>(
            //    name: "ProductId",
            //    table: "PointTransaction",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldNullable: true);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_PointTransaction_Product_ProductId",
            //    table: "PointTransaction",
            //    column: "ProductId",
            //    principalTable: "Product",
            //    principalColumn: "ProductId",
            //    onDelete: ReferentialAction.Cascade);
        }
    }
}

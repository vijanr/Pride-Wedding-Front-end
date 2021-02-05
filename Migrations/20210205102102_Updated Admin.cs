using Microsoft.EntityFrameworkCore.Migrations;

namespace PrideWeddingPlanners.Migrations
{
    public partial class UpdatedAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "customer_no",
                table: "AdminTable");

            migrationBuilder.DropColumn(
                name: "vendor_no",
                table: "AdminTable");

            migrationBuilder.AddColumn<string>(
                name: "CustomerNo",
                table: "AdminTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VendorNo",
                table: "AdminTable",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerNo",
                table: "AdminTable");

            migrationBuilder.DropColumn(
                name: "VendorNo",
                table: "AdminTable");

            migrationBuilder.AddColumn<string>(
                name: "customer_no",
                table: "AdminTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "vendor_no",
                table: "AdminTable",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

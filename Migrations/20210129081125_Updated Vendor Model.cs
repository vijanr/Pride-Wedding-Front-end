using Microsoft.EntityFrameworkCore.Migrations;

namespace PrideWeddingPlanners.Migrations
{
    public partial class UpdatedVendorModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "VendorTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "retypepassword",
                table: "VendorTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "username",
                table: "VendorTable",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "password",
                table: "VendorTable");

            migrationBuilder.DropColumn(
                name: "retypepassword",
                table: "VendorTable");

            migrationBuilder.DropColumn(
                name: "username",
                table: "VendorTable");
        }
    }
}

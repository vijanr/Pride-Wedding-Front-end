using Microsoft.EntityFrameworkCore.Migrations;

namespace PrideWeddingPlanners.Migrations
{
    public partial class UpdatedPackageModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "PackagesTable");

            migrationBuilder.DropColumn(
                name: "image",
                table: "PackagesTable");

            migrationBuilder.AddColumn<string>(
                name: "imageurl",
                table: "PackagesTable",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imageurl",
                table: "PackagesTable");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "PackagesTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "PackagesTable",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

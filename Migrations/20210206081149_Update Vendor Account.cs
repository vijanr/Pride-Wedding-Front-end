using Microsoft.EntityFrameworkCore.Migrations;

namespace PrideWeddingPlanners.Migrations
{
    public partial class UpdateVendorAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "username",
                table: "VendorAccountTable",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "VendorAccountTable",
                newName: "Password");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "VendorAccountTable",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "VendorAccountTable",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "VendorAccountTable",
                newName: "username");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "VendorAccountTable",
                newName: "password");

            migrationBuilder.AlterColumn<string>(
                name: "username",
                table: "VendorAccountTable",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "VendorAccountTable",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace PrideWeddingPlanners.Migrations
{
    public partial class UpdateVendor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "company_catogary",
                table: "VendorTable");

            migrationBuilder.DropColumn(
                name: "company_name",
                table: "VendorTable");

            migrationBuilder.DropColumn(
                name: "retypepassword",
                table: "VendorTable");

            migrationBuilder.DropColumn(
                name: "tele_no",
                table: "VendorTable");

            migrationBuilder.RenameColumn(
                name: "username",
                table: "VendorTable",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "VendorTable",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "VendorTable",
                newName: "Email");

            migrationBuilder.AddColumn<string>(
                name: "CompanyCatogary",
                table: "VendorTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "VendorTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "VendorTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TelephoneNo",
                table: "VendorTable",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyCatogary",
                table: "VendorTable");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "VendorTable");

            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "VendorTable");

            migrationBuilder.DropColumn(
                name: "TelephoneNo",
                table: "VendorTable");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "VendorTable",
                newName: "username");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "VendorTable",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "VendorTable",
                newName: "email");

            migrationBuilder.AddColumn<string>(
                name: "company_catogary",
                table: "VendorTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "company_name",
                table: "VendorTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "retypepassword",
                table: "VendorTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tele_no",
                table: "VendorTable",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

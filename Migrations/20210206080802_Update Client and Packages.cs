using Microsoft.EntityFrameworkCore.Migrations;

namespace PrideWeddingPlanners.Migrations
{
    public partial class UpdateClientandPackages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "end_date",
                table: "PackagesTable");

            migrationBuilder.DropColumn(
                name: "package_no",
                table: "PackagesTable");

            migrationBuilder.DropColumn(
                name: "start_date",
                table: "PackagesTable");

            migrationBuilder.DropColumn(
                name: "Client_NIC",
                table: "ClientTable");

            migrationBuilder.DropColumn(
                name: "Tele_No",
                table: "ClientTable");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "PackagesTable",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "imageurl",
                table: "PackagesTable",
                newName: "Imageurl");

            migrationBuilder.RenameColumn(
                name: "detail",
                table: "PackagesTable",
                newName: "Detail");

            migrationBuilder.AddColumn<string>(
                name: "EndDate",
                table: "PackagesTable",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PackageNo",
                table: "PackagesTable",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "StartDate",
                table: "PackagesTable",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientNIC",
                table: "ClientTable",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeleNo",
                table: "ClientTable",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "PackagesTable");

            migrationBuilder.DropColumn(
                name: "PackageNo",
                table: "PackagesTable");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "PackagesTable");

            migrationBuilder.DropColumn(
                name: "ClientNIC",
                table: "ClientTable");

            migrationBuilder.DropColumn(
                name: "TeleNo",
                table: "ClientTable");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "PackagesTable",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Imageurl",
                table: "PackagesTable",
                newName: "imageurl");

            migrationBuilder.RenameColumn(
                name: "Detail",
                table: "PackagesTable",
                newName: "detail");

            migrationBuilder.AddColumn<string>(
                name: "end_date",
                table: "PackagesTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "package_no",
                table: "PackagesTable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "start_date",
                table: "PackagesTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Client_NIC",
                table: "ClientTable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Tele_No",
                table: "ClientTable",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

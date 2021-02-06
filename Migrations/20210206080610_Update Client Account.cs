using Microsoft.EntityFrameworkCore.Migrations;

namespace PrideWeddingPlanners.Migrations
{
    public partial class UpdateClientAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "username",
                table: "ClientAccountTable",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "ClientAccountTable",
                newName: "Password");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "ClientAccountTable",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "ClientAccountTable",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "ClientAccountTable",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "ClientAccountTable");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "ClientAccountTable",
                newName: "username");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "ClientAccountTable",
                newName: "password");

            migrationBuilder.AlterColumn<string>(
                name: "username",
                table: "ClientAccountTable",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "ClientAccountTable",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}

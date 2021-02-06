using Microsoft.EntityFrameworkCore.Migrations;

namespace PrideWeddingPlanners.Migrations
{
    public partial class UpdateClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "F_name",
                table: "ClientTable");

            migrationBuilder.DropColumn(
                name: "L_name",
                table: "ClientTable");

            migrationBuilder.DropColumn(
                name: "retypepassword",
                table: "ClientTable");

            migrationBuilder.RenameColumn(
                name: "username",
                table: "ClientTable",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "tele_no",
                table: "ClientTable",
                newName: "Tele_No");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "ClientTable",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "ClientTable",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "client_NIC",
                table: "ClientTable",
                newName: "Client_NIC");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "ClientTable",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "ClientTable",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ClientTable",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "ClientTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "ClientTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "ClientTable",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "ClientTable");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "ClientTable");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "ClientTable");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "ClientTable",
                newName: "username");

            migrationBuilder.RenameColumn(
                name: "Tele_No",
                table: "ClientTable",
                newName: "tele_no");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "ClientTable",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "ClientTable",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Client_NIC",
                table: "ClientTable",
                newName: "client_NIC");

            migrationBuilder.AlterColumn<string>(
                name: "username",
                table: "ClientTable",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "ClientTable",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "ClientTable",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "F_name",
                table: "ClientTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "L_name",
                table: "ClientTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "retypepassword",
                table: "ClientTable",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

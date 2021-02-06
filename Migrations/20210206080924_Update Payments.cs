using Microsoft.EntityFrameworkCore.Migrations;

namespace PrideWeddingPlanners.Migrations
{
    public partial class UpdatePayments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "card_no",
                table: "PaymentsTable");

            migrationBuilder.DropColumn(
                name: "cardholder_name",
                table: "PaymentsTable");

            migrationBuilder.DropColumn(
                name: "exp_date",
                table: "PaymentsTable");

            migrationBuilder.AddColumn<string>(
                name: "CardNo",
                table: "PaymentsTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CardholderName",
                table: "PaymentsTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExpDate",
                table: "PaymentsTable",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardNo",
                table: "PaymentsTable");

            migrationBuilder.DropColumn(
                name: "CardholderName",
                table: "PaymentsTable");

            migrationBuilder.DropColumn(
                name: "ExpDate",
                table: "PaymentsTable");

            migrationBuilder.AddColumn<string>(
                name: "card_no",
                table: "PaymentsTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cardholder_name",
                table: "PaymentsTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "exp_date",
                table: "PaymentsTable",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankingManagementSystem.Data.Migrations
{
    public partial class creatingAddPayeeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddPayees",
                columns: table => new
                {
                    BeneficiaryAccountNumber = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AccountNumber = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BeneficiaryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddPayees", x => new { x.AccountNumber, x.BeneficiaryAccountNumber });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddPayees");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BilNoktaSaglik.Repository.Migrations
{
    /// <inheritdoc />
    public partial class add_customersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomersName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomersSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomersDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassportNumber = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    Height = table.Column<float>(type: "real", nullable: false),
                    TREnterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAccomodation = table.Column<bool>(type: "bit", nullable: false),
                    ExtraDiscomfort = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    CountriesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomersId);
                    table.ForeignKey(
                        name: "FK_Customers_Countries_CountriesId",
                        column: x => x.CountriesId,
                        principalTable: "Countries",
                        principalColumn: "CountriesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CountriesId",
                table: "Customers",
                column: "CountriesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}

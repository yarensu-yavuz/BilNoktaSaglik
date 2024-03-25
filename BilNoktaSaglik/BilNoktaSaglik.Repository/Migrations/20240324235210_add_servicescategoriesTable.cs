using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BilNoktaSaglik.Repository.Migrations
{
    /// <inheritdoc />
    public partial class add_servicescategoriesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServiceCategories",
                columns: table => new
                {
                    ServicesCategoriesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServicesCategoriesName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoriesDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceCategories", x => x.ServicesCategoriesId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiceCategories");
        }
    }
}

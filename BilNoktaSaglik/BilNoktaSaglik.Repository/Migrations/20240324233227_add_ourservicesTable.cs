using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BilNoktaSaglik.Repository.Migrations
{
    /// <inheritdoc />
    public partial class add_ourservicesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OurServices",
                columns: table => new
                {
                    OurServicesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OurServicesName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OurServicesDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OurServices", x => x.OurServicesId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OurServices");
        }
    }
}

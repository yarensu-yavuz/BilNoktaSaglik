using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BilNoktaSaglik.Repository.Migrations
{
    /// <inheritdoc />
    public partial class user_rule_FK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RuleId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RuleId",
                table: "Users",
                column: "RuleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Rules_RuleId",
                table: "Users",
                column: "RuleId",
                principalTable: "Rules",
                principalColumn: "RulesId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Rules_RuleId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RuleId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RuleId",
                table: "Users");
        }
    }
}

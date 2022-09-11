using Microsoft.EntityFrameworkCore.Migrations;

namespace spoc1.Data.Migrations
{
    public partial class se7aMigartion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AgentId",
                table: "Pharmacies",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pharmacies_AgentId",
                table: "Pharmacies",
                column: "AgentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pharmacies_Agents_AgentId",
                table: "Pharmacies",
                column: "AgentId",
                principalTable: "Agents",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pharmacies_Agents_AgentId",
                table: "Pharmacies");

            migrationBuilder.DropIndex(
                name: "IX_Pharmacies_AgentId",
                table: "Pharmacies");

            migrationBuilder.DropColumn(
                name: "AgentId",
                table: "Pharmacies");
        }
    }
}

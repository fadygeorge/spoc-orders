using Microsoft.EntityFrameworkCore.Migrations;

namespace spoc1.Data.Migrations
{
    public partial class ne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AgentId",
                table: "Distributors",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Distributors_AgentId",
                table: "Distributors",
                column: "AgentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Distributors_Agents_AgentId",
                table: "Distributors",
                column: "AgentId",
                principalTable: "Agents",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Distributors_Agents_AgentId",
                table: "Distributors");

            migrationBuilder.DropIndex(
                name: "IX_Distributors_AgentId",
                table: "Distributors");

            migrationBuilder.DropColumn(
                name: "AgentId",
                table: "Distributors");
        }
    }
}

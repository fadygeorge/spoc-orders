using Microsoft.EntityFrameworkCore.Migrations;

namespace spoc1.Data.Migrations
{
    public partial class rrr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agents_Admins_AdminId",
                table: "Agents");

            migrationBuilder.DropIndex(
                name: "IX_Agents_AdminId",
                table: "Agents");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Agents");

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Managers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Managers_AdminId",
                table: "Managers",
                column: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Managers_Admins_AdminId",
                table: "Managers",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Managers_Admins_AdminId",
                table: "Managers");

            migrationBuilder.DropIndex(
                name: "IX_Managers_AdminId",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Managers");

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Agents",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Agents_AdminId",
                table: "Agents",
                column: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agents_Admins_AdminId",
                table: "Agents",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

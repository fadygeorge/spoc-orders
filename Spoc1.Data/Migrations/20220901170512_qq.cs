using Microsoft.EntityFrameworkCore.Migrations;

namespace spoc1.Data.Migrations
{
    public partial class qq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AgentId",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Agents",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "Agents",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AgentId",
                table: "Orders",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_Agents_AdminId",
                table: "Agents",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Agents_ManagerId",
                table: "Agents",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agents_Admins_AdminId",
                table: "Agents",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Agents_Managers_ManagerId",
                table: "Agents",
                column: "ManagerId",
                principalTable: "Managers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Agents_AgentId",
                table: "Orders",
                column: "AgentId",
                principalTable: "Agents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agents_Admins_AdminId",
                table: "Agents");

            migrationBuilder.DropForeignKey(
                name: "FK_Agents_Managers_ManagerId",
                table: "Agents");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Agents_AgentId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_AgentId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Agents_AdminId",
                table: "Agents");

            migrationBuilder.DropIndex(
                name: "IX_Agents_ManagerId",
                table: "Agents");

            migrationBuilder.DropColumn(
                name: "AgentId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Agents");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "Agents");
        }
    }
}

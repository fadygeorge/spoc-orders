using Microsoft.EntityFrameworkCore.Migrations;

namespace spoc1.Data.Migrations
{
    public partial class aa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Distributors_Distributorid",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Pharmacies_PharmaId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PharmaId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PharmaId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "Distributorid",
                table: "Orders",
                newName: "DistributorId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_Distributorid",
                table: "Orders",
                newName: "IX_Orders_DistributorId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Distributors",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "PharmacyId",
                table: "Orders",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PharmacyId",
                table: "Orders",
                column: "PharmacyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Distributors_DistributorId",
                table: "Orders",
                column: "DistributorId",
                principalTable: "Distributors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Pharmacies_PharmacyId",
                table: "Orders",
                column: "PharmacyId",
                principalTable: "Pharmacies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Distributors_DistributorId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Pharmacies_PharmacyId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PharmacyId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PharmacyId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "DistributorId",
                table: "Orders",
                newName: "Distributorid");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_DistributorId",
                table: "Orders",
                newName: "IX_Orders_Distributorid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Distributors",
                newName: "id");

            migrationBuilder.AddColumn<int>(
                name: "PharmaId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PharmaId",
                table: "Orders",
                column: "PharmaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Distributors_Distributorid",
                table: "Orders",
                column: "Distributorid",
                principalTable: "Distributors",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Pharmacies_PharmaId",
                table: "Orders",
                column: "PharmaId",
                principalTable: "Pharmacies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDealer.DataAccess.Migrations
{
    public partial class AddForeignKeysToTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarModelId",
                table: "DealerCars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "DealerCars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CarModelNameId",
                table: "CarModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DealerId",
                table: "CarModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DealerCars_CarModelId",
                table: "DealerCars",
                column: "CarModelId");

            migrationBuilder.CreateIndex(
                name: "IX_DealerCars_ColorId",
                table: "DealerCars",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_CarModels_CarModelNameId",
                table: "CarModels",
                column: "CarModelNameId");

            migrationBuilder.CreateIndex(
                name: "IX_CarModels_DealerId",
                table: "CarModels",
                column: "DealerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarModels_CarModelNames_CarModelNameId",
                table: "CarModels",
                column: "CarModelNameId",
                principalTable: "CarModelNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarModels_Dealers_DealerId",
                table: "CarModels",
                column: "DealerId",
                principalTable: "Dealers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DealerCars_CarModels_CarModelId",
                table: "DealerCars",
                column: "CarModelId",
                principalTable: "CarModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DealerCars_Colors_ColorId",
                table: "DealerCars",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarModels_CarModelNames_CarModelNameId",
                table: "CarModels");

            migrationBuilder.DropForeignKey(
                name: "FK_CarModels_Dealers_DealerId",
                table: "CarModels");

            migrationBuilder.DropForeignKey(
                name: "FK_DealerCars_CarModels_CarModelId",
                table: "DealerCars");

            migrationBuilder.DropForeignKey(
                name: "FK_DealerCars_Colors_ColorId",
                table: "DealerCars");

            migrationBuilder.DropIndex(
                name: "IX_DealerCars_CarModelId",
                table: "DealerCars");

            migrationBuilder.DropIndex(
                name: "IX_DealerCars_ColorId",
                table: "DealerCars");

            migrationBuilder.DropIndex(
                name: "IX_CarModels_CarModelNameId",
                table: "CarModels");

            migrationBuilder.DropIndex(
                name: "IX_CarModels_DealerId",
                table: "CarModels");

            migrationBuilder.DropColumn(
                name: "CarModelId",
                table: "DealerCars");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "DealerCars");

            migrationBuilder.DropColumn(
                name: "CarModelNameId",
                table: "CarModels");

            migrationBuilder.DropColumn(
                name: "DealerId",
                table: "CarModels");
        }
    }
}

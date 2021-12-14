using Microsoft.EntityFrameworkCore.Migrations;

namespace ajax.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Countries_Country_ID",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "Country_ID",
                table: "Patients",
                newName: "country_id");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_Country_ID",
                table: "Patients",
                newName: "IX_Patients_country_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Countries_country_id",
                table: "Patients",
                column: "country_id",
                principalTable: "Countries",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Countries_country_id",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "country_id",
                table: "Patients",
                newName: "Country_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_country_id",
                table: "Patients",
                newName: "IX_Patients_Country_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Countries_Country_ID",
                table: "Patients",
                column: "Country_ID",
                principalTable: "Countries",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

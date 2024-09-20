using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend_D_D.Migrations
{
    /// <inheritdoc />
    public partial class vediamosefunge : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Personaggio_IdUtente",
                table: "Personaggio",
                column: "IdUtente");

            migrationBuilder.AddForeignKey(
                name: "FK_Personaggio_Utente_IdUtente",
                table: "Personaggio",
                column: "IdUtente",
                principalTable: "Utente",
                principalColumn: "UtenteId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personaggio_Utente_IdUtente",
                table: "Personaggio");

            migrationBuilder.DropIndex(
                name: "IX_Personaggio_IdUtente",
                table: "Personaggio");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend_D_D.Migrations
{
    /// <inheritdoc />
    public partial class aggiornamentobackend : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Passoword",
                table: "Utente",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NomeUtente",
                table: "Utente",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Utente",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Personaggio",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Tiri_Salvezza_PersonaggioID",
                table: "Tiri_Salvezza",
                column: "PersonaggioID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inventario_PersonaggioID",
                table: "Inventario",
                column: "PersonaggioID");

            migrationBuilder.CreateIndex(
                name: "IX_Classi_PersonaggioID",
                table: "Classi",
                column: "PersonaggioID");

            migrationBuilder.CreateIndex(
                name: "IX_Backgound_PersonaggioID",
                table: "Backgound",
                column: "PersonaggioID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Attributi_PersonaggioID",
                table: "Attributi",
                column: "PersonaggioID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Armi_PersonaggioID",
                table: "Armi",
                column: "PersonaggioID");

            migrationBuilder.CreateIndex(
                name: "IX_Armatura_PersonaggioID",
                table: "Armatura",
                column: "PersonaggioID");

            migrationBuilder.CreateIndex(
                name: "IX_Abilita_PersonaggioID",
                table: "Abilita",
                column: "PersonaggioID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Abilita_Personaggio_PersonaggioID",
                table: "Abilita",
                column: "PersonaggioID",
                principalTable: "Personaggio",
                principalColumn: "PersonaggioID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Armatura_Personaggio_PersonaggioID",
                table: "Armatura",
                column: "PersonaggioID",
                principalTable: "Personaggio",
                principalColumn: "PersonaggioID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Armi_Personaggio_PersonaggioID",
                table: "Armi",
                column: "PersonaggioID",
                principalTable: "Personaggio",
                principalColumn: "PersonaggioID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Attributi_Personaggio_PersonaggioID",
                table: "Attributi",
                column: "PersonaggioID",
                principalTable: "Personaggio",
                principalColumn: "PersonaggioID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Backgound_Personaggio_PersonaggioID",
                table: "Backgound",
                column: "PersonaggioID",
                principalTable: "Personaggio",
                principalColumn: "PersonaggioID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Classi_Personaggio_PersonaggioID",
                table: "Classi",
                column: "PersonaggioID",
                principalTable: "Personaggio",
                principalColumn: "PersonaggioID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventario_Personaggio_PersonaggioID",
                table: "Inventario",
                column: "PersonaggioID",
                principalTable: "Personaggio",
                principalColumn: "PersonaggioID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tiri_Salvezza_Personaggio_PersonaggioID",
                table: "Tiri_Salvezza",
                column: "PersonaggioID",
                principalTable: "Personaggio",
                principalColumn: "PersonaggioID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abilita_Personaggio_PersonaggioID",
                table: "Abilita");

            migrationBuilder.DropForeignKey(
                name: "FK_Armatura_Personaggio_PersonaggioID",
                table: "Armatura");

            migrationBuilder.DropForeignKey(
                name: "FK_Armi_Personaggio_PersonaggioID",
                table: "Armi");

            migrationBuilder.DropForeignKey(
                name: "FK_Attributi_Personaggio_PersonaggioID",
                table: "Attributi");

            migrationBuilder.DropForeignKey(
                name: "FK_Backgound_Personaggio_PersonaggioID",
                table: "Backgound");

            migrationBuilder.DropForeignKey(
                name: "FK_Classi_Personaggio_PersonaggioID",
                table: "Classi");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventario_Personaggio_PersonaggioID",
                table: "Inventario");

            migrationBuilder.DropForeignKey(
                name: "FK_Tiri_Salvezza_Personaggio_PersonaggioID",
                table: "Tiri_Salvezza");

            migrationBuilder.DropIndex(
                name: "IX_Tiri_Salvezza_PersonaggioID",
                table: "Tiri_Salvezza");

            migrationBuilder.DropIndex(
                name: "IX_Inventario_PersonaggioID",
                table: "Inventario");

            migrationBuilder.DropIndex(
                name: "IX_Classi_PersonaggioID",
                table: "Classi");

            migrationBuilder.DropIndex(
                name: "IX_Backgound_PersonaggioID",
                table: "Backgound");

            migrationBuilder.DropIndex(
                name: "IX_Attributi_PersonaggioID",
                table: "Attributi");

            migrationBuilder.DropIndex(
                name: "IX_Armi_PersonaggioID",
                table: "Armi");

            migrationBuilder.DropIndex(
                name: "IX_Armatura_PersonaggioID",
                table: "Armatura");

            migrationBuilder.DropIndex(
                name: "IX_Abilita_PersonaggioID",
                table: "Abilita");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Personaggio");

            migrationBuilder.AlterColumn<string>(
                name: "Passoword",
                table: "Utente",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "NomeUtente",
                table: "Utente",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Utente",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}

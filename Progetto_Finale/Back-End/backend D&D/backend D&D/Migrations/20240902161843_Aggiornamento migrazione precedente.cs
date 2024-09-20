using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend_D_D.Migrations
{
    /// <inheritdoc />
    public partial class Aggiornamentomigrazioneprecedente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abilita",
                columns: table => new
                {
                    AbilitaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonaggioID = table.Column<int>(type: "int", nullable: false),
                    Acrobazia = table.Column<bool>(type: "bit", nullable: false),
                    Addestrare_Animali = table.Column<bool>(type: "bit", nullable: false),
                    Arcano = table.Column<bool>(type: "bit", nullable: false),
                    Atletica = table.Column<bool>(type: "bit", nullable: false),
                    Furtivita = table.Column<bool>(type: "bit", nullable: false),
                    Indagare = table.Column<bool>(type: "bit", nullable: false),
                    Inganno = table.Column<bool>(type: "bit", nullable: false),
                    Intimidire = table.Column<bool>(type: "bit", nullable: false),
                    Intrattenere = table.Column<bool>(type: "bit", nullable: false),
                    Intuizione = table.Column<bool>(type: "bit", nullable: false),
                    Medicina = table.Column<bool>(type: "bit", nullable: false),
                    Natura = table.Column<bool>(type: "bit", nullable: false),
                    Percezione = table.Column<bool>(type: "bit", nullable: false),
                    Persuasione = table.Column<bool>(type: "bit", nullable: false),
                    Rapidita_di_Mano = table.Column<bool>(type: "bit", nullable: false),
                    Religione = table.Column<bool>(type: "bit", nullable: false),
                    Sopravvivenza = table.Column<bool>(type: "bit", nullable: false),
                    Storia = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abilita", x => x.AbilitaId);
                });

            migrationBuilder.CreateTable(
                name: "Armatura",
                columns: table => new
                {
                    ArmaturaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonaggioID = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CA = table.Column<int>(type: "int", nullable: false),
                    Effetto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armatura", x => x.ArmaturaId);
                });

            migrationBuilder.CreateTable(
                name: "Armi",
                columns: table => new
                {
                    ArmaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonaggioID = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Danno = table.Column<int>(type: "int", nullable: false),
                    BonusArma = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armi", x => x.ArmaId);
                });

            migrationBuilder.CreateTable(
                name: "Attributi",
                columns: table => new
                {
                    AttributiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonaggioID = table.Column<int>(type: "int", nullable: false),
                    Forza = table.Column<int>(type: "int", nullable: false),
                    Destrezza = table.Column<int>(type: "int", nullable: false),
                    Costituzione = table.Column<int>(type: "int", nullable: false),
                    Saggezza = table.Column<int>(type: "int", nullable: false),
                    Intelligenza = table.Column<int>(type: "int", nullable: false),
                    Carisma = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attributi", x => x.AttributiId);
                });

            migrationBuilder.CreateTable(
                name: "Inventario",
                columns: table => new
                {
                    InventarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonaggioID = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Effetto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventario", x => x.InventarioId);
                });

            migrationBuilder.CreateTable(
                name: "Tiri_Salvezza",
                columns: table => new
                {
                    TiriSalvezzaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonaggioID = table.Column<int>(type: "int", nullable: false),
                    Forza = table.Column<bool>(type: "bit", nullable: false),
                    Destrezza = table.Column<bool>(type: "bit", nullable: false),
                    Costituzione = table.Column<bool>(type: "bit", nullable: false),
                    Saggezza = table.Column<bool>(type: "bit", nullable: false),
                    Intelligenza = table.Column<bool>(type: "bit", nullable: false),
                    Carisma = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tiri_Salvezza", x => x.TiriSalvezzaId);
                });

            migrationBuilder.CreateTable(
                name: "Utente",
                columns: table => new
                {
                    UtenteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeUtente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Passoword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utente", x => x.UtenteId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abilita");

            migrationBuilder.DropTable(
                name: "Armatura");

            migrationBuilder.DropTable(
                name: "Armi");

            migrationBuilder.DropTable(
                name: "Attributi");

            migrationBuilder.DropTable(
                name: "Inventario");

            migrationBuilder.DropTable(
                name: "Tiri_Salvezza");

            migrationBuilder.DropTable(
                name: "Utente");
        }
    }
}

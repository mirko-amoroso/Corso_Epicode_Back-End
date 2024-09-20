using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend_D_D.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Backgound",
                columns: table => new
                {
                    BackgroundId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonaggioID = table.Column<int>(type: "int", nullable: false),
                    TrattiCaratteriali = table.Column<int>(type: "int", nullable: false),
                    Ideali = table.Column<int>(type: "int", nullable: false),
                    Legami = table.Column<int>(type: "int", nullable: false),
                    Difetti = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Backgound", x => x.BackgroundId);
                });

            migrationBuilder.CreateTable(
                name: "Classi",
                columns: table => new
                {
                    ClassiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonaggioID = table.Column<int>(type: "int", nullable: false),
                    Livello = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classi", x => x.ClassiId);
                });

            migrationBuilder.CreateTable(
                name: "Personaggio",
                columns: table => new
                {
                    PersonaggioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Allineamento = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    IdUtente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personaggio", x => x.PersonaggioID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Backgound");

            migrationBuilder.DropTable(
                name: "Classi");

            migrationBuilder.DropTable(
                name: "Personaggio");
        }
    }
}

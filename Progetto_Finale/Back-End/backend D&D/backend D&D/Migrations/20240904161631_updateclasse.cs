using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend_D_D.Migrations
{
    /// <inheritdoc />
    public partial class updateclasse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoClasse",
                table: "Classi",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoClasse",
                table: "Classi");
        }
    }
}

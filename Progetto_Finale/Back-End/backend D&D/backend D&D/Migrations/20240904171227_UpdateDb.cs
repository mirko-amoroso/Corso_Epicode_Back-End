using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend_D_D.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Allineamento",
                table: "Personaggio");

            migrationBuilder.AddColumn<string>(
                name: "Allineamento",
                table: "Backgound",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Allineamento",
                table: "Backgound");

            migrationBuilder.AddColumn<int>(
                name: "Allineamento",
                table: "Personaggio",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

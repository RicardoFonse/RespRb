using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SenaiAlimentos.Migrations
{
    /// <inheritdoc />
    public partial class ModificaIdioma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Nivel",
                newName: "Nome");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Nivel",
                newName: "Name");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Apiexploretuor.Migrations
{
    /// <inheritdoc />
    public partial class Felipe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GameUrl",
                table: "destinos",
                newName: "DestinoUrl");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DestinoUrl",
                table: "destinos",
                newName: "GameUrl");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GiselleSchroeder.Migrations
{
    /// <inheritdoc />
    public partial class Folha2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "quantidade",
                table: "Folhas",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "quantidade",
                table: "Folhas");
        }
    }
}

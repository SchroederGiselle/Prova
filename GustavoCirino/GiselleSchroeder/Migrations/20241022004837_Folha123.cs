using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GiselleSchroeder.Migrations
{
    /// <inheritdoc />
    public partial class Folha123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "funcionarioId",
                table: "Folhas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "funcionarioId",
                table: "Folhas",
                type: "TEXT",
                nullable: true);
        }
    }
}

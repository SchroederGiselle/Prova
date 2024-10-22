using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GiselleSchroeder.Migrations
{
    /// <inheritdoc />
    public partial class Folha1234 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Folhas",
                table: "Folhas");

            migrationBuilder.DropColumn(
                name: "folhaId",
                table: "Folhas");

            migrationBuilder.AlterColumn<string>(
                name: "valor",
                table: "Folhas",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "funcionarioId",
                table: "Folhas",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Folhas",
                table: "Folhas",
                column: "valor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Folhas",
                table: "Folhas");

            migrationBuilder.DropColumn(
                name: "funcionarioId",
                table: "Folhas");

            migrationBuilder.AlterColumn<string>(
                name: "valor",
                table: "Folhas",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "folhaId",
                table: "Folhas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Folhas",
                table: "Folhas",
                column: "folhaId");
        }
    }
}

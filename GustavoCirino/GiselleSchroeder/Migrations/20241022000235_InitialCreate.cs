﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GiselleSchroeder.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    cpf = table.Column<string>(type: "TEXT", nullable: false),
                    nome = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.cpf);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionarios");
        }
    }
}

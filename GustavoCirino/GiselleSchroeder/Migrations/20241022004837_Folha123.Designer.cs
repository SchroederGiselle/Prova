﻿// <auto-generated />
using GiselleSchroeder.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GiselleSchroeder.Migrations
{
    [DbContext(typeof(AppDataContext))]
    [Migration("20241022004837_Folha123")]
    partial class Folha123
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("GiselleSchroeder.Models.Folha", b =>
                {
                    b.Property<string>("folhaId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ano")
                        .HasColumnType("TEXT");

                    b.Property<string>("mes")
                        .HasColumnType("TEXT");

                    b.Property<string>("quantidade")
                        .HasColumnType("TEXT");

                    b.Property<string>("valor")
                        .HasColumnType("TEXT");

                    b.HasKey("folhaId");

                    b.ToTable("Folhas");
                });

            modelBuilder.Entity("GiselleSchroeder.Models.Funcionario", b =>
                {
                    b.Property<string>("cpf")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.HasKey("cpf");

                    b.ToTable("Funcionarios");
                });
#pragma warning restore 612, 618
        }
    }
}
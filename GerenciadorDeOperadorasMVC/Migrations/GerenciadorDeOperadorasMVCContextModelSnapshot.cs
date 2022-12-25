﻿// <auto-generated />
using System;
using GerenciadorDeOperadorasMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GerenciadorDeOperadorasMVC.Migrations
{
    [DbContext(typeof(GerenciadorDeOperadorasMVCContext))]
    partial class GerenciadorDeOperadorasMVCContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GerenciadorDeOperadorasMVC.Models.Beneficiario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Aniversario");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<int>("OperadoraId");

                    b.Property<double>("ValorPlano");

                    b.HasKey("Id");

                    b.HasIndex("OperadoraId");

                    b.ToTable("Beneficiario");
                });

            modelBuilder.Entity("GerenciadorDeOperadorasMVC.Models.Operadora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Operadora");
                });

            modelBuilder.Entity("GerenciadorDeOperadorasMVC.Models.RegistroPlano", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BeneficiarioId");

                    b.Property<DateTime>("Data");

                    b.Property<int>("Status");

                    b.Property<double>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("BeneficiarioId");

                    b.ToTable("RegistroPlano");
                });

            modelBuilder.Entity("GerenciadorDeOperadorasMVC.Models.Beneficiario", b =>
                {
                    b.HasOne("GerenciadorDeOperadorasMVC.Models.Operadora", "Operadora")
                        .WithMany("Beneficiarios")
                        .HasForeignKey("OperadoraId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GerenciadorDeOperadorasMVC.Models.RegistroPlano", b =>
                {
                    b.HasOne("GerenciadorDeOperadorasMVC.Models.Beneficiario", "Beneficiario")
                        .WithMany("Planos")
                        .HasForeignKey("BeneficiarioId");
                });
#pragma warning restore 612, 618
        }
    }
}

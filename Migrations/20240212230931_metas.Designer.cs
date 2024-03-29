﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parcial1_AP1_YudelkaGuillen.Context;

#nullable disable

namespace Parcial1_AP1_YudelkaGuillen.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240212230931_metas")]
    partial class metas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("Parcial1_AP1_YudelkaGuillen.Models.Metas", b =>
                {
                    b.Property<int>("MetasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Fecha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Monto")
                        .HasColumnType("REAL");

                    b.HasKey("MetasId");

                    b.ToTable("Metas");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TpDojo.Data;

#nullable disable

namespace TpDojo.Migrations
{
    [DbContext(typeof(TpDojoContext))]
    [Migration("20221220084448_cascading test 2")]
    partial class cascadingtest2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BO.Arme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Degat")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Arme");
                });

            modelBuilder.Entity("BO.Samurai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ArmeId")
                        .HasColumnType("int");

                    b.Property<int>("Force")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ArmeId")
                        .IsUnique()
                        .HasFilter("[ArmeId] IS NOT NULL");

                    b.ToTable("Samurai");
                });

            modelBuilder.Entity("BO.Samurai", b =>
                {
                    b.HasOne("BO.Arme", "Arme")
                        .WithOne()
                        .HasForeignKey("BO.Samurai", "ArmeId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Arme");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WikiGC.Data;

#nullable disable

namespace WikiGC.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WikiGC.Models.Portais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool?>("Ativo")
                        .HasColumnType("bit");

                    b.Property<bool?>("Atualizado")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Responsavel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServidorHomologacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServidorProducao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlHomologacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlProducao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VersaoWordpressHomologacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VersaoWordpressProducao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Portais");
                });
#pragma warning restore 612, 618
        }
    }
}

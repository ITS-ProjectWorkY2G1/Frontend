﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModelsOnPrem;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ModelsOnPrem.Migrations
{
    [DbContext(typeof(PostgresContext))]
    [Migration("20230630110049_migration2")]
    partial class migration2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ModelsOnPrem.SmartwatchesOnPrem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("BuyingDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("buying_date");

                    b.Property<string>("ProductionBatch")
                        .HasColumnType("text")
                        .HasColumnName("production_batch");

                    b.HasKey("Id");

                    b.ToTable("smartwatches", "pw_gruppo1");
                });
#pragma warning restore 612, 618
        }
    }
}
﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sabatex.ObjectsExchange.Server.Data;

#nullable disable

namespace Sabatex.ObjectsExchange.Server.Data.Migrations
{
    [DbContext(typeof(ObjectsExchangeDbContext))]
    [Migration("20230220102240_m0")]
    partial class m0
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.14");

            modelBuilder.Entity("sabatex.ObjectsExchange.Models.ObjectExchange", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateStamp")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Destination")
                        .HasColumnType("TEXT");

                    b.Property<string>("ObjectAsText")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ObjectId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("ObjectType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Sender")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Destination");

                    b.HasIndex("Sender");

                    b.ToTable("ObjectExchanges");
                });

            modelBuilder.Entity("sabatex.ObjectsExchange.Models.QueryObject", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("Destination")
                        .HasColumnType("TEXT");

                    b.Property<string>("ObjectId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("ObjectType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Sender")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Destination");

                    b.HasIndex("Sender");

                    b.ToTable("QueryObjects");
                });

            modelBuilder.Entity("Sabatex.ObjectsExchange.Server.Data.AutenficatedNode", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AutenficatedNodes");
                });

            modelBuilder.Entity("Sabatex.ObjectsExchange.Server.Data.ClientNode", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientAccess")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ClientNodes");
                });

            modelBuilder.Entity("sabatex.ObjectsExchange.Models.ObjectExchange", b =>
                {
                    b.HasOne("Sabatex.ObjectsExchange.Server.Data.ClientNode", null)
                        .WithMany()
                        .HasForeignKey("Destination")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sabatex.ObjectsExchange.Server.Data.ClientNode", null)
                        .WithMany()
                        .HasForeignKey("Sender")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("sabatex.ObjectsExchange.Models.QueryObject", b =>
                {
                    b.HasOne("Sabatex.ObjectsExchange.Server.Data.ClientNode", null)
                        .WithMany()
                        .HasForeignKey("Destination")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sabatex.ObjectsExchange.Server.Data.ClientNode", null)
                        .WithMany()
                        .HasForeignKey("Sender")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

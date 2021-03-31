﻿// <auto-generated />

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookApp.Orders.Persistence.Migrations
{
    [DbContext(typeof(OrderDbContext))]
    [Migration("20200819130416_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-preview.7.20365.15");

            modelBuilder.Entity("BookApp.Domain.Orders.LineItem", b =>
                {
                    b.Property<int>("LineItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<decimal>("BookPrice")
                        .HasPrecision(9, 2)
                        .HasColumnType("decimal(9,2)");

                    b.Property<int?>("BookViewBookId")
                        .HasColumnType("int");

                    b.Property<byte>("LineNum")
                        .HasColumnType("tinyint");

                    b.Property<short>("NumBooks")
                        .HasColumnType("smallint");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("LineItemId");

                    b.HasIndex("BookViewBookId");

                    b.HasIndex("OrderId");

                    b.ToTable("LineItem");
                });

            modelBuilder.Entity("BookApp.Domain.Orders.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateOrderedUtc")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BookApp.Domain.Orders.LineItem", b =>
                {
                    b.HasOne("BookApp.Domain.Orders.BookView", "BookView")
                        .WithMany()
                        .HasForeignKey("BookViewBookId");

                    b.HasOne("BookApp.Domain.Orders.Order", null)
                        .WithMany("LineItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using ApiCrud;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiCrud.Migrations
{
    [DbContext(typeof(TodoContext))]
    partial class TodoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("ApiCrud.Models.TblBook", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("BookID");

                    b.Property<string>("Author")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("Isbn")
                        .HasColumnName("ISBN")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<int?>("PublishedYear");

                    b.Property<string>("Publisher")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Title")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.HasKey("BookId");

                    b.ToTable("TblBook");
                });

            modelBuilder.Entity("ApiCrud.Models.TblUser", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UserID");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("FullName")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<byte[]>("Password")
                        .HasMaxLength(128);

                    b.Property<byte[]>("Salt")
                        .HasMaxLength(128);

                    b.HasKey("UserId");

                    b.ToTable("TblUser");
                });
#pragma warning restore 612, 618
        }
    }
}
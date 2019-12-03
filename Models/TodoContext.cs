using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.InMemory;
using ApiCrud.Models;

namespace ApiCrud
{
    public partial class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {  
       
        }
        public virtual DbSet<TblBook> TblBook { get; set; }
        public virtual DbSet<TblUser> TblUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
 
        public  void OnJeroen()
        {
            this.TblBook.Add(new TblBook()
            {
                Author = "Schrijver 1",
                Description = "Omschrijving 1",
                Isbn = "abcde",
                Price = 100,
                PublishedYear = 1960,
                Publisher = "Uitgever 1",
                Title = "Titel 1"
            });
            this.TblBook.Add(new TblBook()
            {
                Author = "Schrijver 2",
                Description = "Omschrijving 2",
                Isbn = "abcde",
                Price = 100,
                PublishedYear = 1960,
                Publisher = "Uitgever 2",
                Title = "Titel 2"
            });
            this.TblBook.Add(new TblBook()
            {
                Author = "Schrijver 3",
                Description = "Omschrijving 3",
                Isbn = "abcde",
                Price = 100,
                PublishedYear = 1960,
                Publisher = "Uitgever 3",
                Title = "Titel 3"
            });
            this.TblBook.Add(new TblBook()
            {
                Author = "Schrijver 4",
                Description = "Omschrijving 4",
                Isbn = "abcde",
                Price = 100,
                PublishedYear = 1960,
                Publisher = "Uitgever 4",
                Title = "Titel 4"
            });
            this.TblBook.Add(new TblBook()
            {
                Author = "Schrijver 5",

                Description = "Omschrijving 5",
                Isbn = "abcde",
                Price = 100,
                PublishedYear = 1960,
                Publisher = "Uitgever 5",
                Title = "Titel 5"
            });
            this.TblUser.Add(new TblUser()
            {
                Email = "aaa@bbb.nl",
                FullName = "Aaa bbbwenaar",

            });
            this.TblUser.Add(new TblUser()
            {
                Email = "aaa@ccc.nl",
                FullName = "Aaa cccwenaar",

            });
            this.TblUser.Add(new TblUser()
            {
                Email = "aaa@ddd.nl",
                FullName = "Aaa dddwenaar",

            });
            this.SaveChanges();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblBook>(entity =>
        {
            entity.HasKey(e => e.BookId);

            entity.Property(e => e.BookId).HasColumnName("BookID");

            entity.Property(e => e.Author)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Isbn)
                .HasColumnName("ISBN")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

            entity.Property(e => e.Publisher)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblUser>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Password).HasMaxLength(128);

            entity.Property(e => e.Salt).HasMaxLength(128);
        });


            OnModelCreatingPartial(modelBuilder);
        }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}



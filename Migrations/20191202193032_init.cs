using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiCrud.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblBook",
                columns: table => new
                {
                    BookID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    ISBN = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Title = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Author = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    Publisher = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PublishedYear = table.Column<int>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18, 0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblBook", x => x.BookID);
                });

            migrationBuilder.CreateTable(
                name: "TblUser",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    FullName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Password = table.Column<byte[]>(maxLength: 128, nullable: true),
                    Salt = table.Column<byte[]>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblUser", x => x.UserID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblBook");

            migrationBuilder.DropTable(
                name: "TblUser");
        }
    }
}

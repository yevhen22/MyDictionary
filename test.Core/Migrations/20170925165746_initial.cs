using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace test.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Englishwords",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataTime = table.Column<DateTime>(nullable: false),
                    EngWord = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Englishwords", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UAWords",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EnglishID = table.Column<int>(nullable: false),
                    EnglishWordID = table.Column<int>(nullable: true),
                    UAword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UAWords", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UAWords_Englishwords_EnglishWordID",
                        column: x => x.EnglishWordID,
                        principalTable: "Englishwords",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UAWords_EnglishWordID",
                table: "UAWords",
                column: "EnglishWordID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UAWords");

            migrationBuilder.DropTable(
                name: "Englishwords");
        }
    }
}

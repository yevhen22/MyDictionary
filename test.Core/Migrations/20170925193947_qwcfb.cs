using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace test.Migrations
{
    public partial class qwcfb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Englishwords",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Currenttime = table.Column<DateTime>(nullable: false),
                    Engword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Englishwords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UAWords",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EnglishWordId = table.Column<int>(nullable: false),
                    Uaword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UAWords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UAWords_Englishwords_EnglishWordId",
                        column: x => x.EnglishWordId,
                        principalTable: "Englishwords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UAWords_EnglishWordId",
                table: "UAWords",
                column: "EnglishWordId");
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

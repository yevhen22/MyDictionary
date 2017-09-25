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
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    currenttime = table.Column<DateTime>(nullable: false),
                    engword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Englishwords", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UAWords",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    englishWordId = table.Column<int>(nullable: false),
                    uaword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UAWords", x => x.id);
                    table.ForeignKey(
                        name: "FK_UAWords_Englishwords_englishWordId",
                        column: x => x.englishWordId,
                        principalTable: "Englishwords",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UAWords_englishWordId",
                table: "UAWords",
                column: "englishWordId");
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

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using test.DataBase;

namespace test.Migrations
{
    [DbContext(typeof(DictionaryContext))]
    [Migration("20170925193947_qwcfb")]
    partial class qwcfb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("test.Models.EnglishWord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Currenttime");

                    b.Property<string>("Engword");

                    b.HasKey("Id");

                    b.ToTable("Englishwords");
                });

            modelBuilder.Entity("test.Models.UAWord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EnglishWordId");

                    b.Property<string>("Uaword");

                    b.HasKey("Id");

                    b.HasIndex("EnglishWordId");

                    b.ToTable("UAWords");
                });

            modelBuilder.Entity("test.Models.UAWord", b =>
                {
                    b.HasOne("test.Models.EnglishWord", "Englishword")
                        .WithMany("uaword")
                        .HasForeignKey("EnglishWordId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using test.DataBase;

namespace test.Migrations
{
    [DbContext(typeof(DictionaryContext))]
    [Migration("20170925171701_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("test.Models.EnglishWord", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("currenttime");

                    b.Property<string>("engword");

                    b.HasKey("id");

                    b.ToTable("Englishwords");
                });

            modelBuilder.Entity("test.Models.UAWord", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("englishWordId");

                    b.Property<string>("uaword");

                    b.HasKey("id");

                    b.HasIndex("englishWordId");

                    b.ToTable("UAWords");
                });

            modelBuilder.Entity("test.Models.UAWord", b =>
                {
                    b.HasOne("test.Models.EnglishWord", "englishword")
                        .WithMany("uaword")
                        .HasForeignKey("englishWordId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}

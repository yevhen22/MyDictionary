using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using test.DataBase;

namespace test.Migrations
{
    [DbContext(typeof(DictionaryContext))]
    partial class DictionaryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("test.Models.EnglishWord", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataTime");

                    b.Property<string>("EngWord");

                    b.HasKey("ID");

                    b.ToTable("Englishwords");
                });

            modelBuilder.Entity("test.Models.UAWord", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EnglishID");

                    b.Property<int?>("EnglishWordID");

                    b.Property<string>("UAword");

                    b.HasKey("ID");

                    b.HasIndex("EnglishWordID");

                    b.ToTable("UAWords");
                });

            modelBuilder.Entity("test.Models.UAWord", b =>
                {
                    b.HasOne("test.Models.EnglishWord", "EnglishWord")
                        .WithMany("uaword")
                        .HasForeignKey("EnglishWordID");
                });
        }
    }
}

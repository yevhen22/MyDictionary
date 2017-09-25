using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using test.Models;
using Microsoft.Data.Sqlite;
using SQLite;


namespace test.DataBase
{
    public class DictionaryContext : DbContext
    {
        string databasepath;
        public DictionaryContext(string path):base()
        {
          
            databasepath = path;
           
        }

        public DictionaryContext() 
        {
        }
        public DbSet<EnglishWord> Englishword { get; set; }
        public DbSet<UAWord> Uaword { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<EnglishWord>().ToTable("Englishwords");
            modelBuilder.Entity<UAWord>().ToTable("UAWords");

            modelBuilder.Entity<EnglishWord>().HasKey(p => p.ID);
            modelBuilder.Entity<UAWord>().HasKey(p => p.ID);
            

            modelBuilder.Entity<EnglishWord>().HasMany(p => p.uaword).WithOne(p => p.EnglishWord);
            modelBuilder.Entity<UAWord>().HasOne(i => i.EnglishWord).WithMany(p=>p.uaword);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connbuilder = new SqliteConnectionStringBuilder
            {
                DataSource = databasepath
            }.ToString();

            var conn = new SqliteConnection(connbuilder);
            optionsBuilder.UseSqlite(conn);
           // optionsBuilder.UseSqlite($"Filename={databasepath}");
        }
    }
}

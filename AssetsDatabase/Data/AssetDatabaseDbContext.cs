using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace AssetsDatabase.Data
{
    public class AssetDatabaseDbContext : DbContext
    {
        public string DbPath { get; }

        public AssetDatabaseDbContext(string dbPath)
        {
            var folder = Environment.SpecialFolder.MyDocuments;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "assets.db");
        }

        public DbSet<Asset> Assets => Set<Asset>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }
    }
}

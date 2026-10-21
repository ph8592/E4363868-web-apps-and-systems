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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Asset>().HasData(
                new Asset(1, "Laptop", Location.Office, DateOnly.FromDateTime(DateTime.Today), true, 1200.00),
                new Asset(2, "Projector", Location.Office, DateOnly.FromDateTime(DateTime.Today), false, 800.00),
                new Asset(3, "Forklift", Location.Warehouse, DateOnly.FromDateTime(DateTime.Today), true, 15000.00),
                new Asset(4, "Printer", Location.Office, DateOnly.FromDateTime(DateTime.Today), false, 300.00),
                new Asset(5, "Pallet Jack", Location.Warehouse, DateOnly.FromDateTime(DateTime.Today), true, 500.00),
                new Asset(6, "Server Rack", Location.Depot, DateOnly.FromDateTime(DateTime.Today), false, 2000.00),
                new Asset(7, "Desktop Computer", Location.Office, DateOnly.FromDateTime(DateTime.Today), true, 1000.00),
                new Asset(8, "Air Conditioner", Location.Depot, DateOnly.FromDateTime(DateTime.Today), false, 1500.00),
                new Asset(9, "Conveyor Belt", Location.Warehouse, DateOnly.FromDateTime(DateTime.Today), true, 7000.00),
                new Asset(10, "Whiteboard", Location.Office, DateOnly.FromDateTime(DateTime.Today), false, 100.00),
                new Asset(11, "3D Printer", Location.Depot, DateOnly.FromDateTime(DateTime.Today), true, 2500.00),
                new Asset(12, "CCTV Camera", Location.Warehouse, DateOnly.FromDateTime(DateTime.Today), false, 400.00),
                new Asset(13, "Router", Location.Office, DateOnly.FromDateTime(DateTime.Today), true, 150.00),
                new Asset(14, "UPS", Location.Depot, DateOnly.FromDateTime(DateTime.Today), false, 300.00),
                new Asset(15, "Barcode Scanner", Location.Warehouse, DateOnly.FromDateTime(DateTime.Today), true, 200.00),
                new Asset(16, "Smartphone", Location.Office, DateOnly.FromDateTime(DateTime.Today), false, 800.00),
                new Asset(17, "Tablet", Location.Depot, DateOnly.FromDateTime(DateTime.Today), true, 600.00),
                new Asset(18, "Digital Camera", Location.Warehouse, DateOnly.FromDateTime(DateTime.Today), false, 500.00),
                new Asset(19, "Laser Cutter", Location.Depot, DateOnly.FromDateTime(DateTime.Today), true, 10000.00),
                new Asset(20, "VR Headset", Location.Office, DateOnly.FromDateTime(DateTime.Today), false, 400.00)
            ); 
        }
    }
}

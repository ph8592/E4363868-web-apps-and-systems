using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace CarSalesApp.Data
{
    public class CarSalesDbContext: DbContext
    {
        public string DbPath { get; }

        public CarSalesDbContext()
        {
            var folder = Environment.SpecialFolder.MyDocuments;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "cars.db");
        }

        public DbSet<Car> Cars => Set<Car>();
    }
}

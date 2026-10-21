using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AssetsDatabase.Data
{
    public class Asset
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public Location Location { get; set; }
        public DateOnly DateAcquired { get; set; }
        public bool InUse { get; set; }
        public double Price { get; set; }

        // Default Constructor
        public Asset()
        {
            Name = string.Empty;
            Location = Location.Office;
            DateAcquired = DateOnly.FromDateTime(DateTime.Today);
            InUse = false;
            Price = 0.0;
        }

        public Asset(int id, string name, Location location, DateOnly dateAcquired, bool inUse, double price)
        {
            Id = id;
            Name = name;
            Location = location;
            DateAcquired = dateAcquired;
            InUse = inUse;
            Price = price;
        }

        public override string ToString()
        {
            var str = Id + ": " + Name + " - " + Location + " (" + DateAcquired + ") £" + Price + " " + (InUse ? "In Use" : "Not In Use");
            return str;
        }
    }

}

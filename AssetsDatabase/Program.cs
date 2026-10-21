using AssetsDatabase.Data;

static void displayAssets(List<Asset> assets)
{
    Console.WriteLine("Assets in Database:");
    foreach (var asset in assets)
    {
        Console.WriteLine(asset);
    }
}

using var db = new AssetDatabaseDbContext();
var assets = db.Assets.ToList();
displayAssets(assets);

//var newAsset = new Asset
//{
//    Name = "Sausage Press",
//    Location = Location.Office,
//    DateAcquired = DateOnly.FromDateTime(DateTime.Today),
//    InUse = true,
//    Price = 999.99
//};
//db.Assets.Add(newAsset);
//db.SaveChanges();

//var asset = db.Assets
//    .Where(a => a.Id == 6)
//    .SingleOrDefault();

//Console.WriteLine($"Before Update: {asset}");
//asset.Price = 1911.26;
//Console.WriteLine($"After Update: {asset}");

//db.SaveChanges();
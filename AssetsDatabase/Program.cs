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


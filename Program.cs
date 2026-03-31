


using CodeLib.Indexer;

var inv = new Inventory();
inv[0] = "Sword";
inv[1] = "Shield";
Console.WriteLine(inv[0]); // Sword
Console.WriteLine(inv[1]); // Shield

var stats = new StatBlock();
Console.WriteLine(stats["Strength"]);  // 10
stats["Mana"] = 20;
Console.WriteLine(stats["Mana"]);      // 20

var grid = new Grid();
grid[0, 0] = 42;
Console.WriteLine(grid[0, 0]); // 42
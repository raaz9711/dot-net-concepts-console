


using CodeLib.Indexer;
using Player;
using static AFP;

// var inv = new Inventory();
// inv[0] = "Sword";
// inv[1] = "Shield";
// Console.WriteLine(inv[0]); // Sword
// Console.WriteLine(inv[1]); // Shield

// var stats = new StatBlock();
// Console.WriteLine(stats["Strength"]);  // 10
// stats["Mana"] = 20;
// Console.WriteLine(stats["Mana"]);      // 20

// var grid = new Grid();
// grid[0, 0] = 42;
// Console.WriteLine(grid[0, 0]); // 42

Predicate<int> isEven = n => n % 2 == 0;

Console.WriteLine(isEven(4)); // True

T Transformer<T>(T value,Func<T,T> transformer)
{
    return transformer(value);
}


Transformer(4,(x) => {Console.WriteLine(x);return x + 4;});

Transformer("s",(x) => {Console.WriteLine(x);return x + 4;});

Action<List<Enemy>> PrintEnemies = (enemies) =>
{
    foreach(var enemy in enemies)
    {
        Console.WriteLine($"Enemy: {enemy.Name}, HP: {enemy.Health}, Damage: {enemy.Damage}");
    }
};

Action<List<string?>> PrintNames = (enemies) =>
{
    foreach(var enemy in enemies)
    {
        Console.WriteLine($"Enemy: {enemy.Name}, HP: {enemy.Health}, Damage: {enemy.Damage}");
    }
};

var afp = new AFP();
List<Enemy> enemies = afp.GetAllEnemies (5);

PrintEnemies(enemies);

// Func and Predicate as inline LINQ operations
var dangerous = enemies
    .Where(e => e.Damage > 50)           // Predicate — filter
    .OrderBy(e => e.Health)              // Func — sort key
    .Select(e => e.Name)                 // Func — transform
    .ToList();

PrintEnemies(dangerous);


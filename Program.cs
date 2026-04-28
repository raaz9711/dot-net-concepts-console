


// using CodeLib.Indexer;
// using Player;
// using static AFP;

// // var inv = new Inventory();
// // inv[0] = "Sword";
// // inv[1] = "Shield";
// // Console.WriteLine(inv[0]); // Sword
// // Console.WriteLine(inv[1]); // Shield

// // var stats = new StatBlock();
// // Console.WriteLine(stats["Strength"]);  // 10
// // stats["Mana"] = 20;
// // Console.WriteLine(stats["Mana"]);      // 20

// // var grid = new Grid();
// // grid[0, 0] = 42;
// // Console.WriteLine(grid[0, 0]); // 42

// Predicate<int> isEven = n => n % 2 == 0;

// Console.WriteLine(isEven(4)); // True

// T Transformer<T>(T value,Func<T,T> transformer)
// {
//     return transformer(value);
// }


// Transformer(4,(x) => {Console.WriteLine(x);return x + 4;});

// Transformer("s",(x) => {Console.WriteLine(x);return x + 4;});

// Action<List<Enemy>> PrintEnemies = (enemies) =>
// {
//     foreach(var enemy in enemies)
//     {
//         Console.WriteLine($"Enemy: {enemy.Name}, HP: {enemy.Health}, Damage: {enemy.Damage}");
//     }
// };



// var afp = new AFP();
// List<Enemy> enemies = afp.GetAllEnemies (5);

// PrintEnemies(enemies);

// // Func and Predicate as inline LINQ operations
// var dangerous = enemies
//     .Where(e => e.Damage > 50)           // Predicate — filter
//     .OrderBy(e => e.Health)              // Func — sort key
//     .Select(e => e.Name)                 // Func — transform
//     .ToList();



// var solution = new Dummy.Solution();
// Console.WriteLine(solution.CheckInclusion("abc", "cbadef")); // True
// System.Console.WriteLine("------------------------------");
// Console.WriteLine(solution.CheckInclusion("ab", "eidboaoo")); // False
// System.Console.WriteLine("------------------------------");
// Console.WriteLine(solution.CheckInclusion("adc", "dcda")); // True

// int n = 2;
// Basic.DoubleIt(n);
// Console.WriteLine(n); // 2

// Basic.DoubleIt(ref n);
// Console.WriteLine(n); // 4

// Basic.GetStats(out int health, out int mana);
// Console.WriteLine($"Health: {health}, Mana: {mana}"); // Health:

// using ClassLinq;

// List<Enemy> enemies = new()
// {
//     new Enemy { Name = "Goblin",   Health = 30,  Damage = 10, Type = "Minion", IsAlive = true  },
//     new Enemy { Name = "Orc",      Health = 80,  Damage = 25, Type = "Elite",  IsAlive = true  },
//     new Enemy { Name = "Dragon",   Health = 200, Damage = 80, Type = "Boss",   IsAlive = true  },
//     new Enemy { Name = "Troll",    Health = 120, Damage = 40, Type = "Elite",  IsAlive = false },
//     new Enemy { Name = "Imp",      Health = 20,  Damage = 8,  Type = "Minion", IsAlive = true  },
//     new Enemy { Name = "Lich",     Health = 150, Damage = 70, Type = "Boss",   IsAlive = false },
// };

// // all alive enemeys :

// var allAliveEnemies = enemies.Where(e => e.IsAlive).ToList();

// var boss =  enemies.Where(e => e.Type == "Boss").ToList();

// var grouped = enemies.GroupBy(e => e.Type);

// foreach (var group in grouped)
// {
//     Console.WriteLine($"\n{group.Key}:");
//     foreach (var enemy in group)
//         Console.WriteLine($"  {enemy.Name} — HP:{enemy.Health}");
// }  

using Dummy;


// var s = solution.FindAnagrams("cbaebabacd","abc");
// foreach(var i in s)
// {
//     System.Console.WriteLine(i);
// }

var diff = new DifferenceArray(new int[] { 1, 2, 3, 4, 5 });
diff.RangeAdd(1, 3, 10);
var result = diff.Rebuild();
Console.WriteLine("Final array after updates: " + string.Join(", ", result));
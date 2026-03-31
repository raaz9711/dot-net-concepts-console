namespace CodeLib.Indexer;

// Basic example of an indexer in C#
public class Inventory
{
    private string[] _items = new string[10];

    // indexer definition
    public string this[int index]
    {
        get => _items[index];
        set => _items[index] = value;
    }
}

// var inv = new Inventory();
// inv[0] = "Sword";
// inv[1] = "Shield";
// Console.WriteLine(inv[0]); // Sword


public class StatBlock
{
    private Dictionary<string, int> _stats = new()
    {
        { "Strength", 10 },
        { "Agility",  8  },
        { "Mana",     15 }
    };

    public int this[string statName]
    {
        get => _stats.TryGetValue(statName, out int val) ? val : 0;
        set => _stats[statName] = value;
    }
}

// var stats = new StatBlock();
// Console.WriteLine(stats["Strength"]);  // 10
// stats["Mana"] = 20;
// Console.WriteLine(stats["Mana"]);      // 20

public class Grid
{
    private int[,] _cells = new int[10, 10];

    public int this[int row, int col]
    {
        get => _cells[row, col];
        set => _cells[row, col] = value;
    }
}

// var grid = new Grid();
// grid[0, 0] = 42;
// Console.WriteLine(grid[0, 0]); // 42
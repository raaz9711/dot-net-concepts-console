namespace ClassLinq;
public class Enemy
{
    public string? Name     { get; set; }
    public int    Health   { get; set; }
    public int    Damage   { get; set; }
    public string? Type     { get; set; }  // "Boss", "Minion", "Elite"
    public bool   IsAlive  { get; set; }

    public override string ToString()
    {
        return $"Name - {Name} \n Health - {Health} \n Damage - {Damage} \n Type - {Type} \n IsAlive - {IsAlive}";
    }
}


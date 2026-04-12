namespace Player;
public class DamageContext
{
    public int BaseDamage { get; set; }
    public int Multiplier { get; set; }
    public bool IsCritical { get; set; }
    public string? EnemyType { get; set; }
    // ... as many fields as needed

    public DamageContext(int baseDamage,int multiplier
    ,bool isCritical,string? enemyType
    )
    {
        BaseDamage = baseDamage;
        Multiplier = multiplier;
        IsCritical = isCritical;
        EnemyType = enemyType;
    }
}

public class Person
{
    public string? Name { get; set; }
    public DateOnly DOB {get;set;}
}
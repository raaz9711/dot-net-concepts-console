public static class Basic
{
    public static void DoubleIt(int x) { x = x * 2; }
    public static void DoubleIt(ref int x) { x = x * 2; }
    public static void  Out(out int x) { x = 2 * 2; }

    public static void GetStats(out int health, out int mana)
    {
        health = 100;
        mana = 50;
    }

}
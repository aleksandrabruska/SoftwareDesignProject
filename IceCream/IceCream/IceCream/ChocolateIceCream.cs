namespace IceCream;

public class ChocolateIceCream : IceCream
{
    public ChocolateIceCream()
    {
    }
    
    public override string getLevelName(int level)
    {
        string lv = getLevelIndicator(level);

        return (lv + "Chocolate ice cream");
    }
    
    public override float cost()
    {
        return 4.0f;
    }
}
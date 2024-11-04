namespace IceCream;

public class ChocolateIceCream : IceCream
{
    public ChocolateIceCream()
    {
    }
    
    public override string getLevelName(int level)
    {
        string lv = "";
        for (int i = 0; i < level; i++)
            lv += " = ";
        return (lv + "Chocolate ice cream");
    }
    
    public override float cost()
    {
        return 4.0f;
    }
}
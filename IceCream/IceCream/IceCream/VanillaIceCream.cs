namespace IceCream;

public class VanillaIceCream : IceCream
{
    public VanillaIceCream()
    {
        
    }
    
    public override string getLevelName(int level)
    {
        string lv = getLevelIndicator(level);
        return (lv + "Vanilla Ice cream");
    }
    
    public override float cost()
    {
        return 2.0f;
    }
}
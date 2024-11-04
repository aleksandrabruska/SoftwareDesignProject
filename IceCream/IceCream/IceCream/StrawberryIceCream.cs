namespace IceCream;

public class StrawberryIceCream : IceCream
{
    public StrawberryIceCream()
    {
        
    }
    
    public override string getLevelName(int level)
    {
        string lv = getLevelIndicator(level);
        return (lv + "Strawberry Ice cream");
    }
    
    public override float cost()
    {
        return 3.0f;
    }
}
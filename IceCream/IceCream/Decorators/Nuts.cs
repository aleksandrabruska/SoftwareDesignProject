namespace IceCream;

public class Nuts : IceCreamToppingDecorator
{
    public Nuts(IceCream iceCream)
    {
        this._iceCream = iceCream;
    }
    public override float cost()
    {
        return 0.5f + this._iceCream.cost();
    }
    
    public override string getLevelName(int level)
    {
        string lv = getLevelIndicator(level);

        return (lv + "Nuts\n") + this._iceCream.getLevelName(level + 1);
    }
    
}
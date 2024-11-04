namespace IceCream;

public class WhippedCream : IceCreamToppingDecorator
{
    public WhippedCream(IceCream iceCream)
    {
        this._iceCream = iceCream;
    }
    public override float cost()
    {
        return 0.7f + this._iceCream.cost();
    }
    
    public override string getLevelName(int level)
    {
        string lv = getLevelIndicator(level);
        return (lv + "Whipped Cream\n") + this._iceCream.getLevelName(level + 1);
    }
}
namespace IceCream;

public class ChocolateSauce : IceCreamToppingDecorator
{
    public ChocolateSauce(IceCream iceCream)
    {
        this._iceCream = iceCream;
    }
    public override float cost()
    {
        return 0.9f + this._iceCream.cost();
    }

    public override string getLevelName(int level)
    {
        string lv = getLevelIndicator(level);
        return (lv + "Chocolate Sauce \n") + this._iceCream.getLevelName(level + 1);
    }
}